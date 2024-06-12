namespace PharApp.Sale
{
    partial class frmSaleReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleReturn));
            tabControlPurchase = new TabControl();
            tabPagePurchase = new TabPage();
            lblDefineInvoice = new Label();
            lblInvoiceDateDefine = new Label();
            lblInvoiceDate = new Label();
            lblInvoice = new Label();
            groupBox2 = new GroupBox();
            dataGridViewSaleDetails = new DataGridView();
            groupBox1 = new GroupBox();
            checkBoxWarranty = new CheckBox();
            dateTimeMedExpiry = new DateTimePicker();
            txtExpiryDate = new TextBox();
            saleDate = new DateTimePicker();
            btnClearDetails = new Button();
            btnAddDetails = new Button();
            cmbPaymentType = new ComboBox();
            label11 = new Label();
            cmbCustomer = new ComboBox();
            label10 = new Label();
            txtInvoice = new TextBox();
            txtDetail = new TextBox();
            txtManfPrice = new TextBox();
            label4 = new Label();
            txtSaleQnt = new TextBox();
            label3 = new Label();
            txtDisc = new TextBox();
            label5 = new Label();
            txtGSTtx = new TextBox();
            label2 = new Label();
            txtBonus = new TextBox();
            label1 = new Label();
            cmbBatchId = new ComboBox();
            cmbMedInformation = new ComboBox();
            button2 = new Button();
            txtStockQuantity = new TextBox();
            label9 = new Label();
            label14 = new Label();
            label7 = new Label();
            txtAdvTax = new TextBox();
            label15 = new Label();
            txtTotal = new TextBox();
            label6 = new Label();
            txtGrandTotal = new TextBox();
            label17 = new Label();
            label8 = new Label();
            label16 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnPurchase = new Button();
            tabPageViewPurchase = new TabPage();
            txtSearch = new TextBox();
            label18 = new Label();
            dataGridViewSale = new DataGridView();
            contextMenuStripSale = new ContextMenuStrip(components);
            printReportToolStripMenuItem = new ToolStripMenuItem();
            tabControlPurchase.SuspendLayout();
            tabPagePurchase.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaleDetails).BeginInit();
            groupBox1.SuspendLayout();
            tabPageViewPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).BeginInit();
            contextMenuStripSale.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPurchase
            // 
            tabControlPurchase.Controls.Add(tabPagePurchase);
            tabControlPurchase.Controls.Add(tabPageViewPurchase);
            tabControlPurchase.Location = new Point(12, 12);
            tabControlPurchase.Name = "tabControlPurchase";
            tabControlPurchase.SelectedIndex = 0;
            tabControlPurchase.Size = new Size(1269, 760);
            tabControlPurchase.TabIndex = 27;
            // 
            // tabPagePurchase
            // 
            tabPagePurchase.Controls.Add(lblDefineInvoice);
            tabPagePurchase.Controls.Add(lblInvoiceDateDefine);
            tabPagePurchase.Controls.Add(lblInvoiceDate);
            tabPagePurchase.Controls.Add(lblInvoice);
            tabPagePurchase.Controls.Add(groupBox2);
            tabPagePurchase.Controls.Add(groupBox1);
            tabPagePurchase.Controls.Add(btnPurchase);
            tabPagePurchase.Location = new Point(4, 29);
            tabPagePurchase.Name = "tabPagePurchase";
            tabPagePurchase.Padding = new Padding(3);
            tabPagePurchase.Size = new Size(1261, 727);
            tabPagePurchase.TabIndex = 0;
            tabPagePurchase.Text = "Sale";
            tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // lblDefineInvoice
            // 
            lblDefineInvoice.AutoSize = true;
            lblDefineInvoice.Location = new Point(97, 19);
            lblDefineInvoice.Name = "lblDefineInvoice";
            lblDefineInvoice.Size = new Size(0, 20);
            lblDefineInvoice.TabIndex = 47;
            // 
            // lblInvoiceDateDefine
            // 
            lblInvoiceDateDefine.AutoSize = true;
            lblInvoiceDateDefine.Location = new Point(317, 19);
            lblInvoiceDateDefine.Name = "lblInvoiceDateDefine";
            lblInvoiceDateDefine.Size = new Size(0, 20);
            lblInvoiceDateDefine.TabIndex = 48;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(219, 19);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(92, 20);
            lblInvoiceDate.TabIndex = 49;
            lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.Location = new Point(11, 19);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(80, 20);
            lblInvoice.TabIndex = 50;
            lblInvoice.Text = "Invoice No";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(dataGridViewSaleDetails);
            groupBox2.Location = new Point(6, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1245, 593);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "View Details";
            // 
            // dataGridViewSaleDetails
            // 
            dataGridViewSaleDetails.AllowUserToAddRows = false;
            dataGridViewSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSaleDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSaleDetails.BackgroundColor = Color.White;
            dataGridViewSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewSaleDetails.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSaleDetails.Location = new Point(14, 26);
            dataGridViewSaleDetails.Name = "dataGridViewSaleDetails";
            dataGridViewSaleDetails.ReadOnly = true;
            dataGridViewSaleDetails.RowHeadersWidth = 51;
            dataGridViewSaleDetails.Size = new Size(1225, 561);
            dataGridViewSaleDetails.TabIndex = 0;
            dataGridViewSaleDetails.RowsRemoved += dataGridViewPurchaseDetails_RowsRemoved;
            dataGridViewSaleDetails.MouseClick += dataGridViewPurchaseDetails_MouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxWarranty);
            groupBox1.Controls.Add(dateTimeMedExpiry);
            groupBox1.Controls.Add(txtExpiryDate);
            groupBox1.Controls.Add(saleDate);
            groupBox1.Controls.Add(btnClearDetails);
            groupBox1.Controls.Add(btnAddDetails);
            groupBox1.Controls.Add(cmbPaymentType);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbCustomer);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtInvoice);
            groupBox1.Controls.Add(txtDetail);
            groupBox1.Controls.Add(txtManfPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSaleQnt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDisc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtGSTtx);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBonus);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbBatchId);
            groupBox1.Controls.Add(cmbMedInformation);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtStockQuantity);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAdvTax);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGrandTotal);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(48, 674);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 34);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sale Details";
            groupBox1.Visible = false;
            // 
            // checkBoxWarranty
            // 
            checkBoxWarranty.AutoSize = true;
            checkBoxWarranty.Location = new Point(74, 181);
            checkBoxWarranty.Name = "checkBoxWarranty";
            checkBoxWarranty.Size = new Size(245, 24);
            checkBoxWarranty.TabIndex = 12;
            checkBoxWarranty.Text = "Estimated Invoice (No Warranty)";
            checkBoxWarranty.UseVisualStyleBackColor = true;
            // 
            // dateTimeMedExpiry
            // 
            dateTimeMedExpiry.Format = DateTimePickerFormat.Short;
            dateTimeMedExpiry.Location = new Point(293, 129);
            dateTimeMedExpiry.Name = "dateTimeMedExpiry";
            dateTimeMedExpiry.Size = new Size(143, 27);
            dateTimeMedExpiry.TabIndex = 3;
            dateTimeMedExpiry.Visible = false;
            // 
            // txtExpiryDate
            // 
            txtExpiryDate.Location = new Point(293, 46);
            txtExpiryDate.Name = "txtExpiryDate";
            txtExpiryDate.ReadOnly = true;
            txtExpiryDate.Size = new Size(143, 27);
            txtExpiryDate.TabIndex = 11;
            // 
            // saleDate
            // 
            saleDate.CustomFormat = "yyyy-MM-dd";
            saleDate.Format = DateTimePickerFormat.Short;
            saleDate.Location = new Point(293, 87);
            saleDate.Name = "saleDate";
            saleDate.Size = new Size(227, 27);
            saleDate.TabIndex = 45;
            // 
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(1088, 44);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(32, 29);
            btnClearDetails.TabIndex = 9;
            btnClearDetails.Text = "X";
            btnClearDetails.UseVisualStyleBackColor = true;
            btnClearDetails.Click += btnClearDetails_Click;
            // 
            // btnAddDetails
            // 
            btnAddDetails.Location = new Point(1126, 21);
            btnAddDetails.Name = "btnAddDetails";
            btnAddDetails.Size = new Size(105, 65);
            btnAddDetails.TabIndex = 10;
            btnAddDetails.Text = "Add Med.";
            btnAddDetails.UseVisualStyleBackColor = true;
            btnAddDetails.Click += btnAddDetails_Click;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(718, 86);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(206, 28);
            cmbPaymentType.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(769, 21);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 0;
            label11.Text = "Sale Price";
            // 
            // cmbCustomer
            // 
            cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(526, 86);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(184, 28);
            cmbCustomer.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(571, 22);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 0;
            label10.Text = "Quantity";
            // 
            // txtInvoice
            // 
            txtInvoice.Enabled = false;
            txtInvoice.Location = new Point(81, 89);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(206, 27);
            txtInvoice.TabIndex = 40;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(930, 86);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(206, 27);
            txtDetail.TabIndex = 41;
            // 
            // txtManfPrice
            // 
            txtManfPrice.Enabled = false;
            txtManfPrice.Location = new Point(769, 45);
            txtManfPrice.Name = "txtManfPrice";
            txtManfPrice.Size = new Size(110, 27);
            txtManfPrice.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 66);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 35;
            label4.Text = "Sale Invoice No.";
            // 
            // txtSaleQnt
            // 
            txtSaleQnt.Location = new Point(571, 45);
            txtSaleQnt.Name = "txtSaleQnt";
            txtSaleQnt.Size = new Size(95, 27);
            txtSaleQnt.TabIndex = 4;
            txtSaleQnt.Click += txtSaleQnt_Click;
            txtSaleQnt.KeyPress += txtSaleQnt_KeyPress;
            txtSaleQnt.KeyUp += txtPurchaseQnt_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 60);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 36;
            label3.Text = "Payment Type";
            // 
            // txtDisc
            // 
            txtDisc.Location = new Point(885, 45);
            txtDisc.Name = "txtDisc";
            txtDisc.Size = new Size(101, 27);
            txtDisc.TabIndex = 7;
            txtDisc.Click += txtDisc_Click;
            txtDisc.KeyPress += txtDisc_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(930, 65);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 37;
            label5.Text = "Details";
            // 
            // txtGSTtx
            // 
            txtGSTtx.Location = new Point(992, 45);
            txtGSTtx.Name = "txtGSTtx";
            txtGSTtx.Size = new Size(90, 27);
            txtGSTtx.TabIndex = 8;
            txtGSTtx.Click += txtGSTtx_Click;
            txtGSTtx.KeyPress += txtGSTtx_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 64);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 38;
            label2.Text = "Sale Date";
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(673, 45);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(90, 27);
            txtBonus.TabIndex = 5;
            txtBonus.Click += txtBonus_Click;
            txtBonus.KeyPress += txtBonus_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 63);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 39;
            label1.Text = "Customer";
            label1.Click += label1_Click;
            // 
            // cmbBatchId
            // 
            cmbBatchId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBatchId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBatchId.FormattingEnabled = true;
            cmbBatchId.Location = new Point(171, 46);
            cmbBatchId.Name = "cmbBatchId";
            cmbBatchId.Size = new Size(116, 28);
            cmbBatchId.TabIndex = 2;
            cmbBatchId.SelectedIndexChanged += cmbBatchId_SelectedIndexChanged;
            // 
            // cmbMedInformation
            // 
            cmbMedInformation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedInformation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedInformation.FormattingEnabled = true;
            cmbMedInformation.Location = new Point(7, 45);
            cmbMedInformation.Name = "cmbMedInformation";
            cmbMedInformation.Size = new Size(158, 28);
            cmbMedInformation.TabIndex = 1;
            cmbMedInformation.SelectedIndexChanged += cmbMedInformation_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(146, 200);
            button2.Name = "button2";
            button2.Size = new Size(197, 36);
            button2.TabIndex = 14;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Enabled = false;
            txtStockQuantity.Location = new Point(442, 44);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(117, 27);
            txtStockQuantity.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 20);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 0;
            label9.Text = "Stock Quantity";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(992, 22);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 0;
            label14.Text = "GST Tx";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 22);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 0;
            label7.Text = "Bartch Id";
            // 
            // txtAdvTax
            // 
            txtAdvTax.Location = new Point(106, 115);
            txtAdvTax.Name = "txtAdvTax";
            txtAdvTax.Size = new Size(213, 27);
            txtAdvTax.TabIndex = 11;
            txtAdvTax.Click += txtAdvTax_Click;
            txtAdvTax.TextChanged += txtAdvDisc_TextChanged;
            txtAdvTax.KeyPress += txtAdvTax_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(885, 22);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 0;
            label15.Text = "Dics%";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(106, 78);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(213, 27);
            txtTotal.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 0;
            label6.Text = "Med. Information";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(106, 148);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(213, 27);
            txtGrandTotal.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(33, 119);
            label17.Name = "label17";
            label17.Size = new Size(56, 20);
            label17.TabIndex = 27;
            label17.Text = "Adv Tx.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(673, 22);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 0;
            label8.Text = "Bonus";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(58, 85);
            label16.Name = "label16";
            label16.Size = new Size(42, 20);
            label16.TabIndex = 28;
            label16.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(293, 20);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 0;
            label12.Text = "Expiry Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 151);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 29;
            label13.Text = "Grand Total";
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(1098, 653);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(153, 61);
            btnPurchase.TabIndex = 13;
            btnPurchase.Text = "Sale Return";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // tabPageViewPurchase
            // 
            tabPageViewPurchase.Controls.Add(txtSearch);
            tabPageViewPurchase.Controls.Add(label18);
            tabPageViewPurchase.Controls.Add(dataGridViewSale);
            tabPageViewPurchase.Location = new Point(4, 29);
            tabPageViewPurchase.Name = "tabPageViewPurchase";
            tabPageViewPurchase.Padding = new Padding(3);
            tabPageViewPurchase.Size = new Size(1261, 727);
            tabPageViewPurchase.TabIndex = 1;
            tabPageViewPurchase.Text = "View Sale Return";
            tabPageViewPurchase.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(67, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 24);
            label18.Name = "label18";
            label18.Size = new Size(53, 20);
            label18.TabIndex = 1;
            label18.Text = "Search";
            // 
            // dataGridViewSale
            // 
            dataGridViewSale.AllowUserToAddRows = false;
            dataGridViewSale.AllowUserToDeleteRows = false;
            dataGridViewSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSale.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSale.BackgroundColor = Color.White;
            dataGridViewSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSale.ContextMenuStrip = contextMenuStripSale;
            dataGridViewSale.ImeMode = ImeMode.NoControl;
            dataGridViewSale.Location = new Point(3, 63);
            dataGridViewSale.Name = "dataGridViewSale";
            dataGridViewSale.ReadOnly = true;
            dataGridViewSale.RowHeadersWidth = 51;
            dataGridViewSale.Size = new Size(1252, 661);
            dataGridViewSale.TabIndex = 0;
            dataGridViewSale.MouseClick += dataGridViewSale_MouseClick;
            // 
            // contextMenuStripSale
            // 
            contextMenuStripSale.ImageScalingSize = new Size(20, 20);
            contextMenuStripSale.Items.AddRange(new ToolStripItem[] { printReportToolStripMenuItem });
            contextMenuStripSale.Name = "contextMenuStripSale";
            contextMenuStripSale.Size = new Size(158, 28);
            // 
            // printReportToolStripMenuItem
            // 
            printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            printReportToolStripMenuItem.Size = new Size(157, 24);
            printReportToolStripMenuItem.Text = "Print Report";
            printReportToolStripMenuItem.Click += printReportToolStripMenuItem_Click;
            // 
            // frmSaleReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 784);
            Controls.Add(tabControlPurchase);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSaleReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Return";
            Load += frmSale_Load;
            tabControlPurchase.ResumeLayout(false);
            tabPagePurchase.ResumeLayout(false);
            tabPagePurchase.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaleDetails).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageViewPurchase.ResumeLayout(false);
            tabPageViewPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).EndInit();
            contextMenuStripSale.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPurchase;
        private TabPage tabPagePurchase;
        private TabPage tabPageViewPurchase;
        private DataGridView dataGridViewSale;
        private GroupBox groupBox2;
        private DataGridView dataGridViewSaleDetails;
        private DateTimePicker saleDate;
        private GroupBox groupBox1;
        private Button btnClearDetails;
        private Button btnAddDetails;
        private DateTimePicker dateTimeMedExpiry;
        private Label label11;
        private Label label10;
        private TextBox txtManfPrice;
        private TextBox txtSaleQnt;
        private TextBox txtDisc;
        private TextBox txtGSTtx;
        private TextBox txtBonus;
        private ComboBox cmbMedInformation;
        private TextBox txtStockQuantity;
        private Label label9;
        private Label label14;
        private Label label7;
        private Label label15;
        private Label label6;
        private Label label8;
        private Label label12;
        private ComboBox cmbPaymentType;
        private ComboBox cmbCustomer;
        private TextBox txtInvoice;
        private TextBox txtDetail;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnPurchase;
        private TextBox txtAdvTax;
        private TextBox txtTotal;
        private TextBox txtGrandTotal;
        private Label label17;
        private Label label16;
        private Label label13;
        private ComboBox cmbBatchId;
        private CheckBox checkBoxWarranty;
        private TextBox txtSearch;
        private Label label18;
        private ContextMenuStrip contextMenuStripSale;
        private ToolStripMenuItem printReportToolStripMenuItem;
        private TextBox txtExpiryDate;
        private Label lblDefineInvoice;
        private Label lblInvoiceDateDefine;
        private Label lblInvoiceDate;
        private Label lblInvoice;
    }
}