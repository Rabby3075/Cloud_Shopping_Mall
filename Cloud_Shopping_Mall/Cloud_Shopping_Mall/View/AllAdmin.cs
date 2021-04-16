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
    public partial class AllAdmin : Form
    {
        public AllAdmin()
        {
            InitializeComponent();
            var result = AdminController.GetAllAdmin();
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
