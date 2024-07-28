namespace PharApp.Inventory
{
    partial class frmRegisterCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterCategory));
            btnRegisterAddOther = new Button();
            btnRegister = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            txtNameUrdu = new TextBox();
            SuspendLayout();
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(123, 148);
            btnRegisterAddOther.Margin = new Padding(3, 2, 3, 2);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(172, 22);
            btnRegisterAddOther.TabIndex = 3;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(37, 148);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(37, 71);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 56);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 14;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 13;
            label1.Text = "Register Category";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(37, 174);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(36, 147);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 100);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 14;
            label3.Text = "Category Name Urdu";
            // 
            // txtNameUrdu
            // 
            txtNameUrdu.Location = new Point(36, 115);
            txtNameUrdu.Margin = new Padding(3, 2, 3, 2);
            txtNameUrdu.Name = "txtNameUrdu";
            txtNameUrdu.Size = new Size(260, 23);
            txtNameUrdu.TabIndex = 1;
            // 
            // frmRegisterCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 207);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(txtNameUrdu);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegisterCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Category";
            Load += frmRegisterCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterAddOther;
        private Button btnRegister;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
        private Label label3;
        private TextBox txtNameUrdu;
    }
}