using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchLib
{
    public class WatchCreatingControl : UserControl
    {
        private Label watchType;
        public Button CreateBtn;

        public Watch Watch { get; set; }
        public string WatchType { get { return watchType.Text; } set { SetWatchType(value); } }

        public WatchCreatingControl()
        {
            InitializeComponent();
        }

        public WatchCreatingControl(Watch watch)
            : this()
        {
            this.Watch = watch;
        }

        private void SetWatchType(string type)
        {
            watchType.Text = type;
        }

        public void Add(Control c)
        {
            c.Parent = this;
            this.Controls.Add(c);
        }

        public IEnumerable<WatchField> GetWatchFields()
        {
            foreach(Control c in this.Controls)
            {
                if(c is WatchField)
                {
                    yield return (c as WatchField);
                }
            }
        }

        public Dictionary<string, string> GetWatchFieldsAsDictionary()
        {
            var dic = new Dictionary<string, string>();
            foreach(WatchField wf in GetWatchFields())
            {
                dic.Add(wf.fieldName.Text, wf.fieldValue.Text);
            }

            return dic;
        }

        private void InitializeComponent()
        {
            this.CreateBtn = new System.Windows.Forms.Button();
            this.watchType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(6, 24);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // watchType
            // 
            this.watchType.AutoSize = true;
            this.watchType.Location = new System.Drawing.Point(3, 8);
            this.watchType.Name = "watchType";
            this.watchType.Size = new System.Drawing.Size(31, 13);
            this.watchType.TabIndex = 1;
            this.watchType.Text = "Type";
            // 
            // WatchCreatingControl
            // 
            this.Controls.Add(this.watchType);
            this.Controls.Add(this.CreateBtn);
            this.Name = "WatchCreatingControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
