using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__.Feedback
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void less_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;
            Process.Start("https://myaccount.google.com/lesssecureapps?pli=1&rapt=AEjHL4Pu4uX3ld9jRI8nUlCTVpvrjC8h_JqwYIaj8kEzFiTzEpj9jqs9e8VSSp5SCv-RxgtjnGW6YWozioLALFYtAVGC-_cp3A");
        }

        private void gmail_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;
            Process.Start("https://www.gmail.com/");
			//nareshti ya kurcha zakinchuv ty sraky
        }
    }
}
