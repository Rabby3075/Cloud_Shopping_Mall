﻿using Cloud_Shopping_Mall.Controller;
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
    public partial class AdminRegistation : Form
    {
        public AdminRegistation()
        {
            InitializeComponent();
        }

        private void AdminRegistation_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(address.Text) || string.IsNullOrEmpty(mobile.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || gender.SelectedItem == null)
            {
                
               
                if (string.IsNullOrEmpty(name.Text))
                {
                    nameallert.Visible = true;
                }
                else
                {
                    nameallert.Visible = false;
                }
                if (string.IsNullOrEmpty(address.Text))
                {
                    addressallert.Visible = true;
                }
                else
                {
                    addressallert.Visible = false;
                }
                if (string.IsNullOrEmpty(mobile.Text))
                {
                    mobileallert.Visible = true;
                }
                else
                {
                    mobileallert.Visible = false;
                }
                if (string.IsNullOrEmpty(email.Text))
                {
                    emailallert.Visible = true;
                }
                else
                {
                    emailallert.Visible = false;
                }
                if (string.IsNullOrEmpty(password.Text))
                {
                    passwordallert.Visible = true;
                }
                else
                {
                   passwordallert.Visible = false;
                }
                if (gender.SelectedItem == null)
                {
                    genderallert.Visible = true;
                }
                else
                {
                    genderallert.Visible = false;
                }
                MessageBox.Show("Please enter your Information", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (mobile.Text.Length != 11)
            {
                mobileallert.Visible = true;
                MessageBox.Show("Please enter your 11 digit mobile no", "Invalid Mobile No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (password.Text.Length < 6)
            {
                passwordallert.Visible = true;
                MessageBox.Show("Please enter atleast 6 digit password", "Invalid Mobile No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            
            
            else
            {
                var admin = new
                {
                    Name = name.Text.Trim(),
                    PresentAddress = address.Text.Trim(),
                    MobileNo =Convert.ToInt32(mobile.Text),
                    Gender = gender.SelectedItem.ToString().Trim(),

                    Email = email.Text.Trim(),
                    Password = password.Text.Trim()

                };
                var result = AdminController.AddAdmin(admin);
                if (result)
                {
                    MessageBox.Show("Admin Registration done", "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
               
            }
           
        }
    }
}