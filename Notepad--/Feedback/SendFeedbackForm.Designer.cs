
namespace Notepad__
{
    partial class SendFeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendFeedbackForm));
            this.labelFrom = new System.Windows.Forms.Label();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.body_box = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ToEmail = new System.Windows.Forms.ComboBox();
            this.AddFiles_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(1, 32);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(48, 18);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // FromEmail
            // 
            this.FromEmail.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromEmail.Location = new System.Drawing.Point(77, 25);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(355, 25);
            this.FromEmail.TabIndex = 1;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(1, 63);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(32, 18);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "To:";
            // 
            // subject
            // 
            this.subject.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(77, 99);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(355, 30);
            this.subject.TabIndex = 4;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(1, 111);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(72, 18);
            this.labelSubject.TabIndex = 5;
            this.labelSubject.Text = "Subject:";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBody.Location = new System.Drawing.Point(1, 149);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(48, 18);
            this.labelBody.TabIndex = 6;
            this.labelBody.Text = "Body:";
            // 
            // body_box
            // 
            this.body_box.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body_box.Location = new System.Drawing.Point(77, 149);
            this.body_box.Multiline = true;
            this.body_box.Name = "body_box";
            this.body_box.Size = new System.Drawing.Size(355, 200);
            this.body_box.TabIndex = 7;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(204, 394);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(228, 44);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ToEmail
            // 
            this.ToEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToEmail.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToEmail.FormattingEnabled = true;
            this.ToEmail.Items.AddRange(new object[] {
            "maxvill2016@gmail.com"});
            this.ToEmail.Location = new System.Drawing.Point(77, 55);
            this.ToEmail.Name = "ToEmail";
            this.ToEmail.Size = new System.Drawing.Size(355, 26);
            this.ToEmail.TabIndex = 9;
            // 
            // AddFiles_Button
            // 
            this.AddFiles_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddFiles_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFiles_Button.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFiles_Button.ForeColor = System.Drawing.Color.White;
            this.AddFiles_Button.Location = new System.Drawing.Point(77, 395);
            this.AddFiles_Button.Name = "AddFiles_Button";
            this.AddFiles_Button.Size = new System.Drawing.Size(121, 44);
            this.AddFiles_Button.TabIndex = 10;
            this.AddFiles_Button.Text = "Add files...";
            this.AddFiles_Button.UseVisualStyleBackColor = false;
            this.AddFiles_Button.Click += new System.EventHandler(this.AddFiles_Button_Click);
            // 
            // SendFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.AddFiles_Button);
            this.Controls.Add(this.ToEmail);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.body_box);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.FromEmail);
            this.Controls.Add(this.labelFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(471, 489);
            this.MinimumSize = new System.Drawing.Size(471, 489);
            this.Name = "SendFeedbackForm";
            this.Text = "Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox body_box;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ComboBox ToEmail;
        private System.Windows.Forms.Button AddFiles_Button;
    }
}