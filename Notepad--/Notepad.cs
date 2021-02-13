using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

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
            mainBox.Undo();
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

        private object[] settings = new object[]
            {
                new Margins(100, 100, 100, 100),
                new PaperSize("A4", 1169, 827),
                false,
                "Microsoft Print to PDF",
                PrintRange.AllPages
            };
        private void File_Page_Setup_Click(object sender, EventArgs e)
        {
            setup.PageSettings = new PageSettings();
            setup.PrinterSettings = new PrinterSettings();

            DialogResult result = setup.ShowDialog();
            if (result == DialogResult.OK)
            {
                settings = new object[]{
                    setup.PageSettings.Margins,
                    setup.PageSettings.PaperSize,
                    setup.PageSettings.Landscape,
                    setup.PrinterSettings.PrinterName,
                    setup.PrinterSettings.PrintRange
                };
            }
        }

        private string[] getLines(RichTextBox box)
        {
            string[] lines = new string[1];
            lines[0] = "";

            float maxLength = 74;
            int count = 0;
            string curW = "";

            foreach(char curS in box.Text)
            {
                if (curS == ' ')
                {
                    if(lines[count].Length + curW.Length >= maxLength)
                    {
                        Array.Resize(ref lines, lines.Length + 1);
                        count++;
                        lines[count] = curW;
                        curW = " ";
                    }
                    else
                    {
                        lines[count] += curW + " ";
                        curW = "";
                    }
                }
                else if (curS == '\n')
                {
                    if (!(lines[count].Length + curW.Length >= maxLength))
                    {
                        lines[count] += curW;
                        curW = "";
                        Array.Resize(ref lines, lines.Length + 1);
                        count++;
                        lines[count] = "\n";
                    }
                    else
                    {
                        Array.Resize(ref lines, lines.Length + 2);
                        count += 2;
                        lines[count - 1] = curW;
                        lines[count] = "\n";
                        curW = "";
                    }
                    
                }
                else
                {
                    curW += curS.ToString();
                }
            }

            if (lines[count].Length + curW.Length >= maxLength)
            {
                Array.Resize(ref lines, lines.Length + 1);
                count++;
                lines[count] = curW;
            }
            else
            {
                lines[count] += curW;
            }

            return lines;


        }
        int cur = 0;
        

        private void PRINTING(object sender, PrintPageEventArgs e)
        {

            float linesPerPage = 0;
            int count = 0;
            float yPosition = 0;
            string[] lines = getLines(mainBox);
            Font fontToPrint = new Font("Consolas", 11, FontStyle.Regular);

            linesPerPage = e.MarginBounds.Height / mainBox.Font.GetHeight(e.Graphics);
            
            while (count < linesPerPage && (lines.Length > cur))
            {

                yPosition = e.MarginBounds.Left + (count * fontToPrint.GetHeight(e.Graphics));
                if (yPosition > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                e.Graphics.DrawString(lines[cur], fontToPrint, Brushes.Black, e.MarginBounds.Left, yPosition);
                if (lines[cur] != null && (lines[cur].Substring(0, 1) == "\n"))
                {
                    count++;
                    yPosition = e.MarginBounds.Left + (count * fontToPrint.GetHeight(e.Graphics));
                    
                }
                cur++;
                count++;
            }

            if (lines.Length > cur)
            {
                e.HasMorePages = true;
                return;
            }
            else
                e.HasMorePages = false;

        }
        private void File_Print_Click(object sender, EventArgs e)
        {
            DocToPrint.DefaultPageSettings.Margins = (Margins)settings[0];
            DocToPrint.DefaultPageSettings.PaperSize = (PaperSize)settings[1];
            DocToPrint.DefaultPageSettings.Landscape = (bool)settings[2];
            DocToPrint.PrinterSettings.PrinterName = (string)settings[3];
            DocToPrint.PrinterSettings.PrintRange = (PrintRange)settings[4];
            DocToPrint.PrintPage += new PrintPageEventHandler(PRINTING);
            if (print.ShowDialog() == DialogResult.OK)
            {
                if(mainBox.Text == "")
                {
                    MessageBox.Show("The text is empty. Stopping printing...");
                    return;
                }
                DocToPrint.Print();
                cur = 0;

            }
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
                        return;
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

        private void SearchWord(string editor_text, string request)
        {
            var selectionIndex = editor_text.IndexOf(request, StringComparison.CurrentCultureIgnoreCase);
            if(selectionIndex == -1 )
            {
                MessageBox.Show($"There is no '{request}' in this text", "Search result");
                return;
            }
            if (request == "")
            {
                MessageBox.Show($"Please, enter your word in the field", "Search result");
                return;
            }
            Status_CurrentWord.Text = $" Current word to find: {request}";
            mainBox.SelectionStart = selectionIndex;
            mainBox.SelectionLength = request.Length;
            
        }

        public static string request = "";
        public static string curr_word = request;//unnecessary now
        public static int switcher = 0;

        private void Edit_FindButton_Click(object sender, EventArgs e)//luta dich, grebu iak vorkae
        {
            using (FindForm find_form = new FindForm())
            {
                if (find_form.ShowDialog() == DialogResult.OK)
                {
                    request = find_form.TheValue;
                }

            }
            switch (switcher) 
            {
                case 1:     SearchWord(mainBox.Text, request); break;
                case -1:    break;
            }
        }

        private void largerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            mainBox.ZoomFactor += (float)0.1;
            Status_ScaleLabel.Text = $"{(int)(mainBox.ZoomFactor * 10) * 10}%" ;
        }

        private void smallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if( mainBox.ZoomFactor - 0.1 < 0.1 ) { return; }
            mainBox.ZoomFactor -= (float)0.1;
            Status_ScaleLabel.Text = $"{(int)(mainBox.ZoomFactor * 10) * 10}%";
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainBox.ZoomFactor = 1.0F;
            Status_ScaleLabel.Text = $"{(int)(mainBox.ZoomFactor * 10) * 10}%";
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F5:                               Edit_TimeDateButton_Click(mainBox, null); return true;
                case (Keys.Control | Keys.Add):             largerToolStripMenuItem_Click(mainBox, null); return true;
                case (Keys.Control | Keys.Subtract):        smallerToolStripMenuItem_Click(mainBox, null); return true;
                case (Keys.Control | Keys.D0):              defaultToolStripMenuItem_Click(mainBox, null); return true;
                case (Keys.Control | Keys.N):               File_New_Click(mainBox, null); return true;
                case (Keys.Control | Keys.Shift | Keys.N):  File_NewWindow_Click(mainBox, null); return true;
                case (Keys.Control | Keys.O):               File_Open_Click(mainBox, null); return true;
                case (Keys.Control | Keys.S):               File_Save_Click(mainBox, null); return true;
                case (Keys.Control | Keys.Shift | Keys.S):  File_SaveAs_Click(mainBox, null); return true;
                case (Keys.Control | Keys.P):               File_Print_Click(mainBox, null); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void View_StatusBar_Button_Click(object sender, EventArgs e)
        {
            switch (View_StatusBar_Button.Checked)
            {
                case true:  StatusBar.Visible = true; mainBox.Height -= 13; break;
                case false: StatusBar.Visible = false; mainBox.Height += 13 ; break;
            }
        }

        private void Format_FontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = mainBox.Font;
            fontDialog1.Color = mainBox.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                mainBox.Font = fontDialog1.Font;
                mainBox.ForeColor = fontDialog1.Color;
            }
        }


        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)//unnecessary now
        {
            
        }

        private void Help_AboutUs_Click(object sender, EventArgs e)
        {
            var thread = new Thread(NewThread);

            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private static void NewThread()
        {
            Application.Run(new AboutUsForm());
        }

        private void Help_ViewHelp_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/cyberpook/Notepad--/blob/Dev_Environment/README.md");
        }

        private void Help_SendFeedback_Click(object sender, EventArgs e)
        {

            SendFeedbackForm feedbackForm = new SendFeedbackForm();
            feedbackForm.ShowDialog(this);
        }
    }
}
