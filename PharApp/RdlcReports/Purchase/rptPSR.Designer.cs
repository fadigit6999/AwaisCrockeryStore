using Microsoft.Reporting.WinForms;

namespace PharApp.RdlcReports.Purchase
{
    partial class rptPSR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptPSR));
            reportViewer1 = new ReportViewer();
            groupBox1 = new GroupBox();
            fromDateControl = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            toDateControl = new DateTimePicker();
            groupBox2 = new GroupBox();
            cmbManufacturer = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cmbPaymentType = new ComboBox();
            checkBoxDate = new CheckBox();
            btnReport = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 47);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(916, 571);
            reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromDateControl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(toDateControl);
            groupBox1.Location = new Point(7, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(312, 40);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date";
            // 
            // fromDateControl
            // 
            fromDateControl.CustomFormat = "yyyy-MM-dd";
            fromDateControl.Format = DateTimePickerFormat.Short;
            fromDateControl.Location = new Point(52, 15);
            fromDateControl.Margin = new Padding(3, 2, 3, 2);
            fromDateControl.Name = "fromDateControl";
            fromDateControl.Size = new Size(110, 23);
            fromDateControl.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(4, 16);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 2;
            label2.Text = "From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(164, 16);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 1;
            label1.Text = "To:";
            // 
            // toDateControl
            // 
            toDateControl.CustomFormat = "yyyy-MM-dd";
            toDateControl.Format = DateTimePickerFormat.Short;
            toDateControl.Location = new Point(192, 14);
            toDateControl.Margin = new Padding(3, 2, 3, 2);
            toDateControl.Name = "toDateControl";
            toDateControl.Size = new Size(110, 23);
            toDateControl.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbManufacturer);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbPaymentType);
            groupBox2.Controls.Add(checkBoxDate);
            groupBox2.Location = new Point(325, 2);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(494, 39);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Filters";
            // 
            // cmbManufacturer
            // 
            cmbManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbManufacturer.FormattingEnabled = true;
            cmbManufacturer.Location = new Point(312, 10);
            cmbManufacturer.Margin = new Padding(3, 2, 3, 2);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(169, 23);
            cmbManufacturer.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(276, 11);
            label4.Name = "label4";
            label4.Size = new Size(37, 19);
            label4.TabIndex = 5;
            label4.Text = "Mfg:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(68, 14);
            label3.Name = "label3";
            label3.Size = new Size(27, 19);
            label3.TabIndex = 4;
            label3.Text = "PT:";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(102, 11);
            cmbPaymentType.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(169, 23);
            cmbPaymentType.TabIndex = 3;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AutoSize = true;
            checkBoxDate.Location = new Point(9, 14);
            checkBoxDate.Margin = new Padding(3, 2, 3, 2);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(50, 19);
            checkBoxDate.TabIndex = 0;
            checkBoxDate.Text = "Date";
            checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(823, 8);
            btnReport.Margin = new Padding(3, 2, 3, 2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(82, 34);
            btnReport.TabIndex = 3;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // rptPSR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 562);
            Controls.Add(btnReport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rptPSR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pruchase Report";
            Load += rptPurchase_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReportViewer reportViewer1;
        private GroupBox groupBox1;
        private DateTimePicker toDateControl;
        private Label label2;
        private Label label1;
        private DateTimePicker fromDateControl;
        private GroupBox groupBox2;
        private CheckBox checkBoxDate;
        private ComboBox cmbManufacturer;
        private Label label4;
        private Label label3;
        private ComboBox cmbPaymentType;
        private Button btnReport;
    }
}