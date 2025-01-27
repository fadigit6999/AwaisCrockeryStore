namespace PharApp.Account
{
    partial class frmAccountDeposit
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountDeposit));
            tabAccountControl = new TabControl();
            tabAccount = new TabPage();
            btnRefresh = new Button();
            accountGrid = new DataGridView();
            label1 = new Label();
            txtSearchAccount = new TextBox();
            btnAccount = new Button();
            tabTransactionAccount = new TabPage();
            txtAccountTransactionSearch = new TextBox();
            label5 = new Label();
            dataGridViewTransactionAccount = new DataGridView();
            btnAccountTransactionRefresh = new Button();
            btnRegisterAccountTransaction = new Button();
            tabDeposit = new TabPage();
            btnRefreshDeposit = new Button();
            label2 = new Label();
            txtSearchDeposit = new TextBox();
            depositGrid = new DataGridView();
            btnDeposit = new Button();
            contextMenuStripDeposit = new ContextMenuStrip(components);
            generalLedgerReportToolStripMenuItem = new ToolStripMenuItem();
            viewDepositToolStripMenuItem = new ToolStripMenuItem();
            tabAccountControl.SuspendLayout();
            tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountGrid).BeginInit();
            tabTransactionAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionAccount).BeginInit();
            tabDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depositGrid).BeginInit();
            contextMenuStripDeposit.SuspendLayout();
            SuspendLayout();
            // 
            // tabAccountControl
            // 
            tabAccountControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabAccountControl.Controls.Add(tabAccount);
            tabAccountControl.Controls.Add(tabTransactionAccount);
            tabAccountControl.Controls.Add(tabDeposit);
            tabAccountControl.Location = new Point(1, 1);
            tabAccountControl.Margin = new Padding(3, 2, 3, 2);
            tabAccountControl.Name = "tabAccountControl";
            tabAccountControl.SelectedIndex = 0;
            tabAccountControl.Size = new Size(933, 489);
            tabAccountControl.TabIndex = 2;
            // 
            // tabAccount
            // 
            tabAccount.BackColor = Color.White;
            tabAccount.Controls.Add(btnRefresh);
            tabAccount.Controls.Add(accountGrid);
            tabAccount.Controls.Add(label1);
            tabAccount.Controls.Add(txtSearchAccount);
            tabAccount.Controls.Add(btnAccount);
            tabAccount.Location = new Point(4, 24);
            tabAccount.Margin = new Padding(3, 2, 3, 2);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(3, 2, 3, 2);
            tabAccount.Size = new Size(925, 461);
            tabAccount.TabIndex = 2;
            tabAccount.Text = "Account";
            tabAccount.Click += tabAccount_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.Location = new Point(148, 4);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(30, 25);
            btnRefresh.TabIndex = 6;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // accountGrid
            // 
            accountGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            accountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            accountGrid.BackgroundColor = Color.White;
            accountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountGrid.Location = new Point(4, 33);
            accountGrid.Margin = new Padding(3, 2, 3, 2);
            accountGrid.Name = "accountGrid";
            accountGrid.ReadOnly = true;
            accountGrid.RowHeadersWidth = 51;
            accountGrid.Size = new Size(915, 422);
            accountGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(660, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchAccount.Location = new Point(709, 5);
            txtSearchAccount.Margin = new Padding(3, 2, 3, 2);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new Size(213, 23);
            txtSearchAccount.TabIndex = 2;
            txtSearchAccount.KeyUp += txtSearchAccount_KeyUp;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(7, 4);
            btnAccount.Margin = new Padding(3, 2, 3, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(137, 25);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "Register Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // tabTransactionAccount
            // 
            tabTransactionAccount.Controls.Add(txtAccountTransactionSearch);
            tabTransactionAccount.Controls.Add(label5);
            tabTransactionAccount.Controls.Add(dataGridViewTransactionAccount);
            tabTransactionAccount.Controls.Add(btnAccountTransactionRefresh);
            tabTransactionAccount.Controls.Add(btnRegisterAccountTransaction);
            tabTransactionAccount.Location = new Point(4, 24);
            tabTransactionAccount.Name = "tabTransactionAccount";
            tabTransactionAccount.Padding = new Padding(3);
            tabTransactionAccount.Size = new Size(925, 461);
            tabTransactionAccount.TabIndex = 6;
            tabTransactionAccount.Text = "Account Transaction";
            tabTransactionAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccountTransactionSearch
            // 
            txtAccountTransactionSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAccountTransactionSearch.Location = new Point(704, 7);
            txtAccountTransactionSearch.Margin = new Padding(3, 2, 3, 2);
            txtAccountTransactionSearch.Name = "txtAccountTransactionSearch";
            txtAccountTransactionSearch.Size = new Size(213, 23);
            txtAccountTransactionSearch.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(656, 11);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 15;
            label5.Text = "Search";
            // 
            // dataGridViewTransactionAccount
            // 
            dataGridViewTransactionAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactionAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransactionAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTransactionAccount.BackgroundColor = Color.White;
            dataGridViewTransactionAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactionAccount.Location = new Point(5, 34);
            dataGridViewTransactionAccount.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTransactionAccount.Name = "dataGridViewTransactionAccount";
            dataGridViewTransactionAccount.ReadOnly = true;
            dataGridViewTransactionAccount.RowHeadersWidth = 51;
            dataGridViewTransactionAccount.Size = new Size(915, 422);
            dataGridViewTransactionAccount.TabIndex = 14;
            // 
            // btnAccountTransactionRefresh
            // 
            btnAccountTransactionRefresh.BackgroundImage = (Image)resources.GetObject("btnAccountTransactionRefresh.BackgroundImage");
            btnAccountTransactionRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccountTransactionRefresh.Location = new Point(200, 5);
            btnAccountTransactionRefresh.Margin = new Padding(3, 2, 3, 2);
            btnAccountTransactionRefresh.Name = "btnAccountTransactionRefresh";
            btnAccountTransactionRefresh.Size = new Size(30, 25);
            btnAccountTransactionRefresh.TabIndex = 13;
            btnAccountTransactionRefresh.UseVisualStyleBackColor = true;
            btnAccountTransactionRefresh.Click += btnAccountTransactionRefresh_Click;
            // 
            // btnRegisterAccountTransaction
            // 
            btnRegisterAccountTransaction.Location = new Point(7, 5);
            btnRegisterAccountTransaction.Margin = new Padding(3, 2, 3, 2);
            btnRegisterAccountTransaction.Name = "btnRegisterAccountTransaction";
            btnRegisterAccountTransaction.Size = new Size(188, 25);
            btnRegisterAccountTransaction.TabIndex = 12;
            btnRegisterAccountTransaction.Text = "Register Account Transaction";
            btnRegisterAccountTransaction.UseVisualStyleBackColor = true;
            btnRegisterAccountTransaction.Click += btnRegisterAccountTransaction_Click;
            // 
            // tabDeposit
            // 
            tabDeposit.Controls.Add(btnRefreshDeposit);
            tabDeposit.Controls.Add(label2);
            tabDeposit.Controls.Add(txtSearchDeposit);
            tabDeposit.Controls.Add(depositGrid);
            tabDeposit.Controls.Add(btnDeposit);
            tabDeposit.Location = new Point(4, 24);
            tabDeposit.Margin = new Padding(3, 2, 3, 2);
            tabDeposit.Name = "tabDeposit";
            tabDeposit.Padding = new Padding(3, 2, 3, 2);
            tabDeposit.Size = new Size(925, 461);
            tabDeposit.TabIndex = 3;
            tabDeposit.Text = "Deposits";
            tabDeposit.UseVisualStyleBackColor = true;
            // 
            // btnRefreshDeposit
            // 
            btnRefreshDeposit.BackgroundImage = (Image)resources.GetObject("btnRefreshDeposit.BackgroundImage");
            btnRefreshDeposit.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefreshDeposit.Location = new Point(138, 5);
            btnRefreshDeposit.Margin = new Padding(3, 2, 3, 2);
            btnRefreshDeposit.Name = "btnRefreshDeposit";
            btnRefreshDeposit.Size = new Size(30, 25);
            btnRefreshDeposit.TabIndex = 7;
            btnRefreshDeposit.UseVisualStyleBackColor = true;
            btnRefreshDeposit.Click += btnRefreshDeposit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(655, 11);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Search";
            // 
            // txtSearchDeposit
            // 
            txtSearchDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchDeposit.Location = new Point(704, 7);
            txtSearchDeposit.Margin = new Padding(3, 2, 3, 2);
            txtSearchDeposit.Name = "txtSearchDeposit";
            txtSearchDeposit.Size = new Size(213, 23);
            txtSearchDeposit.TabIndex = 4;
            txtSearchDeposit.KeyUp += textSearchDeposit_KeyUp;
            // 
            // depositGrid
            // 
            depositGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            depositGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            depositGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            depositGrid.BackgroundColor = Color.White;
            depositGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            depositGrid.Location = new Point(3, 34);
            depositGrid.Margin = new Padding(3, 2, 3, 2);
            depositGrid.Name = "depositGrid";
            depositGrid.ReadOnly = true;
            depositGrid.RowHeadersWidth = 51;
            depositGrid.Size = new Size(917, 424);
            depositGrid.TabIndex = 0;
            depositGrid.MouseClick += depositGrid_MouseClick;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(7, 6);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(125, 22);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Register Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // contextMenuStripDeposit
            // 
            contextMenuStripDeposit.Items.AddRange(new ToolStripItem[] { generalLedgerReportToolStripMenuItem, viewDepositToolStripMenuItem });
            contextMenuStripDeposit.Name = "contextMenuStripDeposit";
            contextMenuStripDeposit.Size = new Size(196, 70);
            // 
            // generalLedgerReportToolStripMenuItem
            // 
            generalLedgerReportToolStripMenuItem.Name = "generalLedgerReportToolStripMenuItem";
            generalLedgerReportToolStripMenuItem.Size = new Size(195, 22);
            generalLedgerReportToolStripMenuItem.Text = "General Ledger Report";
            generalLedgerReportToolStripMenuItem.Click += generalLedgerReportToolStripMenuItem_Click;
            // 
            // viewDepositToolStripMenuItem
            // 
            viewDepositToolStripMenuItem.Name = "viewDepositToolStripMenuItem";
            viewDepositToolStripMenuItem.Size = new Size(195, 22);
            viewDepositToolStripMenuItem.Text = "View Account Deposits";
            viewDepositToolStripMenuItem.Click += viewDepositToolStripMenuItem_Click;
            // 
            // frmAccountDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 490);
            Controls.Add(tabAccountControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAccountDeposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Account Management";
            Load += frmAccountDeposit_Load;
            tabAccountControl.ResumeLayout(false);
            tabAccount.ResumeLayout(false);
            tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountGrid).EndInit();
            tabTransactionAccount.ResumeLayout(false);
            tabTransactionAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionAccount).EndInit();
            tabDeposit.ResumeLayout(false);
            tabDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)depositGrid).EndInit();
            contextMenuStripDeposit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAccountControl;
        private TabPage tabAccount;
        public DataGridView accountGrid;
        private Label label1;
        private TextBox txtSearchAccount;
        private Button btnAccount;
        private TabPage tabDeposit;
        public DataGridView depositGrid;
        private Button btnRegisterRoles;
        private Button btnDeposit;
        private Label label2;
        private TextBox txtSearchDeposit;
        private Button btnRefresh;
        private Button btnRefreshDeposit;
        private TabPage tabPageAdjustmentAccount;
        private Button btnRefreshAdjustementAccount;
        public DataGridView dataGridViewAdjustementAccount;
        private Label label3;
        private TextBox txtSearchAdjustementAccount;
        private Button btnRegisterAdjustmentAccount;
        private TabPage tabPageAdjustmentDeposit;
        private Button btnRefreshAdjustmentDepositGrid;
        private Label label4;
        private TextBox txtAdjustmentDepositSearch;
        public DataGridView dataGridViewAdjustmentDepositGrid;
        private Button btnAdjustmentDeposit;
        private TabPage tabTransactionAccount;
        private TextBox txtAccountTransactionSearch;
        private Label label5;
        public DataGridView dataGridViewTransactionAccount;
        private Button btnAccountTransactionRefresh;
        private Button btnRegisterAccountTransaction;
        private ContextMenuStrip contextMenuStripDeposit;
        private ToolStripMenuItem generalLedgerReportToolStripMenuItem;
        private ToolStripMenuItem viewDepositToolStripMenuItem;
    }
}