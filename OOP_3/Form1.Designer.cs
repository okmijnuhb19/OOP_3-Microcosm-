﻿namespace OOP_3
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
            this.AtomInf = new System.Windows.Forms.TextBox();
            this.UnSerAtomInf = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.DeleteNodeBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AtomInf
            // 
            this.AtomInf.Location = new System.Drawing.Point(350, 12);
            this.AtomInf.Name = "AtomInf";
            this.AtomInf.Size = new System.Drawing.Size(100, 20);
            this.AtomInf.TabIndex = 0;
            // 
            // UnSerAtomInf
            // 
            this.UnSerAtomInf.Location = new System.Drawing.Point(350, 38);
            this.UnSerAtomInf.Name = "UnSerAtomInf";
            this.UnSerAtomInf.Size = new System.Drawing.Size(100, 20);
            this.UnSerAtomInf.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(315, 218);
            this.treeView.TabIndex = 3;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // DeleteNodeBtn
            // 
            this.DeleteNodeBtn.Location = new System.Drawing.Point(375, 64);
            this.DeleteNodeBtn.Name = "DeleteNodeBtn";
            this.DeleteNodeBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteNodeBtn.TabIndex = 4;
            this.DeleteNodeBtn.Text = "Delete";
            this.DeleteNodeBtn.UseVisualStyleBackColor = true;
            this.DeleteNodeBtn.Click += new System.EventHandler(this.DeleteNodeBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(252, 236);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(171, 236);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 325);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteNodeBtn);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.UnSerAtomInf);
            this.Controls.Add(this.AtomInf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AtomInf;
        private System.Windows.Forms.TextBox UnSerAtomInf;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button DeleteNodeBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;

    }
}

