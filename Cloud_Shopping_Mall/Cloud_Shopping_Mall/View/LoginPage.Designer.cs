namespace Cloud_Shopping_Mall.View
{
    partial class LoginPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.RadioButton();
            this.employee = new System.Windows.Forms.RadioButton();
            this.customer = new System.Windows.Forms.RadioButton();
            this.forget = new System.Windows.Forms.LinkLabel();
            this.emailallert = new System.Windows.Forms.PictureBox();
            this.passwordallert = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailallert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordallert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.passwordallert);
            this.panel1.Controls.Add(this.emailallert);
            this.panel1.Controls.Add(this.forget);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(226, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 315);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(92, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(25, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(133, 165);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(184, 22);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(133, 123);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(184, 22);
            this.email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(100, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.admin.Location = new System.Drawing.Point(25, 74);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(73, 21);
            this.admin.TabIndex = 11;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.BackColor = System.Drawing.Color.Transparent;
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.employee.Location = new System.Drawing.Point(115, 74);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(99, 21);
            this.employee.TabIndex = 12;
            this.employee.TabStop = true;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = false;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.customer.Location = new System.Drawing.Point(220, 74);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(97, 21);
            this.customer.TabIndex = 13;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = false;
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.BackColor = System.Drawing.Color.Transparent;
            this.forget.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.forget.Location = new System.Drawing.Point(112, 276);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(114, 17);
            this.forget.TabIndex = 14;
            this.forget.TabStop = true;
            this.forget.Text = "Forget Password";
            // 
            // emailallert
            // 
            this.emailallert.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.cancel;
            this.emailallert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emailallert.Location = new System.Drawing.Point(285, 123);
            this.emailallert.Name = "emailallert";
            this.emailallert.Size = new System.Drawing.Size(32, 18);
            this.emailallert.TabIndex = 15;
            this.emailallert.TabStop = false;
            this.emailallert.Visible = false;
            // 
            // passwordallert
            // 
            this.passwordallert.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources.cancel;
            this.passwordallert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordallert.Location = new System.Drawing.Point(285, 165);
            this.passwordallert.Name = "passwordallert";
            this.passwordallert.Size = new System.Drawing.Size(32, 18);
            this.passwordallert.TabIndex = 16;
            this.passwordallert.TabStop = false;
            this.passwordallert.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cloud_Shopping_Mall.Properties.Resources._29nhJr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailallert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordallert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forget;
        private System.Windows.Forms.RadioButton customer;
        private System.Windows.Forms.RadioButton employee;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.PictureBox passwordallert;
        private System.Windows.Forms.PictureBox emailallert;
    }
}