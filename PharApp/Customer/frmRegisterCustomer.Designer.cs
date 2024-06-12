namespace PharApp.Customer
{
    partial class frmRegisterCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterCustomer));
            btnRegistration = new Button();
            txtPhoneno = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFristName = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label3 = new Label();
            txtType = new TextBox();
            label5 = new Label();
            txtAddress = new RichTextBox();
            btnRegisterAdd = new Button();
            label6 = new Label();
            cmbCustomerCategory = new ComboBox();
            label7 = new Label();
            txtDSL = new TextBox();
            SuspendLayout();
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(32, 550);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(151, 29);
            btnRegistration.TabIndex = 26;
            btnRegistration.Text = "Register";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // txtPhoneno
            // 
            txtPhoneno.Location = new Point(33, 340);
            txtPhoneno.Name = "txtPhoneno";
            txtPhoneno.Size = new Size(364, 27);
            txtPhoneno.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 317);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 11;
            label2.Text = "Phone No";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 27);
            txtEmail.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 253);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // txtFristName
            // 
            txtFristName.Location = new Point(32, 90);
            txtFristName.Name = "txtFristName";
            txtFristName.Size = new Size(361, 27);
            txtFristName.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 67);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 15;
            label1.Text = "First Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(24, 29);
            label11.Name = "label11";
            label11.Size = new Size(250, 32);
            label11.TabIndex = 17;
            label11.Text = "Customer Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 375);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 11;
            label3.Text = "Type";
            // 
            // txtType
            // 
            txtType.Location = new Point(32, 398);
            txtType.Name = "txtType";
            txtType.Size = new Size(364, 27);
            txtType.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 434);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 27;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(34, 459);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(363, 85);
            txtAddress.TabIndex = 28;
            txtAddress.Text = "";
            // 
            // btnRegisterAdd
            // 
            btnRegisterAdd.Location = new Point(189, 550);
            btnRegisterAdd.Name = "btnRegisterAdd";
            btnRegisterAdd.Size = new Size(204, 29);
            btnRegisterAdd.TabIndex = 26;
            btnRegisterAdd.Text = "Register And Add Other";
            btnRegisterAdd.UseVisualStyleBackColor = true;
            btnRegisterAdd.Click += btnRegisterAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 130);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 15;
            label6.Text = "Customer Category";
            // 
            // cmbCustomerCategory
            // 
            cmbCustomerCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomerCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomerCategory.FormattingEnabled = true;
            cmbCustomerCategory.Location = new Point(33, 153);
            cmbCustomerCategory.Name = "cmbCustomerCategory";
            cmbCustomerCategory.Size = new Size(360, 28);
            cmbCustomerCategory.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 191);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 14;
            label7.Text = "DSL";
            // 
            // txtDSL
            // 
            txtDSL.Location = new Point(31, 214);
            txtDSL.Name = "txtDSL";
            txtDSL.Size = new Size(361, 27);
            txtDSL.TabIndex = 22;
            // 
            // frmRegisterCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 593);
            Controls.Add(cmbCustomerCategory);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(btnRegisterAdd);
            Controls.Add(btnRegistration);
            Controls.Add(txtType);
            Controls.Add(label3);
            Controls.Add(txtPhoneno);
            Controls.Add(label2);
            Controls.Add(txtDSL);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtFristName);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Registration";
            Load += frmRegisterCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label11;
        private Label label3;
       
        private Label label2;
        private Label label4;

        private Button btnRegistration;
        private TextBox txtPhoneno;
        private TextBox txtEmail;
        private TextBox txtFristName;
        private TextBox txtType;
        private Label label5;
        private RichTextBox txtAddress;
        private Button btnRegisterAdd;
        private Label label6;
        private ComboBox cmbCustomerCategory;
        private Label label7;
        private TextBox txtDSL;
    }
}