using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad__.Feedback;

namespace Notepad__.Feedback
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
