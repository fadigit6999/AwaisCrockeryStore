using Microsoft.Reporting.WinForms;
using PharApp.RdlcReports.Purchase;

namespace PharApp.RdlcReports.Sale
{
    partial class rptSSR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptSSR));
            reportViewer1 = new ReportViewer();
            btnReport = new Button();
            groupBox2 = new GroupBox();
            cmbCustomer = new ComboBox();
            cmbBooker = new ComboBox();
            cmbSupplier = new ComboBox();
            cmbArea = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbPaymentType = new ComboBox();
            checkBoxDate = new CheckBox();
            groupBox1 = new GroupBox();
            fromDateControl = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            toDateControl = new DateTimePicker();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 93);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1438, 804);
            reportViewer1.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(618, 15);
            btnReport.Margin = new Padding(3, 2, 3, 2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(82, 67);
            btnReport.TabIndex = 6;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbCustomer);
            groupBox2.Controls.Add(cmbBooker);
            groupBox2.Controls.Add(cmbSupplier);
            groupBox2.Controls.Add(cmbArea);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbPaymentType);
            groupBox2.Controls.Add(checkBoxDate);
            groupBox2.Location = new Point(328, 10);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(281, 71);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Filters";
            // 
            // cmbCustomer
            // 
            cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(102, 37);
            cmbCustomer.Margin = new Padding(3, 2, 3, 2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(169, 23);
            cmbCustomer.TabIndex = 6;
            // 
            // cmbBooker
            // 
            cmbBooker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBooker.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBooker.FormattingEnabled = true;
            cmbBooker.Location = new Point(356, 38);
            cmbBooker.Margin = new Padding(3, 2, 3, 2);
            cmbBooker.Name = "cmbBooker";
            cmbBooker.Size = new Size(169, 23);
            cmbBooker.TabIndex = 6;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(614, 11);
            cmbSupplier.Margin = new Padding(3, 2, 3, 2);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(169, 23);
            cmbSupplier.TabIndex = 6;
            // 
            // cmbArea
            // 
            cmbArea.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbArea.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(356, 10);
            cmbArea.Margin = new Padding(3, 2, 3, 2);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(169, 23);
            cmbArea.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(276, 38);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 5;
            label6.Text = "Booker:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(535, 12);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 5;
            label7.Text = "Supplier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(24, 38);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 5;
            label5.Text = "Customer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(276, 11);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 5;
            label4.Text = "Sale Area:";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(fromDateControl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(toDateControl);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(312, 40);
            groupBox1.TabIndex = 4;
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
            // rptSSR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(btnReport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rptSSR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Summary Report";
            Load += rptSale_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReportViewer reportViewer1;
        private Button btnReport;
        private GroupBox groupBox2;
        private ComboBox cmbArea;
        private Label label4;
        private Label label3;
        private ComboBox cmbPaymentType;
        private CheckBox checkBoxDate;
        private GroupBox groupBox1;
        private DateTimePicker fromDateControl;
        private Label label2;
        private Label label1;
        private DateTimePicker toDateControl;
        private ComboBox cmbCustomer;
        private Label label5;
        private ComboBox cmbBooker;
        private ComboBox cmbSupplier;
        private Label label6;
        private Label label7;
    }
}