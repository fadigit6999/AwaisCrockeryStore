namespace PharApp.Purchase
{
    partial class frmRegisterManufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterManufacturer));
            btnRegisterAddOther = new Button();
            btnRegister = new Button();
            txtMobile = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            richTxtAddress = new RichTextBox();
            richTextDetail = new RichTextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(137, 219);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(213, 29);
            btnRegisterAddOther.TabIndex = 6;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(29, 219);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(205, 90);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(148, 27);
            txtMobile.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(32, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(145, 27);
            txtName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 120);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 67);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 8;
            label4.Text = "Mobile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 120);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 6;
            label1.Text = "Register Manufacturer";
            // 
            // richTxtAddress
            // 
            richTxtAddress.Location = new Point(32, 143);
            richTxtAddress.Name = "richTxtAddress";
            richTxtAddress.Size = new Size(145, 70);
            richTxtAddress.TabIndex = 3;
            richTxtAddress.Text = "";
            // 
            // richTextDetail
            // 
            richTextDetail.Location = new Point(205, 143);
            richTextDetail.Name = "richTextDetail";
            richTextDetail.Size = new Size(145, 70);
            richTextDetail.TabIndex = 4;
            richTextDetail.Text = "";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(29, 254);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmRegisterManufacturer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 304);
            Controls.Add(richTextDetail);
            Controls.Add(richTxtAddress);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtMobile);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterManufacturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Manufacturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegisterAddOther;
        private Button btnRegister;
        private TextBox txtMobile;
        private TextBox txtName;
        private RichTextBox richTxtAddress;
        private RichTextBox richTextDetail;
        private Button btnClose;
    }
}