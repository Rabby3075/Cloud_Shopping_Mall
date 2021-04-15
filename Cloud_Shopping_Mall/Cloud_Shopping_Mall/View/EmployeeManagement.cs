﻿using System;
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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmployeeReg().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new removeEmployee().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new EmployeeList().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
