using Microsoft.Reporting.WinForms;
using PharApp.RdlcReports.Purchase;

namespace PharApp.RdlcReports.Sale
{
    partial class rptSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptSale));
            reportViewer1 = new ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1131, 804);
            reportViewer1.TabIndex = 0;
            // 
            // rptSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 562);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rptSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Report";
            Load += rptSale_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReportViewer reportViewer1;
    }
}