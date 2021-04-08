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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = user.Text;
            if (string.IsNullOrEmpty(User))
            {
                MessageBox.Show("Please enter your Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (admin.Checked == false && employee.Checked == false && customer.Checked == false)
            {
                MessageBox.Show("Please select a category", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (admin.Checked==true)
                {
                    dynamic adminResult = AdminController.GetAdmin(User);
                    if (adminResult != null)
                    {
                        password.Visible = true;
                        passwordtext.Visible = true;
                        loginpage.Visible = true;
                        passwordtext.Text = adminResult.Password;
                    }
                    else
                    {
                        MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (employee.Checked == true)
                {
                    dynamic EmployeeResult = EmployeeController.ForgetEmployee(User,User);
                    if (EmployeeResult != null)
                    {
                        password.Visible = true;
                        passwordtext.Visible = true;
                        loginpage.Visible = true;
                        passwordtext.Text = EmployeeResult.Password;
                    }
                    else
                    {
                        MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (customer.Checked == true)
                {
                    dynamic customerResult = CustomerController.ForgetCustomer(User,User);
                    if (customerResult != null)
                    {
                        password.Visible = true;
                        passwordtext.Visible = true;
                        loginpage.Visible = true;
                        passwordtext.Text = customerResult.Password;
                    }
                    else
                    {
                        MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void loginpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginPage().Show();
        }
    }
}
