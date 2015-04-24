namespace OOP_3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteNodeBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteNodeBtn
            // 
            this.DeleteNodeBtn.Location = new System.Drawing.Point(562, 290);
            this.DeleteNodeBtn.Name = "DeleteNodeBtn";
            this.DeleteNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteNodeBtn.TabIndex = 4;
            this.DeleteNodeBtn.Text = "Delete";
            this.DeleteNodeBtn.UseVisualStyleBackColor = true;
            this.DeleteNodeBtn.Click += new System.EventHandler(this.DeleteNodeBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(481, 290);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(400, 290);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(319, 290);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 325);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteNodeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteNodeBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button AddBtn;

    }
}

