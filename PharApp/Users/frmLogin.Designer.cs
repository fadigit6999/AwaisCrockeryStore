namespace PharApp.Users
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            btnDatabaseCheck = new Button();
            checkBoxSavePassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(203, 57);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 0;
            label1.Text = "System Login";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(81, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(380, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(81, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(380, 27);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 146);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 203);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(81, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(489, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnDatabaseCheck
            // 
            btnDatabaseCheck.Location = new Point(449, 12);
            btnDatabaseCheck.Name = "btnDatabaseCheck";
            btnDatabaseCheck.Size = new Size(34, 29);
            btnDatabaseCheck.TabIndex = 3;
            btnDatabaseCheck.Text = "=";
            btnDatabaseCheck.UseVisualStyleBackColor = true;
            btnDatabaseCheck.Click += btnDatabaseCheck_Click;
            // 
            // checkBoxSavePassword
            // 
            checkBoxSavePassword.AutoSize = true;
            checkBoxSavePassword.Location = new Point(243, 263);
            checkBoxSavePassword.Name = "checkBoxSavePassword";
            checkBoxSavePassword.Size = new Size(213, 24);
            checkBoxSavePassword.TabIndex = 5;
            checkBoxSavePassword.Text = "Save Username && Password";
            checkBoxSavePassword.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 339);
            Controls.Add(checkBoxSavePassword);
            Controls.Add(pictureBox1);
            Controls.Add(btnDatabaseCheck);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnDatabaseCheck;
        private CheckBox checkBoxSavePassword;
    }
}