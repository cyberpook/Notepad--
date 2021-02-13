

namespace Notepad__
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.instaMykha = new System.Windows.Forms.Button();
            this.instaMaksym = new System.Windows.Forms.Button();
            this.GitHub = new System.Windows.Forms.Button();
            this.follow_info = new System.Windows.Forms.Label();
            this.instaYuriy = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.about = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // instaMykha
            // 
            this.instaMykha.BackgroundImage = global::Notepad__.Properties.Resources.Instagram_icon;
            this.instaMykha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instaMykha.Location = new System.Drawing.Point(354, 200);
            this.instaMykha.Name = "instaMykha";
            this.instaMykha.Size = new System.Drawing.Size(50, 50);
            this.instaMykha.TabIndex = 0;
            this.instaMykha.UseVisualStyleBackColor = true;
            this.instaMykha.Click += new System.EventHandler(this.instaMykha_Click);
            // 
            // instaMaksym
            // 
            this.instaMaksym.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instaMaksym.Image = global::Notepad__.Properties.Resources.Instagram_icon;
            this.instaMaksym.Location = new System.Drawing.Point(450, 200);
            this.instaMaksym.Name = "instaMaksym";
            this.instaMaksym.Size = new System.Drawing.Size(50, 50);
            this.instaMaksym.TabIndex = 1;
            this.instaMaksym.UseVisualStyleBackColor = true;
            this.instaMaksym.Click += new System.EventHandler(this.instaMaksym_Click);
            // 
            // GitHub
            // 
            this.GitHub.BackColor = System.Drawing.Color.Transparent;
            this.GitHub.BackgroundImage = global::Notepad__.Properties.Resources.github_logo;
            this.GitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitHub.Location = new System.Drawing.Point(306, 200);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(50, 50);
            this.GitHub.TabIndex = 2;
            this.GitHub.UseVisualStyleBackColor = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // follow_info
            // 
            this.follow_info.AutoSize = true;
            this.follow_info.BackColor = System.Drawing.Color.Transparent;
            this.follow_info.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.follow_info.Location = new System.Drawing.Point(327, 171);
            this.follow_info.Name = "follow_info";
            this.follow_info.Size = new System.Drawing.Size(148, 26);
            this.follow_info.TabIndex = 3;
            this.follow_info.Text = "Follow us on our GitHub\nand Instagram accounts.";
            // 
            // instaYuriy
            // 
            this.instaYuriy.BackgroundImage = global::Notepad__.Properties.Resources.Instagram_icon;
            this.instaYuriy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instaYuriy.Location = new System.Drawing.Point(403, 200);
            this.instaYuriy.Name = "instaYuriy";
            this.instaYuriy.Size = new System.Drawing.Size(50, 50);
            this.instaYuriy.TabIndex = 4;
            this.instaYuriy.UseVisualStyleBackColor = true;
            this.instaYuriy.Click += new System.EventHandler(this.instaYuriy_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Notepad__.Properties.Resources.cyberpook;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(245, 245);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(254, 9);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(196, 84);
            this.about.TabIndex = 6;
            this.about.Text = "© 2020 Copyright CYBERPOOK\nDevelopers:\nVovkanych Mykhailo\nPavliv Maksym\nDesigner:" +
    "\nYuri Vovkanych\n";
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Notepad__.Properties.Resources.AboutUs_background;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.about);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.instaYuriy);
            this.Controls.Add(this.follow_info);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.instaMaksym);
            this.Controls.Add(this.instaMykha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(516, 289);
            this.MinimumSize = new System.Drawing.Size(516, 289);
            this.Name = "AboutUsForm";
            this.Text = "About Us";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button instaMykha;
        private System.Windows.Forms.Button instaMaksym;
        private System.Windows.Forms.Button GitHub;
        private System.Windows.Forms.Label follow_info;
        private System.Windows.Forms.Button instaYuriy;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label about;
    }
}