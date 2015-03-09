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
            videoPlayerXtraUserControl1.Duration = TimeSpan.FromMilliseconds(21958);
            videoPlayerXtraUserControl1.Init(@"rtmp://localhost:1935/archive-tvz/{43c6fca9-0080-4207-996e-2cb79838053f}?from=1425830988122&to=1425831010080"); 
        }
    }
}