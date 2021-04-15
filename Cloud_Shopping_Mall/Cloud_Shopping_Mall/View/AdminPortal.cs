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
    public partial class AdminPortal : Form
    {
        public AdminPortal() {
            InitializeComponent();
        }
        public AdminPortal(string name)
        {
            InitializeComponent();
            string output = String.Format("Welcome {0}",name);
            welcomeName.Text = output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmployeeManagement().Show();
        }

        private void ShopManagement(object sender, EventArgs e)
        {
            new ShopManagement().Show();
        }
    }
}
