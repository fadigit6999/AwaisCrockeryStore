namespace PharApp.Sale.Area
{
    partial class frmRegisterSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterSupplier));
            richTxtAddress = new RichTextBox();
            btnRegisterAddOther = new Button();
            btnClose = new Button();
            btnRegister = new Button();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtCompany = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // richTxtAddress
            // 
            richTxtAddress.Location = new Point(34, 325);
            richTxtAddress.Name = "richTxtAddress";
            richTxtAddress.Size = new Size(326, 70);
            richTxtAddress.TabIndex = 5;
            richTxtAddress.Text = "";
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(136, 404);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(224, 29);
            btnRegisterAddOther.TabIndex = 7;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(28, 439);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(28, 404);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(34, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(326, 27);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 302);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 27;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 71);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 30;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 25;
            label1.Text = "Register Supplier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 127);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 30;
            label4.Text = "Company";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(37, 147);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(326, 27);
            txtCompany.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 182);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(37, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 27);
            txtEmail.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 239);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 30;
            label6.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(37, 259);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(326, 27);
            txtPhone.TabIndex = 4;
            // 
            // frmRegisterSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 483);
            Controls.Add(richTxtAddress);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtCompany);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTxtAddress;
        private Button btnRegisterAddOther;
        private Button btnClose;
        private Button btnRegister;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtCompany;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPhone;
    }
}