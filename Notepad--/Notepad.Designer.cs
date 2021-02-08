
namespace Notepad__
{
    partial class notepadMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notepadMain));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.File_NewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.File_NewWindowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.File_PageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ScaleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.largerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 274);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton,
            this.EditButton,
            this.toolStripDropDownButton1,
            this.viewButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileButton
            // 
            this.FileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_NewButton,
            this.File_NewWindowButton,
            this.File_Open,
            this.File_Save,
            this.File_SaveAs,
            this.FileSeparator1,
            this.File_PageSetup,
            this.File_Print,
            this.FileSeparator2,
            this.File_Exit});
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(38, 22);
            this.FileButton.Text = "File";
            // 
            // File_NewButton
            // 
            this.File_NewButton.Name = "File_NewButton";
            this.File_NewButton.Size = new System.Drawing.Size(309, 22);
            this.File_NewButton.Text = "New                                                Ctrl+N";
            this.File_NewButton.Click += new System.EventHandler(this.File_NewFile_Click);
            // 
            // File_NewWindowButton
            // 
            this.File_NewWindowButton.Name = "File_NewWindowButton";
            this.File_NewWindowButton.Size = new System.Drawing.Size(309, 22);
            this.File_NewWindowButton.Text = "New Window                                Ctrl+Shift+N";
            this.File_NewWindowButton.Click += new System.EventHandler(this.File_NewWindow_Click);
            // 
            // File_Open
            // 
            this.File_Open.Name = "File_Open";
            this.File_Open.Size = new System.Drawing.Size(309, 22);
            this.File_Open.Text = "Open...                                           Ctrl+O";
            this.File_Open.Click += new System.EventHandler(this.File_Open_Click);
            // 
            // File_Save
            // 
            this.File_Save.Name = "File_Save";
            this.File_Save.Size = new System.Drawing.Size(309, 22);
            this.File_Save.Text = "Save                                                Ctrl+S";
            this.File_Save.Click += new System.EventHandler(this.File_Save_Click);
            // 
            // File_SaveAs
            // 
            this.File_SaveAs.Name = "File_SaveAs";
            this.File_SaveAs.Size = new System.Drawing.Size(309, 22);
            this.File_SaveAs.Text = "Save as...                                        Ctrl+Shift+S";
            this.File_SaveAs.Click += new System.EventHandler(this.File_SaveAs_Click);
            // 
            // FileSeparator1
            // 
            this.FileSeparator1.Name = "FileSeparator1";
            this.FileSeparator1.Size = new System.Drawing.Size(306, 6);
            // 
            // File_PageSetup
            // 
            this.File_PageSetup.Name = "File_PageSetup";
            this.File_PageSetup.Size = new System.Drawing.Size(309, 22);
            this.File_PageSetup.Text = "Page Setup";
            this.File_PageSetup.Click += new System.EventHandler(this.File_Page_Setup_Click);
            // 
            // File_Print
            // 
            this.File_Print.Name = "File_Print";
            this.File_Print.Size = new System.Drawing.Size(309, 22);
            this.File_Print.Text = "Print...                                            Ctrl+P";
            this.File_Print.Click += new System.EventHandler(this.File_Print_Click);
            // 
            // FileSeparator2
            // 
            this.FileSeparator2.Name = "FileSeparator2";
            this.FileSeparator2.Size = new System.Drawing.Size(306, 6);
            // 
            // File_Exit
            // 
            this.File_Exit.Name = "File_Exit";
            this.File_Exit.Size = new System.Drawing.Size(309, 22);
            this.File_Exit.Text = "Exit";
            this.File_Exit.Click += new System.EventHandler(this.File_Exit_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(40, 22);
            this.EditButton.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripDropDownButton1.Text = "Format";
            // 
            // viewButton
            // 
            this.viewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScaleButton});
            this.viewButton.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.Image")));
            this.viewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(45, 22);
            this.viewButton.Text = "View";
            // 
            // ScaleButton
            // 
            this.ScaleButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largerToolStripMenuItem,
            this.smallerToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(101, 22);
            this.ScaleButton.Text = "Scale";
            // 
            // largerToolStripMenuItem
            // 
            this.largerToolStripMenuItem.Name = "largerToolStripMenuItem";
            this.largerToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.largerToolStripMenuItem.Text = "Larger";
            // 
            // smallerToolStripMenuItem
            // 
            this.smallerToolStripMenuItem.Name = "smallerToolStripMenuItem";
            this.smallerToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.smallerToolStripMenuItem.Text = "Smaller";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // notepadMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 305);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "notepadMain";
            this.Text = "Notepad--";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripMenuItem File_Open;
        private System.Windows.Forms.ToolStripMenuItem File_Save;
        private System.Windows.Forms.ToolStripMenuItem File_NewButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton EditButton;
        private System.Windows.Forms.ToolStripDropDownButton viewButton;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScaleButton;
        private System.Windows.Forms.ToolStripMenuItem largerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_NewWindowButton;
        private System.Windows.Forms.ToolStripMenuItem File_SaveAs;
        private System.Windows.Forms.ToolStripSeparator FileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem File_PageSetup;
        private System.Windows.Forms.ToolStripMenuItem File_Print;
        private System.Windows.Forms.ToolStripSeparator FileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem File_Exit;
    }
}

