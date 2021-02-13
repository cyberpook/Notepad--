using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Notepad__.Feedback;

namespace Notepad__
{
    public partial class SendFeedbackForm : Form
    {
        public SendFeedbackForm()
        {
            InitializeComponent();
        }

        MailAddress from;
        MailAddress to;
        MailMessage message = new MailMessage();
        string filePath;

        private void AddFiles_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "All files (*.*)|*.*"
            };

            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = open.FileName;
                message.Attachments.Add(new Attachment(filePath));
            }
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            string password = "";
            DialogResult result = MessageBox.Show("To continue this operation we need your password. Procceed?" +
                "\nRemember: We DO NOT COLLECT YOUR PERSONAL DATA" +
                "\nIf you don't trust us, you send your feedback manually using this email address: maxvill2016@gmail.com",
                "password", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Password pass = new Password();
                result = pass.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        from = new MailAddress(FromEmail.Text, "From your best fan");
                        to = new MailAddress(ToEmail.Text, "To the best programmer");
                        message.To.Add(to.Address);
                        message.From = from;
                        password = pass.passwordBox.Text;
                        pass.Dispose();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Field \"To\" and \"From\" must not be emtpy");
                        return;
                    }

                    try
                    {
                        message.Body = body_box.Text;
                    }
                    catch (Exception)
                    {
                        message.Body = "";
                    }

                    message.Subject = subject.Text == "" ? "Untitled" : subject.Text;

                    var client = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(from.Address, password)
                    };

                    try
                    {
                        client.Send(message);
                    }

                    catch (Exception)
                    {
                        Error error = new Error();
                        error.ShowDialog(this);
                    }
                }
            }

        }
    }
}
