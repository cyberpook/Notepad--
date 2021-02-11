
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
            this.mainBox = new System.Windows.Forms.RichTextBox();
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
            this.Edit_UndoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_CutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_CopyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_PasteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_DeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_FindButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_SelectAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_TimeDateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Format_WordWrapButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Format_FontButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ScaleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.largerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_StatusBar_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Status_ScaleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.setup = new System.Windows.Forms.PageSetupDialog();
            this.DocToPrint = new System.Drawing.Printing.PrintDocument();
            this.print = new System.Windows.Forms.PrintDialog();
            this.toolStrip1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainBox.Font = new System.Drawing.Font("Consolas", 11F);
            this.mainBox.Location = new System.Drawing.Point(12, 28);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(797, 252);
            this.mainBox.TabIndex = 0;
            this.mainBox.Text = "";
            this.mainBox.TextChanged += new System.EventHandler(this.mainBox_TextChanged);
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
            this.File_NewButton.Click += new System.EventHandler(this.File_New_Click);
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
            this.Edit_UndoButton,
            this.toolStripSeparator1,
            this.Edit_CutButton,
            this.Edit_CopyButton,
            this.Edit_PasteButton,
            this.Edit_DeleteButton,
            this.toolStripSeparator2,
            this.Edit_FindButton,
            this.toolStripSeparator3,
            this.Edit_SelectAllButton,
            this.Edit_TimeDateButton});
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(40, 22);
            this.EditButton.Text = "Edit";
            // 
            // Edit_UndoButton
            // 
            this.Edit_UndoButton.Name = "Edit_UndoButton";
            this.Edit_UndoButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_UndoButton.Text = "Undo                                 Ctrl+Z";
            this.Edit_UndoButton.Click += new System.EventHandler(this.Edit_Undo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // Edit_CutButton
            // 
            this.Edit_CutButton.Name = "Edit_CutButton";
            this.Edit_CutButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_CutButton.Text = "Cut                                    Ctrl+X";
            this.Edit_CutButton.Click += new System.EventHandler(this.Edit_CutButton_Click);
            // 
            // Edit_CopyButton
            // 
            this.Edit_CopyButton.Name = "Edit_CopyButton";
            this.Edit_CopyButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_CopyButton.Text = "Copy                                 Ctrl+C";
            this.Edit_CopyButton.Click += new System.EventHandler(this.Edit_CopyButton_Click);
            // 
            // Edit_PasteButton
            // 
            this.Edit_PasteButton.Name = "Edit_PasteButton";
            this.Edit_PasteButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_PasteButton.Text = "Paste                                 Ctrl+V";
            this.Edit_PasteButton.Click += new System.EventHandler(this.Edit_PasteButton_Click);
            // 
            // Edit_DeleteButton
            // 
            this.Edit_DeleteButton.Name = "Edit_DeleteButton";
            this.Edit_DeleteButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_DeleteButton.Text = "Delete                               Del";
            this.Edit_DeleteButton.Click += new System.EventHandler(this.Edit_DeleteButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // Edit_FindButton
            // 
            this.Edit_FindButton.Name = "Edit_FindButton";
            this.Edit_FindButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_FindButton.Text = "Find (under development)";
            this.Edit_FindButton.Click += new System.EventHandler(this.Edit_FindButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // Edit_SelectAllButton
            // 
            this.Edit_SelectAllButton.Name = "Edit_SelectAllButton";
            this.Edit_SelectAllButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_SelectAllButton.Text = "Select All                          Ctrl+A";
            this.Edit_SelectAllButton.Click += new System.EventHandler(this.Edit_SelectAllButton_Click);
            // 
            // Edit_TimeDateButton
            // 
            this.Edit_TimeDateButton.Name = "Edit_TimeDateButton";
            this.Edit_TimeDateButton.Size = new System.Drawing.Size(236, 22);
            this.Edit_TimeDateButton.Text = "Time\\Date                        F5";
            this.Edit_TimeDateButton.Click += new System.EventHandler(this.Edit_TimeDateButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Format_WordWrapButton,
            this.Format_FontButton});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripDropDownButton1.Text = "Format";
            // 
            // Format_WordWrapButton
            // 
            this.Format_WordWrapButton.Checked = true;
            this.Format_WordWrapButton.CheckOnClick = true;
            this.Format_WordWrapButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Format_WordWrapButton.Name = "Format_WordWrapButton";
            this.Format_WordWrapButton.Size = new System.Drawing.Size(134, 22);
            this.Format_WordWrapButton.Text = "Word Wrap";
            this.Format_WordWrapButton.Click += new System.EventHandler(this.Format_WordWrap_Click);
            // 
            // Format_FontButton
            // 
            this.Format_FontButton.Name = "Format_FontButton";
            this.Format_FontButton.Size = new System.Drawing.Size(134, 22);
            this.Format_FontButton.Text = "Font";
            this.Format_FontButton.Click += new System.EventHandler(this.Format_FontButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScaleButton,
            this.View_StatusBar_Button});
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
            this.ScaleButton.Size = new System.Drawing.Size(126, 22);
            this.ScaleButton.Text = "Scale";
            // 
            // largerToolStripMenuItem
            // 
            this.largerToolStripMenuItem.Name = "largerToolStripMenuItem";
            this.largerToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.largerToolStripMenuItem.Text = "Larger          Ctrl+Add(+)";
            this.largerToolStripMenuItem.Click += new System.EventHandler(this.largerToolStripMenuItem_Click);
            // 
            // smallerToolStripMenuItem
            // 
            this.smallerToolStripMenuItem.Name = "smallerToolStripMenuItem";
            this.smallerToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.smallerToolStripMenuItem.Text = "Smaller        Ctrl+Subtract(-)";
            this.smallerToolStripMenuItem.Click += new System.EventHandler(this.smallerToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.defaultToolStripMenuItem.Text = "Default         Ctrl+0";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // View_StatusBar_Button
            // 
            this.View_StatusBar_Button.Checked = true;
            this.View_StatusBar_Button.CheckOnClick = true;
            this.View_StatusBar_Button.CheckState = System.Windows.Forms.CheckState.Checked;
            this.View_StatusBar_Button.Name = "View_StatusBar_Button";
            this.View_StatusBar_Button.Size = new System.Drawing.Size(126, 22);
            this.View_StatusBar_Button.Text = "Status Bar";
            this.View_StatusBar_Button.Click += new System.EventHandler(this.View_StatusBar_Button_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_ScaleLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 283);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(821, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            // 
            // Status_ScaleLabel
            // 
            this.Status_ScaleLabel.Name = "Status_ScaleLabel";
            this.Status_ScaleLabel.Size = new System.Drawing.Size(35, 17);
            this.Status_ScaleLabel.Text = "100%";
            this.Status_ScaleLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // setup
            // 
            this.setup.MinMargins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            // 
            // DocToPrint
            // 
            this.DocToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PRINTING);
            // 
            // print
            // 
            this.print.AllowCurrentPage = true;
            this.print.AllowSelection = true;
            this.print.AllowSomePages = true;
            this.print.Document = this.DocToPrint;
            this.print.UseEXDialog = true;
            // 
            // notepadMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 305);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "notepadMain";
            this.Text = "Notepad--";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.notepadMain_FormClosing);
            this.Load += new System.EventHandler(this.notepadMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripMenuItem File_Open;
        private System.Windows.Forms.ToolStripMenuItem File_Save;
        private System.Windows.Forms.ToolStripMenuItem File_NewButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton EditButton;
        private System.Windows.Forms.ToolStripDropDownButton viewButton;
        private System.Windows.Forms.ToolStripMenuItem Edit_UndoButton;
        private System.Windows.Forms.ToolStripMenuItem Edit_CopyButton;
        private System.Windows.Forms.ToolStripMenuItem Edit_CutButton;
        private System.Windows.Forms.ToolStripMenuItem Edit_PasteButton;
        private System.Windows.Forms.ToolStripMenuItem Edit_DeleteButton;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Edit_SelectAllButton;
        private System.Windows.Forms.ToolStripMenuItem Edit_TimeDateButton;
        private System.Windows.Forms.ToolStripMenuItem Edit_FindButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Format_WordWrapButton;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel Status_ScaleLabel;
        private System.Windows.Forms.ToolStripMenuItem View_StatusBar_Button;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem Format_FontButton;
        private System.Windows.Forms.PageSetupDialog setup;
        private System.Drawing.Printing.PrintDocument DocToPrint;
        private System.Windows.Forms.PrintDialog print;
    }
}

