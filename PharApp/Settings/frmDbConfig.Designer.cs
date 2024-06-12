﻿namespace PharApp.Settings
{
    partial class frmDbConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDbConfig));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtServer = new TextBox();
            label2 = new Label();
            txtDatabase = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            chkWindowsAuth = new CheckBox();
            label5 = new Label();
            btn_Connect = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 207);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(24, 239);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 1;
            label1.Text = "Server: ";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(131, 238);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(276, 27);
            txtServer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(24, 280);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 1;
            label2.Text = "Database: ";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(131, 279);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(276, 27);
            txtDatabase.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(24, 320);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 1;
            label3.Text = "Username: ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(131, 319);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(276, 27);
            txtUsername.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(24, 362);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 1;
            label4.Text = "Password: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(131, 361);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(276, 27);
            txtPassword.TabIndex = 4;
            // 
            // chkWindowsAuth
            // 
            chkWindowsAuth.AutoSize = true;
            chkWindowsAuth.Location = new Point(133, 402);
            chkWindowsAuth.Name = "chkWindowsAuth";
            chkWindowsAuth.Size = new Size(18, 17);
            chkWindowsAuth.TabIndex = 5;
            chkWindowsAuth.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(24, 397);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 1;
            label5.Text = "Win Auth";
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(26, 433);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(94, 29);
            btn_Connect.TabIndex = 6;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 433);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(407, 234);
            label6.Name = "label6";
            label6.Size = new Size(17, 23);
            label6.TabIndex = 1;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(407, 276);
            label7.Name = "label7";
            label7.Size = new Size(17, 23);
            label7.TabIndex = 1;
            label7.Text = "*";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(313, 433);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmDbConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 484);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(button2);
            Controls.Add(btn_Connect);
            Controls.Add(chkWindowsAuth);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtDatabase);
            Controls.Add(label2);
            Controls.Add(txtServer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDbConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtServer;
        private Label label2;
        private TextBox txtDatabase;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private CheckBox chkWindowsAuth;
        private Label label5;
        private Button btn_Connect;
        private Button button2;
        private Label label6;
        private Label label7;
        private Button btnClear;
    }
}