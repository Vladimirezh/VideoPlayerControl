using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using VideoPlayer.Properties;
using Vlc.DotNet.Core;
using Vlc.DotNet.Core.Interops.Signatures;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Forms.TypeEditors;

namespace VideoPlayer
{
    public sealed partial class VideoPlayerXtraUserControl : XtraUserControl
    {
        private readonly VlcControl playerControl = new VlcControl();
        private TimeSpan duration = TimeSpan.Zero;
        private IDisposable endReachedSubscription;
        private IDisposable playingSubscription;
        private IDisposable repeatSubscription;
        private IDisposable timeChangedSubscription;
        private Uri videoUrl;

        public VideoPlayerXtraUserControl()
        {
            InitializeComponent();
            ProcessProgress();
        }

        [Category( "Video control settings" )]
        [Editor( typeof ( DirectoryEditor ), typeof ( UITypeEditor ) )]
// ReSharper disable once MemberCanBePrivate.Global
        public DirectoryInfo VlcLibDirectory
        {
// ReSharper disable once UnusedMember.Global
            set { playerControl.VlcLibDirectory = value; }
            get { return playerControl.VlcLibDirectory; }
        }

// ReSharper disable once MemberCanBePrivate.Global
        public TimeSpan Duration
        {
// ReSharper disable once UnusedMember.Global
            set
            {
                if ( duration == value )
                    return;

                duration = value;
                ProcessProgress();
            }
            get { return duration; }
        }

        public bool ShowNavigation { set; get; }

        private void InitPlayerControl()
        {
            playerControl.BeginInit();
            panelControlVideo.Controls.Add( playerControl );
            playerControl.Dock = DockStyle.Fill;
            timeChangedSubscription =
                Observable.FromEventPattern< EventHandler< VlcMediaPlayerTimeChangedEventArgs >, VlcMediaPlayerTimeChangedEventArgs >( h => playerControl.TimeChanged += h, h => playerControl.TimeChanged -= h ).
                    ObserveOn( SynchronizationContext.Current ).
                    Subscribe( e => PlayerControlOnTimeChanged( e.EventArgs ) );
            endReachedSubscription =
                Observable.FromEventPattern< EventHandler< VlcMediaPlayerEndReachedEventArgs >, VlcMediaPlayerEndReachedEventArgs >( h => playerControl.EndReached += h, h => playerControl.EndReached -= h ).
                    ObserveOn( SynchronizationContext.Current ).
                    Subscribe( e => PlayerControlOnEndReached() );
            playingSubscription =
                Observable.FromEventPattern< EventHandler< VlcMediaPlayerPlayingEventArgs >, VlcMediaPlayerPlayingEventArgs >( h => playerControl.Playing += h, h => playerControl.Playing -= h ).
                    ObserveOn( SynchronizationContext.Current ).
                    Subscribe( e => PlayerControlOnPlaying() );

            playerControl.EndInit();
        }

        private void PlayerControlOnEndReached()
        {
            progressBarControl1.Position = 0;
            layoutControlItemImage.Visibility = LayoutVisibility.Always;
            layoutControlItemVideo.Visibility = layoutControlItemButton.Visibility = layoutControlIteProgress.Visibility = LayoutVisibility.Never;
            pictureEdit1.Image = Resources.repeat_128;
            repeatSubscription = Observable.FromEventPattern< EventHandler, EventArgs >( h => pictureEdit1.Click += h, h => pictureEdit1.Click -= h ).Subscribe( e => StartPlaying() );
        }

        private void PlayerControlOnTimeChanged( VlcMediaPlayerTimeChangedEventArgs e )
        {
            progressBarControl1.Position = ( int ) e.NewTime;
        }

        private void PlayerControlOnPlaying()
        {
            layoutControlItemImage.Visibility = LayoutVisibility.Never;
            layoutControlItemVideo.Visibility = layoutControlItemButton.Visibility = layoutControlIteProgress.Visibility = LayoutVisibility.Always;
            simpleButtonPlayStop.Image = Resources.pause_32;
        }

        protected override void Dispose( bool disposing )
        {
            if ( disposing )
            {
                if ( repeatSubscription != null )
                    repeatSubscription.Dispose();
                if ( timeChangedSubscription != null )
                    timeChangedSubscription.Dispose();
                if ( playingSubscription != null )
                    playingSubscription.Dispose();
                if ( endReachedSubscription != null )
                    endReachedSubscription.Dispose();
                if ( components != null )
                    components.Dispose();
                if ( playerControl != null )
                {
                    try
                    {
                        playerControl.Stop();
                        playerControl.Dispose();
                    }
                    catch ( AccessViolationException )
                    {
                    }
                }
            }
            base.Dispose( disposing );
        }

        public void Init( string url )
        {
            InitPlayerControl();
            videoUrl = new Uri( url );
            StartPlaying();
        }

        private void StartPlaying()
        {
            if ( repeatSubscription != null )
                repeatSubscription.Dispose();
            pictureEdit1.Image = Resources.WaitGear;
            playerControl.Play( videoUrl );
        }

        private void ProcessProgress()
        {
            progressBarControl1.Properties.Maximum = Convert.ToInt32( Duration.TotalMilliseconds );
        }

        private void progressBarControl1_MouseDown( object sender, MouseEventArgs e )
        {
            if ( playerControl.State != MediaStates.Playing && playerControl.State != MediaStates.Stopped )
                playerControl.Play( videoUrl );
            playerControl.Time = GetTimeValue( e.Location );
        }

        private void simpleButtonPlayStop_Click( object sender, EventArgs e )
        {
            if ( playerControl.IsPlaying )
            {
                playerControl.Pause();
                simpleButtonPlayStop.Image = Resources.play_32;
            }
            else
            {
                playerControl.Play();
                simpleButtonPlayStop.Image = Resources.pause_32;
            }
        }

        private void progressBarControl1_Properties_MouseMove( object sender, MouseEventArgs e )
        {
            progressBarControl1.ToolTipController.ShowHint( TimeSpan.FromMilliseconds( GetTimeValue( e.Location ) ).ToString( @"hh\:mm\:ss\.f" ), progressBarControl1.PointToScreen( e.Location ) );
        }

        private int GetTimeValue( Point e )
        {
            return Convert.ToInt32( e.X * 1f / progressBarControl1.Width * progressBarControl1.Properties.Maximum );
        }
    }
}