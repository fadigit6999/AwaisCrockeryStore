using Microsoft.Reporting.WinForms;

namespace PharApp.RdlcReports.Purchase
{
    partial class rptPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptPurchase));
            reportViewer1 = new ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(916, 571);
            reportViewer1.TabIndex = 0;
            // 
            // rptPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 562);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rptPurchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pruchase Report";
            Load += rptPurchase_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReportViewer reportViewer1;
    }
}