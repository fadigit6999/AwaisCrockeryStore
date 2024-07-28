
namespace PharApp.Inventory
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            btnRegisterAddOther = new Button();
            btnRegister = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(122, 97);
            btnRegisterAddOther.Margin = new Padding(3, 2, 3, 2);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(172, 22);
            btnRegisterAddOther.TabIndex = 7;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(35, 97);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(35, 71);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 23);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 53);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Unit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 8;
            label1.Text = "Register Unit";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(35, 135);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(35, 98);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmRegisterUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 178);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegisterUnit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Unit";
            Load += frmregisterunit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnUpdated_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnRegisterAddOther;
        private Button btnRegister;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;

        public EventHandler button_Click { get; private set; }
    }
}