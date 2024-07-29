namespace PharApp.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            registerCustomerToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            medicineToolStripMedicine = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            manufacturersToolStripMenuItem = new ToolStripMenuItem();
            procurementToolStripMenuItem = new ToolStripMenuItem();
            procurementReturnToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            registerSaleToolStripMenuItem = new ToolStripMenuItem();
            saleReturnToolStripMenuItem = new ToolStripMenuItem();
            auditToolStripMenuItem = new ToolStripMenuItem();
            auditReportToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            backupRestoreToolStripMenuItem = new ToolStripMenuItem();
            manualBackupToolStripMenuItem = new ToolStripMenuItem();
            databaseConfigurationToolStripMenuItem = new ToolStripMenuItem();
            databaseConfigToolStripMenuItem = new ToolStripMenuItem();
            companyToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            calculatorToolStripMenuItem = new ToolStripMenuItem();
            notePadToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatuslblVersion = new ToolStripStatusLabel();
            toolStripStatusLabelLoginUser = new ToolStripStatusLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBoxCustomer = new PictureBox();
            pictureBoxManufacturer = new PictureBox();
            pictureBoxInventory = new PictureBox();
            pictureBoxPurchase = new PictureBox();
            pictureBoxSale = new PictureBox();
            pictureBoxStock = new PictureBox();
            pictureBoxExpiry = new PictureBox();
            pictureBoxExpiryAlert = new PictureBox();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            lblManufacturer = new Label();
            lblExpiry = new Label();
            lblstock = new Label();
            lblTotalSale = new Label();
            lblTotalPurchase = new Label();
            lblTotalCustomer = new Label();
            lblTotalInventory = new Label();
            timerMain = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxManufacturer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpiry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpiryAlert).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.White;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, customersToolStripMenuItem, inventoryToolStripMenuItem, purchaseToolStripMenuItem, salesToolStripMenuItem, auditToolStripMenuItem, usersToolStripMenuItem, backupRestoreToolStripMenuItem, databaseConfigurationToolStripMenuItem, toolsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(1071, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "Customers";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerCustomerToolStripMenuItem });
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(76, 20);
            customersToolStripMenuItem.Text = "&Customers";
            // 
            // registerCustomerToolStripMenuItem
            // 
            registerCustomerToolStripMenuItem.Name = "registerCustomerToolStripMenuItem";
            registerCustomerToolStripMenuItem.Size = new Size(171, 22);
            registerCustomerToolStripMenuItem.Text = "Register Customer";
            registerCustomerToolStripMenuItem.Click += registerCustomerToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicineToolStripMedicine, stockToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "&Inventory";
            // 
            // medicineToolStripMedicine
            // 
            medicineToolStripMedicine.Name = "medicineToolStripMedicine";
            medicineToolStripMedicine.Size = new Size(151, 22);
            medicineToolStripMedicine.Text = "Item Inventory";
            medicineToolStripMedicine.Click += medicineToolStripMedicine_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(151, 22);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manufacturersToolStripMenuItem, procurementToolStripMenuItem, procurementReturnToolStripMenuItem });
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(67, 20);
            purchaseToolStripMenuItem.Text = "&Purchase";
            // 
            // manufacturersToolStripMenuItem
            // 
            manufacturersToolStripMenuItem.Name = "manufacturersToolStripMenuItem";
            manufacturersToolStripMenuItem.Size = new Size(181, 22);
            manufacturersToolStripMenuItem.Text = "Manufacturer";
            manufacturersToolStripMenuItem.Click += manufacturersToolStripMenuItem_Click;
            // 
            // procurementToolStripMenuItem
            // 
            procurementToolStripMenuItem.Name = "procurementToolStripMenuItem";
            procurementToolStripMenuItem.Size = new Size(181, 22);
            procurementToolStripMenuItem.Text = "Procurement";
            procurementToolStripMenuItem.Click += procurementToolStripMenuItem_Click;
            // 
            // procurementReturnToolStripMenuItem
            // 
            procurementReturnToolStripMenuItem.Name = "procurementReturnToolStripMenuItem";
            procurementReturnToolStripMenuItem.Size = new Size(181, 22);
            procurementReturnToolStripMenuItem.Text = "Procurement Return";
            procurementReturnToolStripMenuItem.Click += procurementReturnToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerSaleToolStripMenuItem, saleReturnToolStripMenuItem });
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(45, 20);
            salesToolStripMenuItem.Text = "&Sales";
            // 
            // registerSaleToolStripMenuItem
            // 
            registerSaleToolStripMenuItem.Name = "registerSaleToolStripMenuItem";
            registerSaleToolStripMenuItem.Size = new Size(140, 22);
            registerSaleToolStripMenuItem.Text = "Register Sale";
            registerSaleToolStripMenuItem.Click += registerSaleToolStripMenuItem_Click;
            // 
            // saleReturnToolStripMenuItem
            // 
            saleReturnToolStripMenuItem.Name = "saleReturnToolStripMenuItem";
            saleReturnToolStripMenuItem.Size = new Size(140, 22);
            saleReturnToolStripMenuItem.Text = "Sale Return";
            saleReturnToolStripMenuItem.Click += saleReturnToolStripMenuItem_Click;
            // 
            // auditToolStripMenuItem
            // 
            auditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { auditReportToolStripMenuItem });
            auditToolStripMenuItem.Name = "auditToolStripMenuItem";
            auditToolStripMenuItem.Size = new Size(48, 20);
            auditToolStripMenuItem.Text = "&Audit";
            // 
            // auditReportToolStripMenuItem
            // 
            auditReportToolStripMenuItem.Name = "auditReportToolStripMenuItem";
            auditReportToolStripMenuItem.Size = new Size(141, 22);
            auditReportToolStripMenuItem.Text = "Audit Report";
            auditReportToolStripMenuItem.Click += auditReportToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageUsersToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(47, 20);
            usersToolStripMenuItem.Text = "&Users";
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(148, 22);
            manageUsersToolStripMenuItem.Text = "Manage Users";
            manageUsersToolStripMenuItem.Click += manageUsersToolStripMenuItem_Click;
            // 
            // backupRestoreToolStripMenuItem
            // 
            backupRestoreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualBackupToolStripMenuItem });
            backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            backupRestoreToolStripMenuItem.Size = new Size(58, 20);
            backupRestoreToolStripMenuItem.Text = "&Backup";
            // 
            // manualBackupToolStripMenuItem
            // 
            manualBackupToolStripMenuItem.Name = "manualBackupToolStripMenuItem";
            manualBackupToolStripMenuItem.Size = new Size(164, 22);
            manualBackupToolStripMenuItem.Text = "Database Backup";
            manualBackupToolStripMenuItem.Click += manualBackupToolStripMenuItem_Click;
            // 
            // databaseConfigurationToolStripMenuItem
            // 
            databaseConfigurationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { databaseConfigToolStripMenuItem, companyToolStripMenuItem, paymentToolStripMenuItem });
            databaseConfigurationToolStripMenuItem.Name = "databaseConfigurationToolStripMenuItem";
            databaseConfigurationToolStripMenuItem.Size = new Size(61, 20);
            databaseConfigurationToolStripMenuItem.Text = "&Settings";
            // 
            // databaseConfigToolStripMenuItem
            // 
            databaseConfigToolStripMenuItem.Name = "databaseConfigToolStripMenuItem";
            databaseConfigToolStripMenuItem.Size = new Size(161, 22);
            databaseConfigToolStripMenuItem.Text = "Database Config";
            databaseConfigToolStripMenuItem.Click += databaseConfigToolStripMenuItem_Click;
            // 
            // companyToolStripMenuItem
            // 
            companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            companyToolStripMenuItem.Size = new Size(161, 22);
            companyToolStripMenuItem.Text = "Company";
            companyToolStripMenuItem.Click += companyToolStripMenuItem_Click;
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(161, 22);
            paymentToolStripMenuItem.Text = "Payment";
            paymentToolStripMenuItem.Click += paymentToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculatorToolStripMenuItem, notePadToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            calculatorToolStripMenuItem.Size = new Size(128, 22);
            calculatorToolStripMenuItem.Text = "Calculator";
            calculatorToolStripMenuItem.Click += calculatorToolStripMenuItem_Click;
            // 
            // notePadToolStripMenuItem
            // 
            notePadToolStripMenuItem.Name = "notePadToolStripMenuItem";
            notePadToolStripMenuItem.Size = new Size(128, 22);
            notePadToolStripMenuItem.Text = "Note Pad";
            notePadToolStripMenuItem.Click += notePadToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatuslblVersion, toolStripStatusLabelLoginUser });
            statusStrip1.Location = new Point(0, 540);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1071, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatuslblVersion
            // 
            toolStripStatuslblVersion.Name = "toolStripStatuslblVersion";
            toolStripStatuslblVersion.Size = new Size(0, 17);
            // 
            // toolStripStatusLabelLoginUser
            // 
            toolStripStatusLabelLoginUser.Name = "toolStripStatusLabelLoginUser";
            toolStripStatusLabelLoginUser.Size = new Size(118, 17);
            toolStripStatusLabelLoginUser.Text = "toolStripStatusLabel1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(pictureBoxCustomer);
            flowLayoutPanel1.Controls.Add(pictureBoxManufacturer);
            flowLayoutPanel1.Controls.Add(pictureBoxInventory);
            flowLayoutPanel1.Controls.Add(pictureBoxPurchase);
            flowLayoutPanel1.Controls.Add(pictureBoxSale);
            flowLayoutPanel1.Controls.Add(pictureBoxStock);
            flowLayoutPanel1.Controls.Add(pictureBoxExpiry);
            flowLayoutPanel1.Controls.Add(pictureBoxExpiryAlert);
            flowLayoutPanel1.Location = new Point(80, 23);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(881, 118);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBoxCustomer
            // 
            pictureBoxCustomer.Image = (Image)resources.GetObject("pictureBoxCustomer.Image");
            pictureBoxCustomer.Location = new Point(3, 2);
            pictureBoxCustomer.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCustomer.Name = "pictureBoxCustomer";
            pictureBoxCustomer.Size = new Size(119, 116);
            pictureBoxCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCustomer.TabIndex = 0;
            pictureBoxCustomer.TabStop = false;
            toolTip1.SetToolTip(pictureBoxCustomer, "Customer\r\n CTRL + C");
            pictureBoxCustomer.Click += pictureBoxCustomer_Click;
            // 
            // pictureBoxManufacturer
            // 
            pictureBoxManufacturer.Image = (Image)resources.GetObject("pictureBoxManufacturer.Image");
            pictureBoxManufacturer.Location = new Point(128, 2);
            pictureBoxManufacturer.Margin = new Padding(3, 2, 3, 2);
            pictureBoxManufacturer.Name = "pictureBoxManufacturer";
            pictureBoxManufacturer.Size = new Size(125, 113);
            pictureBoxManufacturer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxManufacturer.TabIndex = 0;
            pictureBoxManufacturer.TabStop = false;
            toolTip1.SetToolTip(pictureBoxManufacturer, "Manufacturer CTRL + M");
            pictureBoxManufacturer.Click += pictureBoxManufacturer_Click;
            // 
            // pictureBoxInventory
            // 
            pictureBoxInventory.Image = (Image)resources.GetObject("pictureBoxInventory.Image");
            pictureBoxInventory.Location = new Point(259, 2);
            pictureBoxInventory.Margin = new Padding(3, 2, 3, 2);
            pictureBoxInventory.Name = "pictureBoxInventory";
            pictureBoxInventory.Size = new Size(119, 112);
            pictureBoxInventory.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInventory.TabIndex = 0;
            pictureBoxInventory.TabStop = false;
            toolTip1.SetToolTip(pictureBoxInventory, "Inventory CTRL + I");
            pictureBoxInventory.Click += pictureBoxInventory_Click;
            // 
            // pictureBoxPurchase
            // 
            pictureBoxPurchase.Image = (Image)resources.GetObject("pictureBoxPurchase.Image");
            pictureBoxPurchase.Location = new Point(384, 2);
            pictureBoxPurchase.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPurchase.Name = "pictureBoxPurchase";
            pictureBoxPurchase.Size = new Size(119, 112);
            pictureBoxPurchase.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPurchase.TabIndex = 0;
            pictureBoxPurchase.TabStop = false;
            toolTip1.SetToolTip(pictureBoxPurchase, "Purchase CTRL + P");
            pictureBoxPurchase.Click += pictureBoxPurchase_Click;
            // 
            // pictureBoxSale
            // 
            pictureBoxSale.Image = (Image)resources.GetObject("pictureBoxSale.Image");
            pictureBoxSale.Location = new Point(509, 2);
            pictureBoxSale.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSale.Name = "pictureBoxSale";
            pictureBoxSale.Size = new Size(119, 112);
            pictureBoxSale.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSale.TabIndex = 0;
            pictureBoxSale.TabStop = false;
            toolTip1.SetToolTip(pictureBoxSale, "Sale CTRL + S");
            pictureBoxSale.Click += pictureBoxSale_Click;
            // 
            // pictureBoxStock
            // 
            pictureBoxStock.Image = (Image)resources.GetObject("pictureBoxStock.Image");
            pictureBoxStock.Location = new Point(634, 2);
            pictureBoxStock.Margin = new Padding(3, 2, 3, 2);
            pictureBoxStock.Name = "pictureBoxStock";
            pictureBoxStock.Size = new Size(119, 112);
            pictureBoxStock.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStock.TabIndex = 0;
            pictureBoxStock.TabStop = false;
            toolTip1.SetToolTip(pictureBoxStock, "Stock");
            pictureBoxStock.Click += pictureBoxStock_Click;
            // 
            // pictureBoxExpiry
            // 
            pictureBoxExpiry.Image = (Image)resources.GetObject("pictureBoxExpiry.Image");
            pictureBoxExpiry.Location = new Point(759, 2);
            pictureBoxExpiry.Margin = new Padding(3, 2, 3, 2);
            pictureBoxExpiry.Name = "pictureBoxExpiry";
            pictureBoxExpiry.Size = new Size(119, 112);
            pictureBoxExpiry.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExpiry.TabIndex = 2;
            pictureBoxExpiry.TabStop = false;
            toolTip1.SetToolTip(pictureBoxExpiry, "Stock");
            pictureBoxExpiry.Click += pictureBoxExpiry_Click;
            // 
            // pictureBoxExpiryAlert
            // 
            pictureBoxExpiryAlert.Image = (Image)resources.GetObject("pictureBoxExpiryAlert.Image");
            pictureBoxExpiryAlert.Location = new Point(3, 122);
            pictureBoxExpiryAlert.Margin = new Padding(3, 2, 3, 2);
            pictureBoxExpiryAlert.Name = "pictureBoxExpiryAlert";
            pictureBoxExpiryAlert.Size = new Size(119, 112);
            pictureBoxExpiryAlert.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExpiryAlert.TabIndex = 1;
            pictureBoxExpiryAlert.TabStop = false;
            toolTip1.SetToolTip(pictureBoxExpiryAlert, "Expiry Stock");
            pictureBoxExpiryAlert.Click += pictureBoxExpiryAlert_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.140892F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.859108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.Controls.Add(lblManufacturer, 0, 0);
            tableLayoutPanel1.Controls.Add(lblExpiry, 5, 0);
            tableLayoutPanel1.Controls.Add(lblstock, 4, 0);
            tableLayoutPanel1.Controls.Add(lblTotalSale, 3, 0);
            tableLayoutPanel1.Controls.Add(lblTotalPurchase, 2, 0);
            tableLayoutPanel1.Controls.Add(lblTotalCustomer, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTotalInventory, 1, 0);
            tableLayoutPanel1.Location = new Point(80, 140);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(881, 26);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lblManufacturer
            // 
            lblManufacturer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblManufacturer.AutoSize = true;
            lblManufacturer.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblManufacturer.Location = new Point(128, 0);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(123, 26);
            lblManufacturer.TabIndex = 5;
            lblManufacturer.Text = "Manufacturer";
            lblManufacturer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExpiry
            // 
            lblExpiry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblExpiry.Location = new Point(753, 0);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(125, 26);
            lblExpiry.TabIndex = 4;
            lblExpiry.Text = "Expiry";
            lblExpiry.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblstock
            // 
            lblstock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblstock.AutoSize = true;
            lblstock.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblstock.Location = new Point(630, 0);
            lblstock.Name = "lblstock";
            lblstock.Size = new Size(117, 26);
            lblstock.TabIndex = 4;
            lblstock.Text = "Stock";
            lblstock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSale
            // 
            lblTotalSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalSale.AutoSize = true;
            lblTotalSale.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblTotalSale.Location = new Point(504, 0);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(120, 26);
            lblTotalSale.TabIndex = 4;
            lblTotalSale.Text = "Sale";
            lblTotalSale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPurchase
            // 
            lblTotalPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalPurchase.AutoSize = true;
            lblTotalPurchase.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblTotalPurchase.Location = new Point(382, 0);
            lblTotalPurchase.Name = "lblTotalPurchase";
            lblTotalPurchase.Size = new Size(116, 26);
            lblTotalPurchase.TabIndex = 4;
            lblTotalPurchase.Text = "Purchase";
            lblTotalPurchase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalCustomer.AutoSize = true;
            lblTotalCustomer.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblTotalCustomer.Location = new Point(3, 0);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(119, 26);
            lblTotalCustomer.TabIndex = 4;
            lblTotalCustomer.Text = "Customer";
            lblTotalCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalInventory
            // 
            lblTotalInventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalInventory.AutoSize = true;
            lblTotalInventory.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lblTotalInventory.Location = new Point(257, 0);
            lblTotalInventory.Name = "lblTotalInventory";
            lblTotalInventory.Size = new Size(119, 26);
            lblTotalInventory.TabIndex = 4;
            lblTotalInventory.Text = "Inventory";
            lblTotalInventory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerMain
            // 
            timerMain.Interval = 1000;
            timerMain.Tick += timerMain_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1071, 562);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Awais Plastic Store";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            KeyDown += frmMain_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxManufacturer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpiry).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpiryAlert).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem auditToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem backupRestoreToolStripMenuItem;
        private ToolStripMenuItem databaseConfigurationToolStripMenuItem;
        private ToolStripMenuItem databaseConfigToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatuslblVersion;
        private ToolStripMenuItem medicineToolStripMedicine;
        private ToolStripMenuItem manufacturersToolStripMenuItem;
        private ToolStripMenuItem procurementToolStripMenuItem;
        private ToolStripMenuItem companyToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ToolStripMenuItem registerCustomerToolStripMenuItem;
        private ToolStripMenuItem registerSaleToolStripMenuItem;
        private ToolStripMenuItem auditReportToolStripMenuItem;
        private ToolStripMenuItem procurementReturnToolStripMenuItem;
        private ToolStripMenuItem saleReturnToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBoxCustomer;
        private PictureBox pictureBoxManufacturer;
        private PictureBox pictureBoxPurchase;
        private PictureBox pictureBoxSale;
        private PictureBox pictureBoxStock;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblExpiry;
        private Label lblstock;
        private Label lblTotalSale;
        private Label lblTotalPurchase;
        private Label lblTotalCustomer;
        private Label lblTotalInventory;
        private PictureBox pictureBoxExpiryAlert;
        private Label lblManufacturer;
        private ToolStripMenuItem manualBackupToolStripMenuItem;
        private PictureBox pictureBoxInventory;
        private PictureBox pictureBoxExpiry;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        private ToolStripMenuItem notePadToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabelLoginUser;
        private System.Windows.Forms.Timer timerMain;
    }
}