using Cloud_Shopping_Mall.Controller;
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
    public partial class ShopList : Form
    {
        public ShopList()
        {
            InitializeComponent();
            var result = ShopController.GetAllShop();
            dataGridView1.DataSource = result; 
        }

        private void ShopList_Load(object sender, EventArgs e)
        {
            
        }
    }
}
