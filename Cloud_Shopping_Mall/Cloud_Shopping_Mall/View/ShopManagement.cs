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
    public partial class ShopManagement : Form
    {
        public ShopManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ShopReg().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Remove_Shop().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ShopList().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new updateShop().Show();
        }
    }
}
