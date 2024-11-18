using Microsoft.Reporting.WinForms;

namespace PharApp.RdlcReports.Account
{
    partial class rptAdjustmentAccountLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptAdjustmentAccountLedger));
            reportViewer1 = new ReportViewer();
            groupBox2 = new GroupBox();
            label1 = new Label();
            cmbAccount = new ComboBox();
            cmbPaymtMethod = new ComboBox();
            label4 = new Label();
            btnReport = new Button();
            btnClear = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 47);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1063, 571);
            reportViewer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbAccount);
            groupBox2.Controls.Add(cmbPaymtMethod);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 0);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(555, 39);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 8;
            label1.Text = "Account:";
            // 
            // cmbAccount
            // 
            cmbAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAccount.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(73, 10);
            cmbAccount.Margin = new Padding(3, 2, 3, 2);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(169, 23);
            cmbAccount.TabIndex = 7;
            // 
            // cmbPaymtMethod
            // 
            cmbPaymtMethod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymtMethod.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymtMethod.FormattingEnabled = true;
            cmbPaymtMethod.Location = new Point(374, 12);
            cmbPaymtMethod.Margin = new Padding(3, 2, 3, 2);
            cmbPaymtMethod.Name = "cmbPaymtMethod";
            cmbPaymtMethod.Size = new Size(169, 23);
            cmbPaymtMethod.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(249, 14);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 5;
            label4.Text = "Payment Method:";
            // 
            // btnReport
            // 
            btnReport.Location = new Point(938, 12);
            btnReport.Margin = new Padding(3, 2, 3, 2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(115, 27);
            btnReport.TabIndex = 3;
            btnReport.Text = "Generate Ledger";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(817, 12);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 27);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear Filter";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rptAdjustmentAccountLedger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 562);
            Controls.Add(btnClear);
            Controls.Add(btnReport);
            Controls.Add(groupBox2);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rptAdjustmentAccountLedger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pruchase Report";
            Load += rptPurchase_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReportViewer reportViewer1;
        private GroupBox groupBox2;
        private ComboBox cmbPaymtMethod;
        private Label label4;
        private Button btnReport;
        private Label label1;
        private ComboBox cmbAccount;
        private Button btnClear;
    }
}