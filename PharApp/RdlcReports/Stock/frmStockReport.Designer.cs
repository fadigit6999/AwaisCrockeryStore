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
            SuspendLayout();
            // 
            // reportViewerStock
            // 
            reportViewerStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewerStock.Location = new Point(0, 0);
            reportViewerStock.Name = "ReportViewer";
            reportViewerStock.ServerReport.BearerToken = null;
            reportViewerStock.Size = new Size(916, 571);
            reportViewerStock.TabIndex = 0;
            // 
            // frmStockReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 562);
            Controls.Add(reportViewerStock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStockReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Report";
            Load += frmStockReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStock;
    }
}