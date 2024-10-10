using Microsoft.Reporting.WinForms;

namespace PharApp.RdlcReports.Stock
{
    partial class frmStockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockReport));
            reportViewerStock = new ReportViewer();
            groupBox2 = new GroupBox();
            btnAllStock = new Button();
            btnMfg = new Button();
            cmbManufacturer = new ComboBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewerStock
            // 
            reportViewerStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewerStock.Location = new Point(0, 47);
            reportViewerStock.Name = "ReportViewer";
            reportViewerStock.ServerReport.BearerToken = null;
            reportViewerStock.Size = new Size(916, 515);
            reportViewerStock.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAllStock);
            groupBox2.Controls.Add(btnMfg);
            groupBox2.Controls.Add(cmbManufacturer);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(4, -2);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(515, 46);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnAllStock
            // 
            btnAllStock.Location = new Point(372, 15);
            btnAllStock.Margin = new Padding(3, 2, 3, 2);
            btnAllStock.Name = "btnAllStock";
            btnAllStock.Size = new Size(139, 27);
            btnAllStock.TabIndex = 8;
            btnAllStock.Text = "All Stock";
            btnAllStock.UseVisualStyleBackColor = true;
            btnAllStock.Click += btnAllStock_Click;
            // 
            // btnMfg
            // 
            btnMfg.Location = new Point(217, 15);
            btnMfg.Margin = new Padding(3, 2, 3, 2);
            btnMfg.Name = "btnMfg";
            btnMfg.Size = new Size(151, 27);
            btnMfg.TabIndex = 7;
            btnMfg.Text = "Stock By Mfg";
            btnMfg.UseVisualStyleBackColor = true;
            btnMfg.Click += btnMfg_Click;
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(42, 18);
            cmbManufacturer.Margin = new Padding(3, 2, 3, 2);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(169, 23);
            cmbManufacturer.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(37, 19);
            label4.TabIndex = 5;
            label4.Text = "Mfg:";
            // 
            // frmStockReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 562);
            Controls.Add(groupBox2);
            Controls.Add(reportViewerStock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStockReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Report";
            Load += frmStockReport_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStock;
        private GroupBox groupBox2;
        private ComboBox cmbManufacturer;
        private Label label4;
        private Button b;
        private Button btnMfg;
        private Button btnAllStock;
    }
}