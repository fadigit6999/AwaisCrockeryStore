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
            SuspendLayout();
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(141, 129);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(197, 29);
            btnRegisterAddOther.TabIndex = 3;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(42, 129);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(42, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 75);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 14;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 13;
            label1.Text = "Register Medicine Category";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(42, 176);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmRegisterCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 226);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Category";
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
    }
}