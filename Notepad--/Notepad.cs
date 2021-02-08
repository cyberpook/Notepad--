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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
                    sw.Write(richTextBox1.Text);
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
    }
}
