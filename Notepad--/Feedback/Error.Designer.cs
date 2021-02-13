
namespace Notepad__.Feedback
{
    partial class Error
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.Error_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.less_link = new System.Windows.Forms.LinkLabel();
            this.gmail_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_label.Location = new System.Drawing.Point(12, 9);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(557, 17);
            this.Error_label.TabIndex = 0;
            this.Error_label.Text = "An error occurred. It could happen for the following reasons:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Invalid email/password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 64);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. The SMTP server requires a secure connection.\r\nTo solve this you can visit    " +
    "        and turn on less secure apps\r\naccess or go by yourself to            and" +
    " write your feedback there.\r\n\r\n";
            // 
            // less_link
            // 
            this.less_link.AutoSize = true;
            this.less_link.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.less_link.Location = new System.Drawing.Point(234, 77);
            this.less_link.Name = "less_link";
            this.less_link.Size = new System.Drawing.Size(89, 17);
            this.less_link.TabIndex = 3;
            this.less_link.TabStop = true;
            this.less_link.Text = "this page";
            this.less_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.less_link_LinkClicked);
            // 
            // gmail_link
            // 
            this.gmail_link.AutoSize = true;
            this.gmail_link.BackColor = System.Drawing.Color.Transparent;
            this.gmail_link.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail_link.ForeColor = System.Drawing.Color.Transparent;
            this.gmail_link.Location = new System.Drawing.Point(234, 93);
            this.gmail_link.Name = "gmail_link";
            this.gmail_link.Size = new System.Drawing.Size(89, 17);
            this.gmail_link.TabIndex = 4;
            this.gmail_link.TabStop = true;
            this.gmail_link.Text = "gmail.com";
            this.gmail_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gmail_link_LinkClicked);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 123);
            this.Controls.Add(this.less_link);
            this.Controls.Add(this.gmail_link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Error_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error";
            this.Text = "ERROR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel less_link;
        private System.Windows.Forms.LinkLabel gmail_link;
    }
}