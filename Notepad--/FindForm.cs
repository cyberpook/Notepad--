using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad__
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }
            public static int pos = 0;
        public string TheValue
        {
            get { return search_field.Text; }
        }
       
        private void find_button_Click(object sender, EventArgs e)
        {
            notepadMain.request = search_field.Text;
            notepadMain.switcher = 1;
            this.Close();

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            notepadMain.switcher = -1;
            this.Close();
        }
    }
}
