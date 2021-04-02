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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lgn_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }
    }
}
