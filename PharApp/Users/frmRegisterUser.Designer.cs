namespace PharApp.Users
{
    partial class frmRegisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterUser));
            button1 = new Button();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtFristName = new TextBox();
            label11 = new Label();
            label2 = new Label();
            txtPhoneno = new TextBox();
            btnGeneratePassword = new Button();
            btnViewPassword = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 409);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 348);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 0;
            label6.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(220, 371);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(186, 27);
            txtConfirmPassword.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 348);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 371);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(174, 27);
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 228);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 27);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 168);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(34, 191);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(362, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(39, 108);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(37, 131);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(361, 27);
            txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 53);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtFristName
            // 
            txtFristName.Location = new Point(36, 76);
            txtFristName.Name = "txtFristName";
            txtFristName.Size = new Size(361, 27);
            txtFristName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(28, 15);
            label11.Name = "label11";
            label11.Size = new Size(194, 32);
            label11.TabIndex = 0;
            label11.Text = "User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 292);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "Phone No";
            // 
            // txtPhoneno
            // 
            txtPhoneno.Location = new Point(36, 315);
            txtPhoneno.Name = "txtPhoneno";
            txtPhoneno.Size = new Size(364, 27);
            txtPhoneno.TabIndex = 5;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(199, 409);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(149, 29);
            btnGeneratePassword.TabIndex = 9;
            btnGeneratePassword.Text = "Generate Password";
            btnGeneratePassword.UseVisualStyleBackColor = true;
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // btnViewPassword
            // 
            btnViewPassword.Location = new Point(354, 409);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(52, 29);
            btnViewPassword.TabIndex = 10;
            btnViewPassword.Text = "View";
            btnViewPassword.UseVisualStyleBackColor = true;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(396, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmRegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 474);
            Controls.Add(btnClose);
            Controls.Add(btnViewPassword);
            Controls.Add(btnGeneratePassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtPhoneno);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFristName);
            Controls.Add(label1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmRegisterUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private TextBox txtConfirmPassword;
        private Label label5;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TextBox txtPhoneno;
        private Label label11;
        private Label lblLastName;
        private TextBox txtLastName;
        private TextBox txtFristName;
        private Button btnGeneratePassword;
        private Button btnViewPassword;
        private Button btnClose;
    }
}