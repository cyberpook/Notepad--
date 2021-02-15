
namespace Notepad__.Feedback
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.CANCEL_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(44, 23);
            this.passwordBox.Text.PasswordChar = '*';
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(264, 22);
            this.passwordBox.TabIndex = 1;
            // 
            // OK_button
            // 
            this.OK_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_button.ForeColor = System.Drawing.Color.White;
            this.OK_button.Location = new System.Drawing.Point(44, 51);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(126, 32);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = false;
            // 
            // CANCEL_button
            // 
            this.CANCEL_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.CANCEL_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCEL_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CANCEL_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL_button.ForeColor = System.Drawing.Color.White;
            this.CANCEL_button.Location = new System.Drawing.Point(176, 51);
            this.CANCEL_button.Name = "CANCEL_button";
            this.CANCEL_button.Size = new System.Drawing.Size(132, 32);
            this.CANCEL_button.TabIndex = 3;
            this.CANCEL_button.Text = "Cancel";
            this.CANCEL_button.UseVisualStyleBackColor = false;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 84);
            this.Controls.Add(this.CANCEL_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.passwordBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Password";
            this.Text = "PASSWORD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button CANCEL_button;
    }
}
