namespace PharApp.Purchase
{
    partial class frmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            tabControlPurchase = new TabControl();
            tabPagePurchase = new TabPage();
            button2 = new Button();
            btnPurchase = new Button();
            groupBox2 = new GroupBox();
            dataGridViewPurchaseDetails = new DataGridView();
            purchaseDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnClearDetails = new Button();
            btnAddDetails = new Button();
            dateTimeMedExpiry = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            txtManfPrice = new TextBox();
            cmbManufacturer = new ComboBox();
            txtPurchaseQnt = new TextBox();
            txtDisc = new TextBox();
            txtGSTtx = new TextBox();
            txtBonus = new TextBox();
            cmbMedInformation = new ComboBox();
            txtStockQuantity = new TextBox();
            txtBatchId = new TextBox();
            label9 = new Label();
            label14 = new Label();
            label7 = new Label();
            label15 = new Label();
            label6 = new Label();
            label1 = new Label();
            label8 = new Label();
            label12 = new Label();
            cmbPaymentType = new ComboBox();
            txtInvoice = new TextBox();
            txtAdvTax = new TextBox();
            txtTotal = new TextBox();
            txtGrandTotal = new TextBox();
            txtDetail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label17 = new Label();
            label5 = new Label();
            label16 = new Label();
            label2 = new Label();
            label13 = new Label();
            tabPageViewPurchase = new TabPage();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            label18 = new Label();
            dataGridViewPurchase = new DataGridView();
            contextMenuStripPurchase = new ContextMenuStrip(components);
            printReportToolStripMenuItem = new ToolStripMenuItem();
            returnPurchaseToolStripMenuItem = new ToolStripMenuItem();
            tabControlPurchase.SuspendLayout();
            tabPagePurchase.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchaseDetails).BeginInit();
            groupBox1.SuspendLayout();
            tabPageViewPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).BeginInit();
            contextMenuStripPurchase.SuspendLayout();
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
            tabControlPurchase.Size = new Size(1110, 545);
            tabControlPurchase.TabIndex = 0;
            // 
            // tabPagePurchase
            // 
            tabPagePurchase.Controls.Add(button2);
            tabPagePurchase.Controls.Add(btnPurchase);
            tabPagePurchase.Controls.Add(groupBox2);
            tabPagePurchase.Controls.Add(purchaseDate);
            tabPagePurchase.Controls.Add(groupBox1);
            tabPagePurchase.Controls.Add(cmbPaymentType);
            tabPagePurchase.Controls.Add(txtInvoice);
            tabPagePurchase.Controls.Add(txtAdvTax);
            tabPagePurchase.Controls.Add(txtTotal);
            tabPagePurchase.Controls.Add(txtGrandTotal);
            tabPagePurchase.Controls.Add(txtDetail);
            tabPagePurchase.Controls.Add(label4);
            tabPagePurchase.Controls.Add(label3);
            tabPagePurchase.Controls.Add(label17);
            tabPagePurchase.Controls.Add(label5);
            tabPagePurchase.Controls.Add(label16);
            tabPagePurchase.Controls.Add(label2);
            tabPagePurchase.Controls.Add(label13);
            tabPagePurchase.Location = new Point(4, 24);
            tabPagePurchase.Margin = new Padding(3, 2, 3, 2);
            tabPagePurchase.Name = "tabPagePurchase";
            tabPagePurchase.Padding = new Padding(3, 2, 3, 2);
            tabPagePurchase.Size = new Size(1102, 517);
            tabPagePurchase.TabIndex = 0;
            tabPagePurchase.Text = "Purchase";
            tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(8, 487);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 17;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(993, 469);
            btnPurchase.Margin = new Padding(3, 2, 3, 2);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(102, 43);
            btnPurchase.TabIndex = 16;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(dataGridViewPurchaseDetails);
            groupBox2.Location = new Point(3, 204);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1093, 179);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "View Details";
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
            dataGridViewPurchaseDetails.Location = new Point(5, 16);
            dataGridViewPurchaseDetails.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPurchaseDetails.Name = "dataGridViewPurchaseDetails";
            dataGridViewPurchaseDetails.ReadOnly = true;
            dataGridViewPurchaseDetails.RowHeadersWidth = 51;
            dataGridViewPurchaseDetails.Size = new Size(1077, 155);
            dataGridViewPurchaseDetails.TabIndex = 0;
            dataGridViewPurchaseDetails.CellValueChanged += dataGridViewPurchaseDetails_CellValueChanged;
            dataGridViewPurchaseDetails.RowsAdded += dataGridViewPurchaseDetails_RowsAdded;
            dataGridViewPurchaseDetails.RowsRemoved += dataGridViewPurchaseDetails_RowsRemoved;
            dataGridViewPurchaseDetails.MouseClick += dataGridViewPurchaseDetails_MouseClick;
            // 
            // purchaseDate
            // 
            purchaseDate.CustomFormat = "yyyy-MM-dd";
            purchaseDate.Format = DateTimePickerFormat.Short;
            purchaseDate.Location = new Point(337, 40);
            purchaseDate.Margin = new Padding(3, 2, 3, 2);
            purchaseDate.Name = "purchaseDate";
            purchaseDate.Size = new Size(177, 23);
            purchaseDate.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClearDetails);
            groupBox1.Controls.Add(btnAddDetails);
            groupBox1.Controls.Add(dateTimeMedExpiry);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtManfPrice);
            groupBox1.Controls.Add(cmbManufacturer);
            groupBox1.Controls.Add(txtPurchaseQnt);
            groupBox1.Controls.Add(txtDisc);
            groupBox1.Controls.Add(txtGSTtx);
            groupBox1.Controls.Add(txtBonus);
            groupBox1.Controls.Add(cmbMedInformation);
            groupBox1.Controls.Add(txtStockQuantity);
            groupBox1.Controls.Add(txtBatchId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(8, 82);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1088, 118);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Purchase Details";
            // 
            // btnClearDetails
            // 
            btnClearDetails.Location = new Point(956, 80);
            btnClearDetails.Margin = new Padding(3, 2, 3, 2);
            btnClearDetails.Name = "btnClearDetails";
            btnClearDetails.Size = new Size(28, 22);
            btnClearDetails.TabIndex = 13;
            btnClearDetails.Text = "X";
            btnClearDetails.UseVisualStyleBackColor = true;
            btnClearDetails.Click += btnClearDetails_Click;
            // 
            // btnAddDetails
            // 
            btnAddDetails.Location = new Point(990, 63);
            btnAddDetails.Margin = new Padding(3, 2, 3, 2);
            btnAddDetails.Name = "btnAddDetails";
            btnAddDetails.Size = new Size(92, 49);
            btnAddDetails.TabIndex = 14;
            btnAddDetails.Text = "Add Med.";
            btnAddDetails.UseVisualStyleBackColor = true;
            btnAddDetails.Click += btnAddDetails_Click;
            // 
            // dateTimeMedExpiry
            // 
            dateTimeMedExpiry.Format = DateTimePickerFormat.Short;
            dateTimeMedExpiry.Location = new Point(276, 80);
            dateTimeMedExpiry.Margin = new Padding(3, 2, 3, 2);
            dateTimeMedExpiry.Name = "dateTimeMedExpiry";
            dateTimeMedExpiry.Size = new Size(118, 23);
            dateTimeMedExpiry.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(644, 63);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 0;
            label11.Text = "Manuf. Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(519, 65);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 0;
            label10.Text = "Quantity";
            // 
            // txtManfPrice
            // 
            txtManfPrice.Enabled = false;
            txtManfPrice.Location = new Point(644, 81);
            txtManfPrice.Margin = new Padding(3, 2, 3, 2);
            txtManfPrice.Name = "txtManfPrice";
            txtManfPrice.Size = new Size(130, 23);
            txtManfPrice.TabIndex = 10;
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(11, 36);
            cmbManufacturer.Margin = new Padding(3, 2, 3, 2);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(223, 23);
            cmbManufacturer.TabIndex = 4;
            cmbManufacturer.SelectedIndexChanged += cmbManufacturer_SelectedIndexChanged;
            // 
            // txtPurchaseQnt
            // 
            txtPurchaseQnt.Location = new Point(519, 81);
            txtPurchaseQnt.Margin = new Padding(3, 2, 3, 2);
            txtPurchaseQnt.Name = "txtPurchaseQnt";
            txtPurchaseQnt.Size = new Size(120, 23);
            txtPurchaseQnt.TabIndex = 8;
            txtPurchaseQnt.Click += txtPurchaseQnt_Click;
            txtPurchaseQnt.KeyPress += txtPurchaseQnt_KeyPress;
            // 
            // txtDisc
            // 
            txtDisc.Location = new Point(779, 81);
            txtDisc.Margin = new Padding(3, 2, 3, 2);
            txtDisc.Name = "txtDisc";
            txtDisc.Size = new Size(89, 23);
            txtDisc.TabIndex = 11;
            txtDisc.Click += txtDisc_Click;
            txtDisc.KeyPress += txtDisc_KeyPress;
            // 
            // txtGSTtx
            // 
            txtGSTtx.Location = new Point(872, 81);
            txtGSTtx.Margin = new Padding(3, 2, 3, 2);
            txtGSTtx.Name = "txtGSTtx";
            txtGSTtx.Size = new Size(79, 23);
            txtGSTtx.TabIndex = 12;
            txtGSTtx.Click += txtGSTtx_Click;
            txtGSTtx.KeyPress += txtGSTtx_KeyPress;
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(580, 37);
            txtBonus.Margin = new Padding(3, 2, 3, 2);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(79, 23);
            txtBonus.TabIndex = 9;
            txtBonus.Visible = false;
            txtBonus.Click += txtBonus_Click;
            txtBonus.KeyPress += txtBonus_KeyPress;
            // 
            // cmbMedInformation
            // 
            cmbMedInformation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedInformation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedInformation.FormattingEnabled = true;
            cmbMedInformation.Location = new Point(10, 81);
            cmbMedInformation.Margin = new Padding(3, 2, 3, 2);
            cmbMedInformation.Name = "cmbMedInformation";
            cmbMedInformation.Size = new Size(139, 23);
            cmbMedInformation.TabIndex = 5;
            cmbMedInformation.SelectedIndexChanged += cmbMedInformation_SelectedIndexChanged;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Enabled = false;
            txtStockQuantity.Location = new Point(398, 80);
            txtStockQuantity.Margin = new Padding(3, 2, 3, 2);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(116, 23);
            txtStockQuantity.TabIndex = 1;
            // 
            // txtBatchId
            // 
            txtBatchId.Location = new Point(154, 81);
            txtBatchId.Margin = new Padding(3, 2, 3, 2);
            txtBatchId.Name = "txtBatchId";
            txtBatchId.Size = new Size(117, 23);
            txtBatchId.TabIndex = 6;
            txtBatchId.Click += txtBatchId_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(398, 63);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 0;
            label9.Text = "Stock Quantity";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(872, 64);
            label14.Name = "label14";
            label14.Size = new Size(41, 15);
            label14.TabIndex = 0;
            label14.Text = "GST Tx";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 64);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 0;
            label7.Text = "Item Code";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(779, 64);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 0;
            label15.Text = "Dics%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 65);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Manufacturer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(580, 20);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 0;
            label8.Text = "Bonus";
            label8.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(276, 63);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 0;
            label12.Text = "Expiry Date";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(519, 42);
            cmbPaymentType.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(229, 23);
            cmbPaymentType.TabIndex = 2;
            // 
            // txtInvoice
            // 
            txtInvoice.Enabled = false;
            txtInvoice.Location = new Point(88, 40);
            txtInvoice.Margin = new Padding(3, 2, 3, 2);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(245, 23);
            txtInvoice.TabIndex = 1;
            // 
            // txtAdvTax
            // 
            txtAdvTax.Location = new Point(906, 415);
            txtAdvTax.Margin = new Padding(3, 2, 3, 2);
            txtAdvTax.Name = "txtAdvTax";
            txtAdvTax.Size = new Size(190, 23);
            txtAdvTax.TabIndex = 15;
            txtAdvTax.Click += txtAdvTax_Click;
            txtAdvTax.TextChanged += txtAdvDisc_TextChanged;
            txtAdvTax.KeyPress += txtAdvTax_KeyPress;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(906, 388);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(190, 23);
            txtTotal.TabIndex = 1;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(906, 442);
            txtGrandTotal.Margin = new Padding(3, 2, 3, 2);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(190, 23);
            txtGrandTotal.TabIndex = 1;
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(752, 43);
            txtDetail.Margin = new Padding(3, 2, 3, 2);
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(245, 23);
            txtDetail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 23);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Invoice No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 24);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 0;
            label3.Text = "Payment Type";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(843, 418);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 0;
            label17.Text = "Adv Tx.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(752, 27);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 0;
            label5.Text = "Details";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(864, 392);
            label16.Name = "label16";
            label16.Size = new Size(32, 15);
            label16.TabIndex = 0;
            label16.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 22);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Purchase Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(826, 444);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 0;
            label13.Text = "Grand Total";
            // 
            // tabPageViewPurchase
            // 
            tabPageViewPurchase.Controls.Add(btnRefresh);
            tabPageViewPurchase.Controls.Add(txtSearch);
            tabPageViewPurchase.Controls.Add(label18);
            tabPageViewPurchase.Controls.Add(dataGridViewPurchase);
            tabPageViewPurchase.Location = new Point(4, 24);
            tabPageViewPurchase.Margin = new Padding(3, 2, 3, 2);
            tabPageViewPurchase.Name = "tabPageViewPurchase";
            tabPageViewPurchase.Padding = new Padding(3, 2, 3, 2);
            tabPageViewPurchase.Size = new Size(1102, 517);
            tabPageViewPurchase.TabIndex = 1;
            tabPageViewPurchase.Text = "View Purchase";
            tabPageViewPurchase.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.Location = new Point(286, 12);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(30, 22);
            btnRefresh.TabIndex = 5;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 12);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(9, 14);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
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
            dataGridViewPurchase.Location = new Point(3, 46);
            dataGridViewPurchase.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPurchase.MultiSelect = false;
            dataGridViewPurchase.Name = "dataGridViewPurchase";
            dataGridViewPurchase.ReadOnly = true;
            dataGridViewPurchase.RowHeadersWidth = 51;
            dataGridViewPurchase.Size = new Size(1096, 463);
            dataGridViewPurchase.TabIndex = 0;
            dataGridViewPurchase.MouseClick += dataGridViewPurchase_MouseClick;
            // 
            // contextMenuStripPurchase
            // 
            contextMenuStripPurchase.ImageScalingSize = new Size(20, 20);
            contextMenuStripPurchase.Items.AddRange(new ToolStripItem[] { printReportToolStripMenuItem, returnPurchaseToolStripMenuItem });
            contextMenuStripPurchase.Name = "contextMenuStripPurchase";
            contextMenuStripPurchase.Size = new Size(161, 48);
            // 
            // printReportToolStripMenuItem
            // 
            printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            printReportToolStripMenuItem.Size = new Size(160, 22);
            printReportToolStripMenuItem.Text = "Print Report";
            printReportToolStripMenuItem.Click += printReportToolStripMenuItem_Click;
            // 
            // returnPurchaseToolStripMenuItem
            // 
            returnPurchaseToolStripMenuItem.Name = "returnPurchaseToolStripMenuItem";
            returnPurchaseToolStripMenuItem.Size = new Size(160, 22);
            returnPurchaseToolStripMenuItem.Text = "Return Purchase";
            returnPurchaseToolStripMenuItem.Click += returnPurchaseToolStripMenuItem_Click;
            // 
            // frmPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 562);
            Controls.Add(tabControlPurchase);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPurchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase System";
            Load += frmPurchase_Load;
            tabControlPurchase.ResumeLayout(false);
            tabPagePurchase.ResumeLayout(false);
            tabPagePurchase.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchaseDetails).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ToolStripMenuItem returnPurchaseToolStripMenuItem;
        private Button btnRefresh;
    }
}