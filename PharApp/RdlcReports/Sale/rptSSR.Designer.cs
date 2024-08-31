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
            reportViewer1.Location = new Point(0, 124);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1643, 1072);
            reportViewer1.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(1291, 19);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 89);
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
            groupBox2.Location = new Point(375, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(910, 95);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Filters";
            // 
            // cmbCustomer
            // 
            cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(117, 49);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(193, 28);
            cmbCustomer.TabIndex = 6;
            // 
            // cmbBooker
            // 
            cmbBooker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBooker.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBooker.FormattingEnabled = true;
            cmbBooker.Location = new Point(407, 50);
            cmbBooker.Name = "cmbBooker";
            cmbBooker.Size = new Size(193, 28);
            cmbBooker.TabIndex = 6;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(702, 15);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(193, 28);
            cmbSupplier.TabIndex = 6;
            // 
            // cmbArea
            // 
            cmbArea.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbArea.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(407, 14);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(193, 28);
            cmbArea.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(316, 51);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 5;
            label6.Text = "Booker:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(611, 16);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 5;
            label7.Text = "Supplier:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(28, 50);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 5;
            label5.Text = "Customer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(316, 15);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 5;
            label4.Text = "Sale Area:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(78, 19);
            label3.Name = "label3";
            label3.Size = new Size(33, 23);
            label3.TabIndex = 4;
            label3.Text = "PT:";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(117, 15);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(193, 28);
            cmbPaymentType.TabIndex = 3;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AutoSize = true;
            checkBoxDate.Location = new Point(10, 19);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(63, 24);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 54);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date";
            // 
            // fromDateControl
            // 
            fromDateControl.CustomFormat = "yyyy-MM-dd";
            fromDateControl.Format = DateTimePickerFormat.Short;
            fromDateControl.Location = new Point(59, 20);
            fromDateControl.Name = "fromDateControl";
            fromDateControl.Size = new Size(125, 27);
            fromDateControl.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 2;
            label2.Text = "From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(187, 22);
            label1.Name = "label1";
            label1.Size = new Size(31, 23);
            label1.TabIndex = 1;
            label1.Text = "To:";
            // 
            // toDateControl
            // 
            toDateControl.CustomFormat = "yyyy-MM-dd";
            toDateControl.Format = DateTimePickerFormat.Short;
            toDateControl.Location = new Point(220, 18);
            toDateControl.Name = "toDateControl";
            toDateControl.Size = new Size(125, 27);
            toDateControl.TabIndex = 0;
            // 
            // rptSSR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 885);
            Controls.Add(btnReport);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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