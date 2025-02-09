﻿namespace PharApp.Customer
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            dataGridViewCustomer = new DataGridView();
            contextMenuStripCustomer = new ContextMenuStrip(components);
            updateCustomerToolStripMenuItem = new ToolStripMenuItem();
            deleteCustomerToolStripMenuItem = new ToolStripMenuItem();
            btnRegister = new Button();
            txtSearch = new TextBox();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            contextMenuStripCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCustomer.BackgroundColor = Color.White;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.ContextMenuStrip = contextMenuStripCustomer;
            dataGridViewCustomer.Location = new Point(4, 37);
            dataGridViewCustomer.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomer.RowHeadersWidth = 51;
            dataGridViewCustomer.Size = new Size(691, 298);
            dataGridViewCustomer.TabIndex = 0;
            dataGridViewCustomer.MouseClick += dataGridViewCustomer_MouseClick;
            // 
            // contextMenuStripCustomer
            // 
            contextMenuStripCustomer.ImageScalingSize = new Size(20, 20);
            contextMenuStripCustomer.Items.AddRange(new ToolStripItem[] { updateCustomerToolStripMenuItem, deleteCustomerToolStripMenuItem });
            contextMenuStripCustomer.Name = "contextMenuStripCustomer";
            contextMenuStripCustomer.Size = new Size(168, 48);
            // 
            // updateCustomerToolStripMenuItem
            // 
            updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            updateCustomerToolStripMenuItem.Size = new Size(167, 22);
            updateCustomerToolStripMenuItem.Text = "Update Customer";
            updateCustomerToolStripMenuItem.Click += updateCustomerToolStripMenuItem_Click;
            // 
            // deleteCustomerToolStripMenuItem
            // 
            deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            deleteCustomerToolStripMenuItem.Size = new Size(167, 22);
            deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            deleteCustomerToolStripMenuItem.Click += deleteCustomerToolStripMenuItem_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(6, 9);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(470, 8);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 23);
            txtSearch.TabIndex = 6;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Calibri", 12F);
            label18.Location = new Point(412, 10);
            label18.Name = "label18";
            label18.Size = new Size(56, 19);
            label18.TabIndex = 5;
            label18.Text = "&Search:";
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtSearch);
            Controls.Add(label18);
            Controls.Add(btnRegister);
            Controls.Add(dataGridViewCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += frmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            contextMenuStripCustomer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewCustomer;
        private Button btnRegister;
        private ContextMenuStrip contextMenuStripCustomer;
        private ToolStripMenuItem updateCustomerToolStripMenuItem;
        private ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private TextBox txtSearch;
        private Label label18;
    }
}