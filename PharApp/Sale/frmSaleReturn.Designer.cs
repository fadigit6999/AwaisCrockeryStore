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
            tabControlPurchase.Location = new Point(10, 9);
            tabControlPurchase.Margin = new Padding(3, 2, 3, 2);
            tabControlPurchase.Name = "tabControlPurchase";
            tabControlPurchase.SelectedIndex = 0;
            tabControlPurchase.Size = new Size(1110, 570);
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
            tabPagePurchase.Location = new Point(4, 24);
            tabPagePurchase.Margin = new Padding(3, 2, 3, 2);
            tabPagePurchase.Name = "tabPagePurchase";
            tabPagePurchase.Padding = new Padding(3, 2, 3, 2);
            tabPagePurchase.Size = new Size(1102, 542);
            tabPagePurchase.TabIndex = 0;
            tabPagePurchase.Text = "Sale";
            tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // lblDefineInvoice
            // 
            lblDefineInvoice.AutoSize = true;
            lblDefineInvoice.Location = new Point(85, 14);
            lblDefineInvoice.Name = "lblDefineInvoice";
            lblDefineInvoice.Size = new Size(0, 15);
            lblDefineInvoice.TabIndex = 47;
            // 
            // lblInvoiceDateDefine
            // 
            lblInvoiceDateDefine.AutoSize = true;
            lblInvoiceDateDefine.Location = new Point(277, 14);
            lblInvoiceDateDefine.Name = "lblInvoiceDateDefine";
            lblInvoiceDateDefine.Size = new Size(0, 15);
            lblInvoiceDateDefine.TabIndex = 48;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(192, 14);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(72, 15);
            lblInvoiceDate.TabIndex = 49;
            lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.Location = new Point(10, 14);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(64, 15);
            lblInvoice.TabIndex = 50;
            lblInvoice.Text = "Invoice No";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(dataGridViewSaleDetails);
            groupBox2.Location = new Point(5, 40);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1089, 445);
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
            dataGridViewSaleDetails.Location = new Point(12, 20);
            dataGridViewSaleDetails.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSaleDetails.Name = "dataGridViewSaleDetails";
            dataGridViewSaleDetails.ReadOnly = true;
            dataGridViewSaleDetails.RowHeadersWidth = 51;
            dataGridViewSaleDetails.Size = new Size(1072, 421);
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
            groupBox1.Location = new Point(42, 506);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(117, 26);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sale Details";
            groupBox1.Visible = false;
            // 
            // checkBoxWarranty
            // 
            checkBoxWarranty.AutoSize = true;
            checkBoxWarranty.Location = new Point(65, 136);
            checkBoxWarranty.Margin = new Padding(3, 2, 3, 2);
            checkBoxWarranty.Name = "checkBoxWarranty";
            checkBoxWarranty.Size = new Size(197, 19);
            checkBoxWarranty.TabIndex = 12;
            checkBoxWarranty.Text = "Estimated Invoice (No Warranty)";
            checkBoxWarranty.UseVisualStyleBackColor = true;
            // 
            // dateTimeMedExpiry
            // 
            dateTimeMedExpiry.Format = DateTimePickerFormat.Short;
            dateTimeMedExpiry.Location = new Point(256, 97);
            dateTimeMedExpiry.Margin = new Padding(3, 2, 3, 2);
            dateTimeMedExpiry.Name = "dateTimeMedExpiry";
            dateTimeMedExpiry.Size = new Size(126, 23);
            dateTimeMedExpiry.TabIndex = 3;
            dateTimeMedExpiry.Visible = false;
            // 
            // txtExpiryDate
            // 
            txtExpiryDate.Location = new Point(256, 34);
            txtExpiryDate.Margin = new Padding(3, 2, 3, 2);
            txtExpiryDate.Name = "txtExpiryDate";
            txtExpiryDate.ReadOnly = true;
            txtExpiryDate.Size = new Size(126, 23);
            txtExpiryDate.TabIndex = 11;
            // 
            // saleDate
            // 
            saleDate.CustomFormat = "yyyy-MM-dd";
            saleDate.Format = DateTimePickerFormat.Short;
            saleDate.Location = new Point(256, 65);
            saleDate.Margin = new Padding(3, 2, 3, 2);
            saleDate.Name = "saleDate";
            saleDate.Size = new Size(199, 23);
            saleDate.TabIndex = 45;
            // 
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(952, 33);
            btnClearDetails.Margin = new Padding(3, 2, 3, 2);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(28, 22);
            btnClearDetails.TabIndex = 9;
            btnClearDetails.Text = "X";
            btnClearDetails.UseVisualStyleBackColor = true;
            btnClearDetails.Click += btnClearDetails_Click;
            // 
            // btnAddDetails
            // 
            btnAddDetails.Location = new Point(985, 16);
            btnAddDetails.Margin = new Padding(3, 2, 3, 2);
            btnAddDetails.Name = "btnAddDetails";
            btnAddDetails.Size = new Size(92, 49);
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
            cmbPaymentType.Location = new Point(628, 64);
            cmbPaymentType.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(181, 23);
            cmbPaymentType.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(673, 16);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 0;
            label11.Text = "Sale Price";
            // 
            // cmbCustomer
            // 
            cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(460, 64);
            cmbCustomer.Margin = new Padding(3, 2, 3, 2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(162, 23);
            cmbCustomer.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(500, 16);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 0;
            label10.Text = "Quantity";
            // 
            // txtInvoice
            // 
            txtInvoice.Enabled = false;
            txtInvoice.Location = new Point(71, 67);
            txtInvoice.Margin = new Padding(3, 2, 3, 2);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(181, 23);
            txtInvoice.TabIndex = 40;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(814, 64);
            txtDetail.Margin = new Padding(3, 2, 3, 2);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(181, 23);
            txtDetail.TabIndex = 41;
            // 
            // txtManfPrice
            // 
            txtManfPrice.Enabled = false;
            txtManfPrice.Location = new Point(673, 34);
            txtManfPrice.Margin = new Padding(3, 2, 3, 2);
            txtManfPrice.Name = "txtManfPrice";
            txtManfPrice.Size = new Size(97, 23);
            txtManfPrice.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 50);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 35;
            label4.Text = "Sale Invoice No.";
            // 
            // txtSaleQnt
            // 
            txtSaleQnt.Location = new Point(500, 34);
            txtSaleQnt.Margin = new Padding(3, 2, 3, 2);
            txtSaleQnt.Name = "txtSaleQnt";
            txtSaleQnt.Size = new Size(84, 23);
            txtSaleQnt.TabIndex = 4;
            txtSaleQnt.Click += txtSaleQnt_Click;
            txtSaleQnt.KeyPress += txtSaleQnt_KeyPress;
            txtSaleQnt.KeyUp += txtPurchaseQnt_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 45);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 36;
            label3.Text = "Payment Type";
            // 
            // txtDisc
            // 
            txtDisc.Location = new Point(774, 34);
            txtDisc.Margin = new Padding(3, 2, 3, 2);
            txtDisc.Name = "txtDisc";
            txtDisc.Size = new Size(89, 23);
            txtDisc.TabIndex = 7;
            txtDisc.Click += txtDisc_Click;
            txtDisc.KeyPress += txtDisc_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(814, 49);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 37;
            label5.Text = "Details";
            // 
            // txtGSTtx
            // 
            txtGSTtx.Location = new Point(868, 34);
            txtGSTtx.Margin = new Padding(3, 2, 3, 2);
            txtGSTtx.Name = "txtGSTtx";
            txtGSTtx.Size = new Size(79, 23);
            txtGSTtx.TabIndex = 8;
            txtGSTtx.Click += txtGSTtx_Click;
            txtGSTtx.KeyPress += txtGSTtx_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 48);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 38;
            label2.Text = "Sale Date";
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(589, 34);
            txtBonus.Margin = new Padding(3, 2, 3, 2);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(79, 23);
            txtBonus.TabIndex = 5;
            txtBonus.Click += txtBonus_Click;
            txtBonus.KeyPress += txtBonus_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 47);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 39;
            label1.Text = "Customer";
            label1.Click += label1_Click;
            // 
            // cmbBatchId
            // 
            cmbBatchId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBatchId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBatchId.FormattingEnabled = true;
            cmbBatchId.Location = new Point(150, 34);
            cmbBatchId.Margin = new Padding(3, 2, 3, 2);
            cmbBatchId.Name = "cmbBatchId";
            cmbBatchId.Size = new Size(102, 23);
            cmbBatchId.TabIndex = 2;
            cmbBatchId.SelectedIndexChanged += cmbBatchId_SelectedIndexChanged;
            // 
            // cmbMedInformation
            // 
            cmbMedInformation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedInformation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedInformation.FormattingEnabled = true;
            cmbMedInformation.Location = new Point(6, 34);
            cmbMedInformation.Margin = new Padding(3, 2, 3, 2);
            cmbMedInformation.Name = "cmbMedInformation";
            cmbMedInformation.Size = new Size(139, 23);
            cmbMedInformation.TabIndex = 1;
            cmbMedInformation.SelectedIndexChanged += cmbMedInformation_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(128, 150);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(172, 27);
            button2.TabIndex = 14;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Enabled = false;
            txtStockQuantity.Location = new Point(387, 33);
            txtStockQuantity.Margin = new Padding(3, 2, 3, 2);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(103, 23);
            txtStockQuantity.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(387, 15);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 0;
            label9.Text = "Stock Quantity";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(868, 16);
            label14.Name = "label14";
            label14.Size = new Size(41, 15);
            label14.TabIndex = 0;
            label14.Text = "GST Tx";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 16);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 0;
            label7.Text = "Bartch Id";
            // 
            // txtAdvTax
            // 
            txtAdvTax.Location = new Point(93, 86);
            txtAdvTax.Margin = new Padding(3, 2, 3, 2);
            txtAdvTax.Name = "txtAdvTax";
            txtAdvTax.Size = new Size(187, 23);
            txtAdvTax.TabIndex = 11;
            txtAdvTax.Click += txtAdvTax_Click;
            txtAdvTax.TextChanged += txtAdvDisc_TextChanged;
            txtAdvTax.KeyPress += txtAdvTax_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(774, 16);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 0;
            label15.Text = "Dics%";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(93, 58);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(187, 23);
            txtTotal.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 18);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 0;
            label6.Text = "Med. Information";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(93, 111);
            txtGrandTotal.Margin = new Padding(3, 2, 3, 2);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(187, 23);
            txtGrandTotal.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(29, 89);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 27;
            label17.Text = "Adv Tx.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(589, 16);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 0;
            label8.Text = "Bonus";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(51, 64);
            label16.Name = "label16";
            label16.Size = new Size(32, 15);
            label16.TabIndex = 28;
            label16.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(256, 15);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 0;
            label12.Text = "Expiry Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 113);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 29;
            label13.Text = "Grand Total";
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(961, 490);
            btnPurchase.Margin = new Padding(3, 2, 3, 2);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(134, 46);
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
            tabPageViewPurchase.Location = new Point(4, 24);
            tabPageViewPurchase.Margin = new Padding(3, 2, 3, 2);
            tabPageViewPurchase.Name = "tabPageViewPurchase";
            tabPageViewPurchase.Padding = new Padding(3, 2, 3, 2);
            tabPageViewPurchase.Size = new Size(1102, 542);
            tabPageViewPurchase.TabIndex = 1;
            tabPageViewPurchase.Text = "View Sale Return";
            tabPageViewPurchase.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(59, 16);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(7, 18);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
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
            dataGridViewSale.Location = new Point(3, 47);
            dataGridViewSale.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSale.Name = "dataGridViewSale";
            dataGridViewSale.ReadOnly = true;
            dataGridViewSale.RowHeadersWidth = 51;
            dataGridViewSale.Size = new Size(1096, 496);
            dataGridViewSale.TabIndex = 0;
            dataGridViewSale.MouseClick += dataGridViewSale_MouseClick;
            // 
            // contextMenuStripSale
            // 
            contextMenuStripSale.ImageScalingSize = new Size(20, 20);
            contextMenuStripSale.Items.AddRange(new ToolStripItem[] { printReportToolStripMenuItem });
            contextMenuStripSale.Name = "contextMenuStripSale";
            contextMenuStripSale.Size = new Size(138, 26);
            // 
            // printReportToolStripMenuItem
            // 
            printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            printReportToolStripMenuItem.Size = new Size(137, 22);
            printReportToolStripMenuItem.Text = "Print Report";
            printReportToolStripMenuItem.Click += printReportToolStripMenuItem_Click;
            // 
            // frmSaleReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 584);
            Controls.Add(tabControlPurchase);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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