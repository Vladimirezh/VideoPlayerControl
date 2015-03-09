namespace VideoPlayer
{
    sealed partial class VideoPlayerXtraUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.simpleButtonPlayStop = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControlVideo = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemVideo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlIteProgress = new DevExpress.XtraLayout.LayoutControlItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIteProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.progressBarControl1);
            this.layoutControl1.Controls.Add(this.simpleButtonPlayStop);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(663, 64, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(636, 343);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarControl1.Location = new System.Drawing.Point(46, 313);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBarControl1_Properties_MouseMove);
            this.progressBarControl1.Size = new System.Drawing.Size(590, 18);
            this.progressBarControl1.StyleController = this.layoutControl1;
            this.progressBarControl1.TabIndex = 8;
            this.progressBarControl1.ToolTip = "ToolTip";
            this.progressBarControl1.ToolTipController = this.toolTipController1;
            this.progressBarControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBarControl1_MouseDown);
            // 
            // toolTipController1
            // 
            this.toolTipController1.InitialDelay = 100;
            this.toolTipController1.ReshowDelay = 500;
            this.toolTipController1.ShowBeak = true;
            // 
            // simpleButtonPlayStop
            // 
            this.simpleButtonPlayStop.Image = global::VideoPlayer.Properties.Resources.play_32;
            this.simpleButtonPlayStop.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButtonPlayStop.Location = new System.Drawing.Point(0, 301);
            this.simpleButtonPlayStop.Name = "simpleButtonPlayStop";
            this.simpleButtonPlayStop.Size = new System.Drawing.Size(46, 42);
            this.simpleButtonPlayStop.StyleController = this.layoutControl1;
            this.simpleButtonPlayStop.TabIndex = 7;
            this.simpleButtonPlayStop.Click += new System.EventHandler(this.simpleButtonPlayStop_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl2);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(636, 301);
            this.panelControl1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.panelControlVideo);
            this.layoutControl2.Controls.Add(this.pictureEdit1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1164, 177, 250, 350);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(632, 297);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // panelControlVideo
            // 
            this.panelControlVideo.Location = new System.Drawing.Point(0, 148);
            this.panelControlVideo.Name = "panelControlVideo";
            this.panelControlVideo.Size = new System.Drawing.Size(632, 149);
            this.panelControlVideo.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::VideoPlayer.Properties.Resources.WaitGear;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.InitialImage = global::VideoPlayer.Properties.Resources.WaitGear;
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Size = new System.Drawing.Size(628, 144);
            this.pictureEdit1.StyleController = this.layoutControl2;
            this.pictureEdit1.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemImage,
            this.layoutControlItemVideo});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(632, 297);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItemImage
            // 
            this.layoutControlItemImage.Control = this.pictureEdit1;
            this.layoutControlItemImage.CustomizationFormText = "layoutControlItemImage";
            this.layoutControlItemImage.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemImage.Name = "layoutControlItemImage";
            this.layoutControlItemImage.Size = new System.Drawing.Size(632, 148);
            this.layoutControlItemImage.Text = "layoutControlItemImage";
            this.layoutControlItemImage.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemImage.TextToControlDistance = 0;
            this.layoutControlItemImage.TextVisible = false;
            // 
            // layoutControlItemVideo
            // 
            this.layoutControlItemVideo.Control = this.panelControlVideo;
            this.layoutControlItemVideo.CustomizationFormText = "layoutControlItemVideo";
            this.layoutControlItemVideo.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItemVideo.Name = "layoutControlItemVideo";
            this.layoutControlItemVideo.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItemVideo.Size = new System.Drawing.Size(632, 149);
            this.layoutControlItemVideo.Text = "layoutControlItemVideo";
            this.layoutControlItemVideo.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemVideo.TextToControlDistance = 0;
            this.layoutControlItemVideo.TextVisible = false;
            this.layoutControlItemVideo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItemButton,
            this.layoutControlIteProgress});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(636, 343);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(636, 301);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItemButton
            // 
            this.layoutControlItemButton.Control = this.simpleButtonPlayStop;
            this.layoutControlItemButton.CustomizationFormText = "layoutControlItemButton";
            this.layoutControlItemButton.Location = new System.Drawing.Point(0, 301);
            this.layoutControlItemButton.MaxSize = new System.Drawing.Size(46, 42);
            this.layoutControlItemButton.MinSize = new System.Drawing.Size(46, 42);
            this.layoutControlItemButton.Name = "layoutControlItemButton";
            this.layoutControlItemButton.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItemButton.Size = new System.Drawing.Size(46, 42);
            this.layoutControlItemButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemButton.Text = "layoutControlItemButton";
            this.layoutControlItemButton.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemButton.TextToControlDistance = 0;
            this.layoutControlItemButton.TextVisible = false;
            this.layoutControlItemButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlIteProgress
            // 
            this.layoutControlIteProgress.Control = this.progressBarControl1;
            this.layoutControlIteProgress.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlIteProgress.CustomizationFormText = "layoutControlIteProgress";
            this.layoutControlIteProgress.Location = new System.Drawing.Point(46, 301);
            this.layoutControlIteProgress.Name = "layoutControlIteProgress";
            this.layoutControlIteProgress.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0);
            this.layoutControlIteProgress.Size = new System.Drawing.Size(590, 42);
            this.layoutControlIteProgress.Text = "layoutControlIteProgress";
            this.layoutControlIteProgress.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlIteProgress.TextToControlDistance = 0;
            this.layoutControlIteProgress.TextVisible = false;
            this.layoutControlIteProgress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar"});
            // 
            // VideoPlayerXtraUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "VideoPlayerXtraUserControl";
            this.Size = new System.Drawing.Size(636, 343);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIteProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPlayStop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlIteProgress;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.PanelControl panelControlVideo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemImage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemVideo;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}
