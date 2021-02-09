using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__
{
    public partial class notepadMain : Form
    {

        private string working_directory = "c:\\";
        private string file_name = "Untitled";

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
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = working_directory;
            openFile.Filter = "txt files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                mainBox.Text = File.ReadAllText(openFile.FileName);
                working_directory = openFile.FileName;
                file_name = Path.GetFileName(openFile.FileName);
                this.Text = Path.GetFileName(openFile.FileName) + " - " + "Notepad--";
            }
        }

        private void mainBox_TextChanged(object sender, EventArgs e)
        {
            if(!this.Text.Contains("*"))
                this.Text = "*" + this.Text;
        }
        private void File_NewWindow_Click(object sender, EventArgs e)
        {
            var thread = new Thread(ThreadStart);

            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private static void ThreadStart()
        {
            Application.Run(new notepadMain()); // <-- other form started on its own UI thread
        }

        private void File_Page_Setup_Click(object sender, EventArgs e)
        {

        }

        private void File_New_Click(object sender, EventArgs e)
        {
            if (mainBox.Text != "" && this.Text.Contains("*"))
            {
                string message = $"Do you want to save changes to {file_name}?";
                string caption = "Notepad--";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                switch(result)
                {
                    case DialogResult.Yes:
                        File_Save_Click(sender, e);
                        break;
                    case DialogResult.No:
                        working_directory = "c:\\";
                        file_name = "Untitled";
                        this.Text = "Untitled - Notepad--";
                        mainBox.Text = "";
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void File_Save_Click(object sender, EventArgs e)
        {
            if(working_directory == "c:\\")
            {
                File_SaveAs_Click(sender, e);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            using (Stream stream = File.Open(working_directory, FileMode.Truncate))
            using (StreamWriter stream_writer = new StreamWriter(stream))
            {
                stream_writer.Write(mainBox.Text);
            };
        }

        private void File_SaveAs_Click(object sender, EventArgs e)
        {

  
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = Path.GetDirectoryName(working_directory);
            saveFile.FileName = Path.GetFileName(working_directory);

            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";



            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(saveFile.FileName))
                {
                    using (Stream stream = File.Open(saveFile.InitialDirectory + saveFile.FileName, FileMode.CreateNew))
                    using (StreamWriter stream_writer = new StreamWriter(stream))
                    {
                        stream_writer.Write(mainBox.Text);
                    };
                    working_directory = saveFile.FileName;
                    this.Text = Path.GetFileName(saveFile.FileName) + " - " + "Notepad--";
                    file_name = Path.GetFileName(saveFile.FileName);
                }
                else
                {
                    using (Stream stream = File.Open(saveFile.FileName, FileMode.Truncate))
                    using (StreamWriter stream_writer = new StreamWriter(stream))
                    {
                        stream_writer.Write(mainBox.Text);
                    };
                    working_directory = saveFile.FileName;
                    this.Text = Path.GetFileName(saveFile.FileName) + " - " + "Notepad--";
                    file_name = Path.GetFileName(saveFile.FileName);
                }
            }

            
        }

        private void File_Print_Click(object sender, EventArgs e)
        {

        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            if (mainBox.Text != "" && this.Text.Contains("*"))
            {
                string message = $"Do you want to save changes to {file_name}?";
                string caption = "Notepad--";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                switch (result)
                {
                    case DialogResult.Yes:
                        File_Save_Click(sender, e);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
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

        private void notepadMain_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled - Notepad--";
        }

        
        public void notepadMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall) { return; }
            e.Cancel = true;
            if (mainBox.Text != "" && this.Text.Contains("*"))
            {
                string message = $"Do you want to save changes to {file_name}?";
                string caption = "Notepad--";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                switch (result)
                {
                    case DialogResult.Yes:
                        File_Save_Click(sender, e);

                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            e.Cancel = false;
        }

        
    }
}
