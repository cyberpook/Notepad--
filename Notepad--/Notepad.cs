using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__
{
    public partial class notepadMain : Form
    {
        public notepadMain()
        {
            InitializeComponent();
        }

        private void Edit_Undo_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(z)");
        }

        private void File_Open_Click(object sender, EventArgs e)
        {
            
        }

        private void File_NewWindow_Click(object sender, EventArgs e)
        {

        }

        private void File_Page_Setup_Click(object sender, EventArgs e)
        {

        }

        private void File_NewFile_Click(object sender, EventArgs e)
        {

        }

        private void File_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "txt files (*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFile.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(mainBox.Text);
                };
            }
        }

        private void File_SaveAs_Click(object sender, EventArgs e)
        {

        }

        private void File_Print_Click(object sender, EventArgs e)
        {

        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Edit_CopyButton_Click(object sender, EventArgs e)
        {
            mainBox.Copy();
        }

        private void Edit_PasteButton_Click(object sender, EventArgs e)
        {
            mainBox.Paste();
        }

        private void Edit_CutButton_Click(object sender, EventArgs e)
        {
            mainBox.Cut();
            
        }

        private void Edit_DeleteButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        private void Edit_SelectAllButton_Click(object sender, EventArgs e)
        {
            mainBox.SelectAll();
        }

        private void Edit_TimeDateButton_Click(object sender, EventArgs e)
        {
            string date_time = Convert.ToString(System.DateTime.Now);
            var selectionIndex = mainBox.SelectionStart;
            mainBox.Text = mainBox.Text.Insert(selectionIndex, date_time);
            mainBox.SelectionStart = selectionIndex + date_time.Length;
        }

        private void Edit_FindButton_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.ShowDialog(this);
        }

        private void largerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainBox.Font= new System.Drawing.Font(mainBox.Font.FontFamily.Name, mainBox.Font.Size + 2);
        }

        private void smallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainBox.Font = new System.Drawing.Font(mainBox.Font.FontFamily.Name, mainBox.Font.Size - 2);
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainBox.Font = new System.Drawing.Font(mainBox.Font.FontFamily.Name, 12);
        }

        private void Format_WordWrap_Click(object sender, EventArgs e)
        {
            if(Format_WordWrapButton.Checked == true)
            {
                mainBox.WordWrap = true;
            }
            else
            {
                mainBox.WordWrap = false;
            }
        }
    }
}
