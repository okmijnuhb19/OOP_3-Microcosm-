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
            this.watchComboBox = new WatchLib.WatchComboBox();
            this.addPluginBtn = new System.Windows.Forms.Button();
            this.SavingOptionComboBox = new WatchLib.WatchComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            // watchComboBox
            // 
            this.watchComboBox.FormattingEnabled = true;
            this.watchComboBox.Location = new System.Drawing.Point(192, 292);
            this.watchComboBox.Name = "watchComboBox";
            this.watchComboBox.Size = new System.Drawing.Size(121, 21);
            this.watchComboBox.TabIndex = 8;
            // 
            // addPluginBtn
            // 
            this.addPluginBtn.Location = new System.Drawing.Point(13, 289);
            this.addPluginBtn.Name = "addPluginBtn";
            this.addPluginBtn.Size = new System.Drawing.Size(75, 23);
            this.addPluginBtn.TabIndex = 9;
            this.addPluginBtn.Text = "Add plugin";
            this.addPluginBtn.UseVisualStyleBackColor = true;
            this.addPluginBtn.Click += new System.EventHandler(this.addPluginBtn_Click);
            // 
            // SavingOptionComboBox
            // 
            this.SavingOptionComboBox.FormattingEnabled = true;
            this.SavingOptionComboBox.Location = new System.Drawing.Point(495, 27);
            this.SavingOptionComboBox.Name = "SavingOptionComboBox";
            this.SavingOptionComboBox.Size = new System.Drawing.Size(142, 21);
            this.SavingOptionComboBox.TabIndex = 10;
            this.SavingOptionComboBox.SelectedValueChanged += new System.EventHandler(this.SavingOptionComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Saving Option:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavingOptionComboBox);
            this.Controls.Add(this.addPluginBtn);
            this.Controls.Add(this.watchComboBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteNodeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            watchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SavingOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        #endregion

        private System.Windows.Forms.Button DeleteNodeBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button AddBtn;
        private WatchLib.WatchComboBox watchComboBox;
        private System.Windows.Forms.Button addPluginBtn;
        private WatchLib.WatchComboBox SavingOptionComboBox;
        private System.Windows.Forms.Label label1;

    }
}

