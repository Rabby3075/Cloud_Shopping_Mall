namespace Cloud_Shopping_Mall.View
{
    partial class ForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.RadioButton();
            this.employee = new System.Windows.Forms.RadioButton();
            this.customer = new System.Windows.Forms.RadioButton();
            this.loginpage = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginpage);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.passwordtext);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 353);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email or User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(213, 106);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(213, 22);
            this.user.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.OrangeRed;
            this.password.Location = new System.Drawing.Point(31, 231);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(91, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Visible = false;
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.Enabled = false;
            this.passwordtext.Location = new System.Drawing.Point(213, 229);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(213, 22);
            this.passwordtext.TabIndex = 3;
            this.passwordtext.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(115, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.OrangeRed;
            this.admin.Location = new System.Drawing.Point(35, 56);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(70, 22);
            this.admin.TabIndex = 5;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.BackColor = System.Drawing.Color.Transparent;
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.OrangeRed;
            this.employee.Location = new System.Drawing.Point(149, 56);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(95, 22);
            this.employee.TabIndex = 6;
            this.employee.TabStop = true;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = false;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.OrangeRed;
            this.customer.Location = new System.Drawing.Point(307, 56);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(95, 22);
            this.customer.TabIndex = 7;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = false;
            // 
            // loginpage
            // 
            this.loginpage.ActiveLinkColor = System.Drawing.Color.Blue;
            this.loginpage.AutoSize = true;
            this.loginpage.BackColor = System.Drawing.Color.Transparent;
            this.loginpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpage.LinkColor = System.Drawing.Color.OrangeRed;
            this.loginpage.Location = new System.Drawing.Point(133, 285);
            this.loginpage.Name = "loginpage";
            this.loginpage.Size = new System.Drawing.Size(175, 17);
            this.loginpage.TabIndex = 8;
            this.loginpage.TabStop = true;
            this.loginpage.Text = "Go Back to Login Page";
            this.loginpage.Visible = false;
            this.loginpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginpage_LinkClicked);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel loginpage;
        private System.Windows.Forms.RadioButton customer;
        private System.Windows.Forms.RadioButton employee;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox user;
    }
}