using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VideoPlayerControl
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
           

            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            //videoPlayerXtraUserControl1.Init( @"rtmp://localhost:1935/archive-tvz/{749b84ad-0080-4c5a-88f6-8670fdf551ea}?from=1425929256523&to=1425929351406" );
            videoPlayerXtraUserControl1.Init(@"rtmp://localhost:1935/live-tvz/{749b84ad-0080-4c5a-88f6-8670fdf551ea}");
        }
    }
}