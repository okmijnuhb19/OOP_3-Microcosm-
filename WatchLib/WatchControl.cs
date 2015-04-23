using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchLib
{
    public class WatchControl : UserControl
    {
        private Label watchType;
    
        public Watch Watch { get; set; }
        public string WatchType { get { return watchType.Text; } set { SetWatchType(value); } }

        public WatchControl() 
        {
            InitializeComponent();
        }

        public WatchControl(Watch watch)
            :this()
        {

            this.Watch = watch;
        }

        public void Add(Control c)
        {
            this.Controls.Add(c);
        }

        private void SetWatchType(string type)
        {
            watchType.Text = type;
        }

        private void InitializeComponent()
        {
            this.watchType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // watchType
            // 
            this.watchType.AutoSize = true;
            this.watchType.Location = new System.Drawing.Point(4, 4);
            this.watchType.Name = "watchType";
            this.watchType.Size = new System.Drawing.Size(66, 13);
            this.watchType.TabIndex = 0;
            this.watchType.Text = "Watch Type";
            // 
            // WatchControl
            // 
            this.Controls.Add(this.watchType);
            this.Name = "WatchControl";
            this.Size = new System.Drawing.Size(187, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
