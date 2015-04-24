using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchLib
{
    public class WatchField : UserControl
    {
        public Label fieldName;
        public TextBox fieldValue;
        
        public WatchField(string fieldName, string value)
        {
            InitializeComponent();

            this.fieldName.Text = fieldName;
            this.fieldValue.Text = value;
        }

        private void InitializeComponent()
        {
            this.fieldName = new System.Windows.Forms.Label();
            this.fieldValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fieldName
            // 
            this.fieldName.AutoSize = true;
            this.fieldName.Location = new System.Drawing.Point(3, 0);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(35, 13);
            this.fieldName.TabIndex = 0;
            this.fieldName.Text = "label1";
            // 
            // fieldValue
            // 
            this.fieldValue.Location = new System.Drawing.Point(6, 16);
            this.fieldValue.Name = "fieldValue";
            this.fieldValue.Size = new System.Drawing.Size(100, 20);
            this.fieldValue.TabIndex = 1;
            // 
            // WatchField
            // 
            this.Controls.Add(this.fieldValue);
            this.Controls.Add(this.fieldName);
            this.Name = "WatchField";
            this.Size = new System.Drawing.Size(173, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
