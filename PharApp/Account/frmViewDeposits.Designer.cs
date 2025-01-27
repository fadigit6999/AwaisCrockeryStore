namespace PharApp.Account
{
    partial class frmViewDeposits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewDeposits));
            dataGridViewDeposit = new DataGridView();
            label1 = new Label();
            lblAccountHolder = new Label();
            label2 = new Label();
            lblTRXAccount = new Label();
            label3 = new Label();
            txtSearchDeposit = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDeposit
            // 
            dataGridViewDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDeposit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDeposit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDeposit.BackgroundColor = Color.White;
            dataGridViewDeposit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeposit.Location = new Point(4, 44);
            dataGridViewDeposit.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDeposit.Name = "dataGridViewDeposit";
            dataGridViewDeposit.ReadOnly = true;
            dataGridViewDeposit.RowHeadersWidth = 51;
            dataGridViewDeposit.Size = new Size(908, 515);
            dataGridViewDeposit.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 2;
            label1.Text = "Account:";
            // 
            // lblAccountHolder
            // 
            lblAccountHolder.AutoSize = true;
            lblAccountHolder.Font = new Font("Calibri", 11F);
            lblAccountHolder.ForeColor = Color.DarkBlue;
            lblAccountHolder.Location = new Point(80, 15);
            lblAccountHolder.Name = "lblAccountHolder";
            lblAccountHolder.Size = new Size(0, 18);
            lblAccountHolder.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F);
            label2.Location = new Point(279, 15);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 2;
            label2.Text = "TRXID:";
            // 
            // lblTRXAccount
            // 
            lblTRXAccount.AutoSize = true;
            lblTRXAccount.Font = new Font("Calibri", 11F);
            lblTRXAccount.ForeColor = Color.DarkBlue;
            lblTRXAccount.Location = new Point(347, 15);
            lblTRXAccount.Name = "lblTRXAccount";
            lblTRXAccount.Size = new Size(0, 18);
            lblTRXAccount.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(641, 16);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Search";
            // 
            // txtSearchDeposit
            // 
            txtSearchDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchDeposit.Location = new Point(690, 12);
            txtSearchDeposit.Margin = new Padding(3, 2, 3, 2);
            txtSearchDeposit.Name = "txtSearchDeposit";
            txtSearchDeposit.Size = new Size(213, 23);
            txtSearchDeposit.TabIndex = 6;
            // 
            // frmViewDeposits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 562);
            Controls.Add(label3);
            Controls.Add(txtSearchDeposit);
            Controls.Add(lblTRXAccount);
            Controls.Add(lblAccountHolder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewDeposit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmViewDeposits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Account Deposits";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeposit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewDeposit;
        private Label label1;
        private Label lblAccountHolder;
        private Label label2;
        private Label lblTRXAccount;
        private Label label3;
        private TextBox txtSearchDeposit;
    }
}