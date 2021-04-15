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
    public partial class updateShop : Form
    {
        public updateShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            if (string.IsNullOrEmpty(id.Text))
            {
                MessageBox.Show("Please enter information", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Id = Convert.ToInt32(id.Text);
                    var result = ShopController.GetShop(Id);
                    if (result!=null)
                    {
                        panel1.Visible = true;
                        name.Text = String.Format(result.Name);
                        location.Text = String.Format(result.Location);
                    }
                    else
                    {
                        MessageBox.Show("No shop found", "Food Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please use numeric number in Shop id", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void edit(object sender, EventArgs e)
        {
            name.Enabled = true;
            location.Enabled = true;
        }

        private void update(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text.Trim()) || string.IsNullOrEmpty(name.Text.Trim()) || string.IsNullOrEmpty(location.Text.Trim()))
            {
                MessageBox.Show("Please enter information", "Restaurant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var shop = new
                {
                    Id = Convert.ToInt32(id.Text),
                    Name = name.Text.Trim(),
                    Location = location.Text.Trim()
                };
                var result = ShopController.UpdateRestaurant(shop);
                if (result)
                {
                    MessageBox.Show("Shop Updated", "Shop Registration", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MessageBox.Show("Shop cant added", "shop Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
