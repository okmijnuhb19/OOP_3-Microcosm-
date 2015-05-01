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
        private Watch watch;
    
        public Watch Watch { get{ return GetWatch(); } }
        public string WatchType { get { return watchType.Text; } set { SetWatchType(value); } }

        public WatchControl() 
        {
            InitializeComponent();
        }

        public WatchControl(Watch watch)
            :this()
        {
            this.watch = watch;
        }

        public void Add(Control c)
        {
            c.Parent = this;
            this.Controls.Add(c);
        }

        public IEnumerable<WatchField> GetWatchFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is WatchField)
                {
                    yield return (c as WatchField);
                }
            }
        }

        public Dictionary<string, string> GetWatchFieldsAsDictionary()
        {
            var dic = new Dictionary<string, string>();
            foreach (WatchField wf in GetWatchFields())
            {
                dic.Add(wf.fieldName.Text, wf.fieldValue.Text);
            }

            return dic;
        }

        private Watch GetWatch()
        {
            var visitor = new WatchInitVisitor(GetWatchFieldsAsDictionary());
            return visitor.DynemicVisit(watch);
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
            this.Size = new System.Drawing.Size(139, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
