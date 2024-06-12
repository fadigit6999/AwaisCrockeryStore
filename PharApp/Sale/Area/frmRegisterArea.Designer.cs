namespace PharApp.Sale.Area
{
    partial class frmRegisterArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterArea));
            richTxtDescription = new RichTextBox();
            btnRegisterAddOther = new Button();
            btnClose = new Button();
            btnRegister = new Button();
            txtAreaNmae = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(34, 144);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(326, 70);
            richTxtDescription.TabIndex = 2;
            richTxtDescription.Text = "";
            // 
            // btnRegisterAddOther
            // 
            btnRegisterAddOther.Location = new Point(139, 220);
            btnRegisterAddOther.Name = "btnRegisterAddOther";
            btnRegisterAddOther.Size = new Size(213, 29);
            btnRegisterAddOther.TabIndex = 4;
            btnRegisterAddOther.Text = "Register and Add Other";
            btnRegisterAddOther.UseVisualStyleBackColor = true;
            btnRegisterAddOther.Click += btnRegisterAddOther_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(31, 255);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(31, 220);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtAreaNmae
            // 
            txtAreaNmae.Location = new Point(34, 91);
            txtAreaNmae.Name = "txtAreaNmae";
            txtAreaNmae.Size = new Size(326, 27);
            txtAreaNmae.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 121);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 27;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 71);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 30;
            label2.Text = "Area";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 25;
            label1.Text = "Register Area";
            // 
            // frmRegisterArea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 304);
            Controls.Add(richTxtDescription);
            Controls.Add(btnRegisterAddOther);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(txtAreaNmae);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegisterArea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Area ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTxtDescription;
        private Button btnRegisterAddOther;
        private Button btnClose;
        private Button btnRegister;
        private TextBox txtAreaNmae;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}