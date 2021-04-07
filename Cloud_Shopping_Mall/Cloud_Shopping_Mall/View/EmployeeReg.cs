using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloud_Shopping_Mall.View
{
    public partial class EmployeeReg : Form
    {
        public EmployeeReg()
        {
            InitializeComponent();
        }

        private void EmployeeReg_Load(object sender, EventArgs e)
        {
           // panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (addresscheck.Checked)
            {
                Peddress.Text = prAddress.Text;
                Peddress.Enabled = false;
            }
            else
            {
                Peddress.Enabled = true;
            }
        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
            if (!(confirmpass.Text.Trim()).Equals(password.Text.Trim()))
            {
                passerror.Visible = true;
            }
            else
            {
                passerror.Visible = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (!(password.Text.Trim()).Equals(confirmpass.Text.Trim()))
            {
                passerror.Visible = true;
            }
            else
            {
                passerror.Visible = false;
            }
        }
    }
}
