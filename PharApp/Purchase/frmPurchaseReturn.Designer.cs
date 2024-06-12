namespace PharApp.Purchase
{
    partial class frmPurchaseReturn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReturn));
            tabControlPurchase = new TabControl();
            tabPagePurchase = new TabPage();
            lblDefineInvoice = new Label();
            lblInvoiceDateDefine = new Label();
            lblInvoiceDate = new Label();
            lblInvoice = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnClearDetails = new Button();
            btnAddDetails = new Button();
            dateTimeMedExpiry = new DateTimePicker();
            purchaseDate = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            cmbPaymentType = new ComboBox();
            txtManfPrice = new TextBox();
            txtInvoice = new TextBox();
            txtDetail = new TextBox();
            cmbManufacturer = new ComboBox();
            label4 = new Label();
            txtAdvTax = new TextBox();
            label3 = new Label();
            txtPurchaseQnt = new TextBox();
            label5 = new Label();
            txtTotal = new TextBox();
            label2 = new Label();
            txtDisc = new TextBox();
            txtGrandTotal = new TextBox();
            txtGSTtx = new TextBox();
            txtBonus = new TextBox();
            cmbMedInformation = new ComboBox();
            label17 = new Label();
            txtStockQuantity = new TextBox();
            txtBatchId = new TextBox();
            label16 = new Label();
            label9 = new Label();
            label14 = new Label();
            label13 = new Label();
            label7 = new Label();
            label15 = new Label();
            label6 = new Label();
            label1 = new Label();
            label8 = new Label();
            label12 = new Label();
            btnPurchase = new Button();
            groupBox2 = new GroupBox();
            dataGridViewPurchaseDetails = new DataGridView();
            tabPageViewPurchase = new TabPage();
            txtSearch = new TextBox();
            label18 = new Label();
            dataGridViewPurchase = new DataGridView();
            contextMenuStripPurchase = new ContextMenuStrip(components);
            printReportToolStripMenuItem = new ToolStripMenuItem();
            tabControlPurchase.SuspendLayout();
            tabPagePurchase.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchaseDetails).BeginInit();
            tabPageViewPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).BeginInit();
            contextMenuStripPurchase.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPurchase
            // 
            tabControlPurchase.Controls.Add(tabPagePurchase);
            tabControlPurchase.Controls.Add(tabPageViewPurchase);
            tabControlPurchase.Location = new Point(12, 12);
            tabControlPurchase.Name = "tabControlPurchase";
            tabControlPurchase.SelectedIndex = 0;
            tabControlPurchase.Size = new Size(1269, 718);
            tabControlPurchase.TabIndex = 0;
            // 
            // tabPagePurchase
            // 
            tabPagePurchase.Controls.Add(lblDefineInvoice);
            tabPagePurchase.Controls.Add(lblInvoiceDateDefine);
            tabPagePurchase.Controls.Add(lblInvoiceDate);
            tabPagePurchase.Controls.Add(lblInvoice);
            tabPagePurchase.Controls.Add(groupBox1);
            tabPagePurchase.Controls.Add(btnPurchase);
            tabPagePurchase.Controls.Add(groupBox2);
            tabPagePurchase.Location = new Point(4, 29);
            tabPagePurchase.Name = "tabPagePurchase";
            tabPagePurchase.Padding = new Padding(3);
            tabPagePurchase.Size = new Size(1261, 685);
            tabPagePurchase.TabIndex = 0;
            tabPagePurchase.Text = "Return Purchase";
            tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // lblDefineInvoice
            // 
            lblDefineInvoice.AutoSize = true;
            lblDefineInvoice.Location = new Point(95, 18);
            lblDefineInvoice.Name = "lblDefineInvoice";
            lblDefineInvoice.Size = new Size(0, 20);
            lblDefineInvoice.TabIndex = 7;
            // 
            // lblInvoiceDateDefine
            // 
            lblInvoiceDateDefine.AutoSize = true;
            lblInvoiceDateDefine.Location = new Point(315, 18);
            lblInvoiceDateDefine.Name = "lblInvoiceDateDefine";
            lblInvoiceDateDefine.Size = new Size(0, 20);
            lblInvoiceDateDefine.TabIndex = 7;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(217, 18);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(92, 20);
            lblInvoiceDate.TabIndex = 7;
            lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.Location = new Point(9, 18);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(80, 20);
            lblInvoice.TabIndex = 7;
            lblInvoice.Text = "Invoice No";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnClearDetails);
            groupBox1.Controls.Add(btnAddDetails);
            groupBox1.Controls.Add(dateTimeMedExpiry);
            groupBox1.Controls.Add(purchaseDate);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmbPaymentType);
            groupBox1.Controls.Add(txtManfPrice);
            groupBox1.Controls.Add(txtInvoice);
            groupBox1.Controls.Add(txtDetail);
            groupBox1.Controls.Add(cmbManufacturer);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAdvTax);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPurchaseQnt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDisc);
            groupBox1.Controls.Add(txtGrandTotal);
            groupBox1.Controls.Add(txtGSTtx);
            groupBox1.Controls.Add(txtBonus);
            groupBox1.Controls.Add(cmbMedInformation);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(txtStockQuantity);
            groupBox1.Controls.Add(txtBatchId);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(9, 647);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 32);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purchase Details";
            groupBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(111, 46);
            button2.Name = "button2";
            button2.Size = new Size(146, 31);
            button2.TabIndex = 6;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(1093, 107);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(32, 29);
            btnClearDetails.TabIndex = 5;
            btnClearDetails.Text = "X";
            btnClearDetails.UseVisualStyleBackColor = true;
            btnClearDetails.Click += btnClearDetails_Click;
            // 
            // btnAddDetails
            // 
            btnAddDetails.Location = new Point(1131, 84);
            btnAddDetails.Name = "btnAddDetails";
            btnAddDetails.Size = new Size(105, 65);
            btnAddDetails.TabIndex = 5;
            btnAddDetails.Text = "Add Med.";
            btnAddDetails.UseVisualStyleBackColor = true;
            btnAddDetails.Click += btnAddDetails_Click;
            // 
            // dateTimeMedExpiry
            // 
            dateTimeMedExpiry.Format = DateTimePickerFormat.Short;
            dateTimeMedExpiry.Location = new Point(272, 107);
            dateTimeMedExpiry.Name = "dateTimeMedExpiry";
            dateTimeMedExpiry.Size = new Size(143, 27);
            dateTimeMedExpiry.TabIndex = 4;
            // 
            // purchaseDate
            // 
            purchaseDate.CustomFormat = "yyyy-MM-dd";
            purchaseDate.Format = DateTimePickerFormat.Short;
            purchaseDate.Location = new Point(340, 74);
            purchaseDate.Name = "purchaseDate";
            purchaseDate.Size = new Size(202, 27);
            purchaseDate.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(774, 84);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 0;
            label11.Text = "Manuf. Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(565, 85);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 0;
            label10.Text = "Quantity";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(548, 76);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(261, 28);
            cmbPaymentType.TabIndex = 2;
            // 
            // txtManfPrice
            // 
            txtManfPrice.Enabled = false;
            txtManfPrice.Location = new Point(774, 108);
            txtManfPrice.Name = "txtManfPrice";
            txtManfPrice.Size = new Size(110, 27);
            txtManfPrice.TabIndex = 1;
            // 
            // txtInvoice
            // 
            txtInvoice.Enabled = false;
            txtInvoice.Location = new Point(55, 74);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(279, 27);
            txtInvoice.TabIndex = 1;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(815, 77);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(279, 27);
            txtDetail.TabIndex = 1;
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(13, 48);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(254, 28);
            cmbManufacturer.TabIndex = 2;
            cmbManufacturer.SelectedIndexChanged += cmbManufacturer_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 51);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 0;
            label4.Text = "Invoice No.";
            // 
            // txtAdvTax
            // 
            txtAdvTax.Location = new Point(294, 52);
            txtAdvTax.Name = "txtAdvTax";
            txtAdvTax.Size = new Size(216, 27);
            txtAdvTax.TabIndex = 1;
            txtAdvTax.Click += txtAdvTax_Click;
            txtAdvTax.TextChanged += txtAdvDisc_TextChanged;
            txtAdvTax.KeyPress += txtAdvTax_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 52);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "Payment Type";
            // 
            // txtPurchaseQnt
            // 
            txtPurchaseQnt.Location = new Point(565, 108);
            txtPurchaseQnt.Name = "txtPurchaseQnt";
            txtPurchaseQnt.Size = new Size(107, 27);
            txtPurchaseQnt.TabIndex = 1;
            txtPurchaseQnt.Click += txtPurchaseQnt_Click;
            txtPurchaseQnt.KeyPress += txtPurchaseQnt_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(815, 56);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 0;
            label5.Text = "Details";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(294, 17);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(216, 27);
            txtTotal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 49);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 0;
            label2.Text = "Purchase Date";
            // 
            // txtDisc
            // 
            txtDisc.Location = new Point(890, 108);
            txtDisc.Name = "txtDisc";
            txtDisc.Size = new Size(101, 27);
            txtDisc.TabIndex = 1;
            txtDisc.Click += txtDisc_Click;
            txtDisc.KeyPress += txtDisc_KeyPress;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(294, 85);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(216, 27);
            txtGrandTotal.TabIndex = 1;
            // 
            // txtGSTtx
            // 
            txtGSTtx.Location = new Point(997, 108);
            txtGSTtx.Name = "txtGSTtx";
            txtGSTtx.Size = new Size(90, 27);
            txtGSTtx.TabIndex = 1;
            txtGSTtx.Click += txtGSTtx_Click;
            txtGSTtx.KeyPress += txtGSTtx_KeyPress;
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(678, 108);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(90, 27);
            txtBonus.TabIndex = 1;
            txtBonus.Click += txtBonus_Click;
            txtBonus.KeyPress += txtBonus_KeyPress;
            // 
            // cmbMedInformation
            // 
            cmbMedInformation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedInformation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedInformation.FormattingEnabled = true;
            cmbMedInformation.Location = new Point(12, 108);
            cmbMedInformation.Name = "cmbMedInformation";
            cmbMedInformation.Size = new Size(158, 28);
            cmbMedInformation.TabIndex = 2;
            cmbMedInformation.SelectedIndexChanged += cmbMedInformation_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(221, 56);
            label17.Name = "label17";
            label17.Size = new Size(56, 20);
            label17.TabIndex = 0;
            label17.Text = "Adv Tx.";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Enabled = false;
            txtStockQuantity.Location = new Point(421, 107);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(138, 27);
            txtStockQuantity.TabIndex = 1;
            // 
            // txtBatchId
            // 
            txtBatchId.Location = new Point(176, 108);
            txtBatchId.Name = "txtBatchId";
            txtBatchId.Size = new Size(90, 27);
            txtBatchId.TabIndex = 1;
            txtBatchId.Click += txtBatchId_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(246, 22);
            label16.Name = "label16";
            label16.Size = new Size(42, 20);
            label16.TabIndex = 0;
            label16.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(421, 83);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 0;
            label9.Text = "Stock Quantity";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(997, 85);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 0;
            label14.Text = "GST Tx";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(202, 88);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 0;
            label13.Text = "Grand Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 85);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 0;
            label7.Text = "Bartch Id";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(890, 85);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 0;
            label15.Text = "Dics%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 87);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 0;
            label6.Text = "Med. Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Manufacturer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(678, 85);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 0;
            label8.Text = "Bonus";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(272, 83);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 0;
            label12.Text = "Expiry Date";
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(1019, 619);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(228, 57);
            btnPurchase.TabIndex = 6;
            btnPurchase.Text = "Purchase Return";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(dataGridViewPurchaseDetails);
            groupBox2.Location = new Point(3, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1249, 550);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "View Return Details";
            // 
            // dataGridViewPurchaseDetails
            // 
            dataGridViewPurchaseDetails.AllowUserToAddRows = false;
            dataGridViewPurchaseDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchaseDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPurchaseDetails.BackgroundColor = Color.White;
            dataGridViewPurchaseDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPurchaseDetails.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPurchaseDetails.Location = new Point(6, 21);
            dataGridViewPurchaseDetails.Name = "dataGridViewPurchaseDetails";
            dataGridViewPurchaseDetails.RowHeadersWidth = 51;
            dataGridViewPurchaseDetails.Size = new Size(1235, 522);
            dataGridViewPurchaseDetails.TabIndex = 0;
            dataGridViewPurchaseDetails.RowsRemoved += dataGridViewPurchaseDetails_RowsRemoved;
            dataGridViewPurchaseDetails.MouseClick += dataGridViewPurchaseDetails_MouseClick;
            // 
            // tabPageViewPurchase
            // 
            tabPageViewPurchase.Controls.Add(txtSearch);
            tabPageViewPurchase.Controls.Add(label18);
            tabPageViewPurchase.Controls.Add(dataGridViewPurchase);
            tabPageViewPurchase.Location = new Point(4, 29);
            tabPageViewPurchase.Name = "tabPageViewPurchase";
            tabPageViewPurchase.Padding = new Padding(3);
            tabPageViewPurchase.Size = new Size(1261, 685);
            tabPageViewPurchase.TabIndex = 1;
            tabPageViewPurchase.Text = "View Purchase Return ";
            tabPageViewPurchase.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(69, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(10, 19);
            label18.Name = "label18";
            label18.Size = new Size(53, 20);
            label18.TabIndex = 3;
            label18.Text = "Search";
            // 
            // dataGridViewPurchase
            // 
            dataGridViewPurchase.AllowUserToAddRows = false;
            dataGridViewPurchase.AllowUserToDeleteRows = false;
            dataGridViewPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPurchase.BackgroundColor = Color.White;
            dataGridViewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPurchase.ContextMenuStrip = contextMenuStripPurchase;
            dataGridViewPurchase.Location = new Point(3, 62);
            dataGridViewPurchase.MultiSelect = false;
            dataGridViewPurchase.Name = "dataGridViewPurchase";
            dataGridViewPurchase.ReadOnly = true;
            dataGridViewPurchase.RowHeadersWidth = 51;
            dataGridViewPurchase.Size = new Size(1252, 617);
            dataGridViewPurchase.TabIndex = 0;
            dataGridViewPurchase.MouseClick += dataGridViewPurchase_MouseClick;
            // 
            // contextMenuStripPurchase
            // 
            contextMenuStripPurchase.ImageScalingSize = new Size(20, 20);
            contextMenuStripPurchase.Items.AddRange(new ToolStripItem[] { printReportToolStripMenuItem });
            contextMenuStripPurchase.Name = "contextMenuStripPurchase";
            contextMenuStripPurchase.Size = new Size(158, 28);
            // 
            // printReportToolStripMenuItem
            // 
            printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            printReportToolStripMenuItem.Size = new Size(157, 24);
            printReportToolStripMenuItem.Text = "Print Report";
            printReportToolStripMenuItem.Click += printReportToolStripMenuItem_Click;
            // 
            // frmPurchaseReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 742);
            Controls.Add(tabControlPurchase);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPurchaseReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Return System";
            Load += frmPurchase_Load;
            tabControlPurchase.ResumeLayout(false);
            tabPagePurchase.ResumeLayout(false);
            tabPagePurchase.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchaseDetails).EndInit();
            tabPageViewPurchase.ResumeLayout(false);
            tabPageViewPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).EndInit();
            contextMenuStripPurchase.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPurchase;
        private TabPage tabPagePurchase;
        private TabPage tabPageViewPurchase;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private GroupBox groupBox2;
        private Button button1;
     
        private Label label13;
   
        private Label label12;
        private Label label8;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label16;

        //order details
        private Button btnAddDetails;
        private TextBox txtManfPrice;
        private TextBox txtPurchaseQnt;
        private TextBox txtStockQuantity;
        private TextBox txtBonus;
        private TextBox txtDisc;
        private TextBox txtGSTtx;
        private TextBox txtBatchId;
        private DateTimePicker dateTimeMedExpiry;
        private ComboBox cmbMedInformation;
        private DataGridView dataGridViewPurchaseDetails;

        //orders
        private TextBox txtDetail;
        private TextBox txtInvoice;
        private TextBox txtTotal;
        private TextBox txtGrandTotal;
        private DateTimePicker purchaseDate;
        private ComboBox cmbPaymentType;
        private ComboBox cmbManufacturer;
        private TextBox txtAdvTax;
        private Button btnPurchase;
        private Button btnClearDetails;
        private Button button2;
        private DataGridView dataGridViewPurchase;
        private TextBox txtSearch;
        private Label label18;
        private ContextMenuStrip contextMenuStripPurchase;
        private ToolStripMenuItem printReportToolStripMenuItem;
        private Label lblDefineInvoice;
        private Label lblInvoiceDateDefine;
        private Label lblInvoiceDate;
        private Label lblInvoice;
    }
}