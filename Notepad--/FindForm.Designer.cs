
namespace Notepad__
{
    partial class FindForm
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
            this.search_field = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.what_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_field
            // 
            this.search_field.Location = new System.Drawing.Point(26, 50);
            this.search_field.Name = "search_field";
            this.search_field.Size = new System.Drawing.Size(232, 20);
            this.search_field.TabIndex = 0;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(284, 19);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(75, 23);
            this.find_button.TabIndex = 1;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(284, 50);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // what_label
            // 
            this.what_label.AutoSize = true;
            this.what_label.Location = new System.Drawing.Point(23, 19);
            this.what_label.Name = "what_label";
            this.what_label.Size = new System.Drawing.Size(117, 13);
            this.what_label.TabIndex = 3;
            this.what_label.Text = "What you want to find?";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 86);
            this.Controls.Add(this.what_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.search_field);
            this.MaximumSize = new System.Drawing.Size(389, 125);
            this.MinimumSize = new System.Drawing.Size(389, 125);
            this.Name = "FindForm";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label what_label;
        public System.Windows.Forms.TextBox search_field;
    }
}