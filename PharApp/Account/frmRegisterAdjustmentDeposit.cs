using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharApp.Account
{
    public partial class frmRegisterAdjustmentDeposit : Form
    {
        public frmAccountDeposit _frmAccountDeposit = null;

        private bool _isInitializingAccountID = true;
        private bool _isInitializingInvoice = true;
        private bool _isBalanceRemainng = false;
        private decimal _hardCodedBalance = 0;

        private List<BML.ViewAdjustmentDeposit> _adjustmentDepositList;
        public IReadOnlyList<BML.ViewAdjustmentDeposit> DepositList => _adjustmentDepositList.AsReadOnly();

        public frmRegisterAdjustmentDeposit(Form frm = null)
        {
            InitializeComponent();

            _frmAccountDeposit = frm as frmAccountDeposit;

            _isInitializingAccountID = true;
            _isInitializingInvoice = true;

            PopulateComboBoxAccountId();
            PopulateComboBoxPaymentMethod();
        }

        private async void PopulateComboBoxAccountId()
        {
            try
            {
                var cmbPartyBal = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                List<BML.ViewAdjustmentAccount> cmbPartyList = await cmbPartyBal.GetAdjustmentAccountsAsync();

                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Choose Account --", Guid.NewGuid().ToString());
                // Populate the dictionary with category names and IDs
                foreach (var category in cmbPartyList)
                {
                    if (partyDictionary.ContainsKey(category.AccountHolder))
                        continue;
                    partyDictionary.Add(category.AccountHolder, category.AccountID);
                }

                cmbAccountId.DataSource = new BindingSource(partyDictionary, null);
                cmbAccountId.DisplayMember = "Key"; // Display category names
                cmbAccountId.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Party: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateComboBoxPaymentMethod()
        {
            try
            {
                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Choose Payment Method --", Guid.NewGuid().ToString());
                partyDictionary.Add("Cash", Guid.NewGuid().ToString());
                partyDictionary.Add("Debit", Guid.NewGuid().ToString());
                partyDictionary.Add("Credit", Guid.NewGuid().ToString());
                partyDictionary.Add("Online Banking", Guid.NewGuid().ToString());
                partyDictionary.Add("Check", Guid.NewGuid().ToString());

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbPaymentMethod.DataSource = new BindingSource(partyDictionary, null);
                cmbPaymentMethod.DisplayMember = "Key"; // Display category names
                cmbPaymentMethod.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Payment Method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Retrieve the values from the TextBox controls
                string bankName = txtBankName.Text.Trim();
                decimal totalAmount = Convert.ToDecimal(txtTotalAmount.Text.Trim().ToString());
                string checkNo = txtCheckNo.Text.Trim();
                decimal paidAmount = Convert.ToDecimal(txtPaidAmount.Text.Trim().ToString());
                decimal balance = Convert.ToDecimal(txtBalance.Text.Trim().ToString());
                string remarks = richtxtRemarks.Text.Trim();

                // Retrieve the selected values from ComboBox controls
                string accountId = cmbAccountId.SelectedValue?.ToString();
                string transactionid = cmbTransactionId.Text;
                string paymentMethod = cmbPaymentMethod.Text?.ToString();

                // Retrieve the date from DateTimePicker control
                DateTime depositDate = dateTimeDeposit.Value;

                var accountBal = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                int result = await accountBal.CreateAdjustmentDepositAsync(accountId, transactionid,depositDate,totalAmount,paymentMethod,bankName,checkNo,paidAmount,balance,remarks);

                if (result >= 1)
                {
                    Helper.Log($"Adjustment Deposited Invoice:AccountID: {accountId},Transaction Id: {transactionid},Total Amount: {totalAmount},Paid Amount: {paidAmount},Balance {balance},Bank Name: {bankName},Check {checkNo}, Remarks {remarks}");
                    //ReLoadGridDataMedicine();
                    MessageBox.Show("Amount Deposited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InvoiceInformation();

                    LoadGridDataDeposit();

                    //ResetForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to deposit amount. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrEmpty(txtPaidAmount.Text))
            {
                MessageBox.Show("Please enter Paid Amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Manufacturer, Mnf Price, and Sell Price fields are valid
            if (string.IsNullOrEmpty(cmbAccountId.Text) || cmbAccountId.Text == "-- Choose Account --" || cmbAccountId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Account ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbTransactionId.Text) || cmbTransactionId.Text == "-- Choose TransactionID --" || cmbTransactionId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Invoice!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbPaymentMethod.Text) || cmbPaymentMethod.Text == "-- Choose Payment Method --" || cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Payment Method!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private async Task<string> GetMFGByAccountID(string id)
        {
            var cmbPartyBal = new BAL.Account(Helper.GetConnectionStringFromSettings());
            List<BML.ViewAccount> cmbPartyList = await cmbPartyBal.GetAccountsAsync();
            var getAccount = cmbPartyList.Where(x => x.AccountID == id).FirstOrDefault();
            return getAccount.AccountName;
        }

        private async void cmbInvoiceno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializingInvoice)
            {
                _isInitializingInvoice = false;
                return;
            }

            if (string.IsNullOrEmpty(cmbTransactionId.Text) || cmbTransactionId.Text == "-- Choose TransactionID --" || cmbTransactionId.SelectedIndex == -1)
            {
                return;
            }
            //get invoice
            string invoice = cmbTransactionId.Text;

            var cmbDepositTransactionBal = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
            List<BML.ViewAdjustmentAccount> cmbDepositInvoiceList = await cmbDepositTransactionBal.GetAdjustmentAccountsAsync();

            var getSingleInvoiceTotal = cmbDepositInvoiceList.Where(x => x.TransactionID.ToLower() == invoice.ToLower()).FirstOrDefault();

            

            txtTransactionType.Text = getSingleInvoiceTotal.TransactionType;

            InvoiceInformation();
        }

        private void txtPaidAmount_KeyUp(object sender, KeyEventArgs e)
        {
            // Assuming that _isBalanceRemaining is a flag that indicates if there's an existing balance
            if (_isBalanceRemainng)
            {
                if (!string.IsNullOrEmpty(txtBalance.Text))
                {
                    // Ensure the input is a valid decimal number
                    if (decimal.TryParse(txtPaidAmount.Text, out decimal paidAmount))
                    {
                        // Calculate the new remaining balance based on the existing balance
                        decimal newRemainingBalance = _hardCodedBalance - paidAmount;

                        // Ensure the remaining balance doesn't go below zero (overpayment)
                        if (newRemainingBalance >= 0)
                        {
                            txtBalance.Text = newRemainingBalance.ToString();
                        }
                        else
                        {
                            // Handle overpayment
                            MessageBox.Show("Overpayment detected. Please check the amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPaidAmount.Text = _hardCodedBalance.ToString(); // Reset to the maximum possible amount
                        }
                    }
                    else
                    {
                        // Reset the display if input is invalid
                        txtBalance.Text = _hardCodedBalance.ToString();
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtTotalAmount.Text))
                {
                    decimal totalInvoiceAmount = Convert.ToDecimal(txtTotalAmount.Text);
                    // Ensure the input is a valid decimal number
                    if (decimal.TryParse(txtPaidAmount.Text, out decimal paidAmount))
                    {
                        // Calculate the new remaining balance
                        decimal newRemainingBalance = totalInvoiceAmount - paidAmount;

                        // Ensure the remaining balance doesn't go below zero (overpayment)
                        if (newRemainingBalance >= 0)
                        {
                            txtBalance.Text = newRemainingBalance.ToString("F2");
                        }
                        else
                        {
                            // Handle overpayment
                            MessageBox.Show("Overpayment detected. Please check the amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPaidAmount.Text = totalInvoiceAmount.ToString("F2"); // Reset to the maximum possible amount
                        }
                    }
                    else
                    {
                        // Reset the display if input is invalid
                        txtBalance.Text = totalInvoiceAmount.ToString("F2");
                    }
                }
            }
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, one decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Invalid character, don't process further
            }

            // If user enters a decimal point, ensure it's the only one
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Disallow a second decimal point
            }
        }

        async void InvoiceInformation()
        {
            string transactionid = cmbTransactionId.Text;


            var depositBal = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
            List<BML.ViewAdjustmentDeposit> depositList = await depositBal.GetAdjustmentDepositsAsync();

            var getSingleDeposit = depositList.Where(x => x.TransactionID == transactionid).FirstOrDefault();
            if (getSingleDeposit != null)
            {
                txtBalance.Text = getSingleDeposit.Balance.ToString();
                _hardCodedBalance = Convert.ToDecimal(getSingleDeposit.Balance);
                _isBalanceRemainng = true;
                if (Convert.ToInt32(getSingleDeposit.isPaid) == 1)
                {
                    lblInvoicePaid.Visible = true;
                    _isBalanceRemainng = false;
                    lblInvoiceNotPaid.Visible = false;
                    btnDeposit.Enabled = false;
                }
                else
                {
                    lblInvoiceNotPaid.Visible = true;
                    lblInvoicePaid.Visible = false;
                    btnDeposit.Enabled = true;
                }
            }
            else
            {
                lblInvoiceNotPaid.Visible = true;
                lblInvoicePaid.Visible = false;
                _isBalanceRemainng = false;
                btnDeposit.Enabled = true;
                _hardCodedBalance = 0;
                txtBalance.Text = "0.00";
            }
        }

        private async void LoadGridDataDeposit()
        {
            try
            {
                var adjustmentDepositBAL = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                _adjustmentDepositList = await adjustmentDepositBAL.GetAdjustmentDepositsAsync();

                _frmAccountDeposit.dataGridViewAdjustmentDepositGrid.DataSource = null;
                _frmAccountDeposit.dataGridViewAdjustmentDepositGrid.DataSource = _adjustmentDepositList;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            // Reset TextBox controls
            txtBankName.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtCheckNo.Text = string.Empty;
            txtPaidAmount.Text = string.Empty;
            txtBalance.Text = string.Empty;

            // Reset RichTextBox control
            richtxtRemarks.Text = string.Empty;

            // Reset ComboBox controls
            cmbAccountId.Text = "-- Choose Account --";
            cmbTransactionId.Text = "-- Choose Invoice --";
            cmbPaymentMethod.Text = "-- Choose Payment Method --";

            // Reset DateTimePicker control
            dateTimeDeposit.Value = DateTime.Now; // Set to the current date or any default date
            lblInvoiceNotPaid.Visible = false;
            lblInvoicePaid.Visible = false;
            // Optionally, reset focus to the first control (optional)
            txtBankName.Focus();
        }

        private async void cmbAccountId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializingAccountID)
            {
                _isInitializingAccountID = false;
                return;
            }
            // take id from the account id 
            string getAccountId = cmbAccountId.SelectedValue.ToString();
            // Validate Party ComboBox
            if (string.IsNullOrEmpty(cmbAccountId.Text) || cmbAccountId.Text == "-- Choose Account --" || cmbAccountId.SelectedIndex == -1)
            {
                return;
            }
            //find the manufacture or customer with its all invoices
            var cmbDepositTransactionIdBal = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
            List<BML.ViewTransactionIdCMB> cmbDepositTransactionList = await cmbDepositTransactionIdBal.GetTransactionIdCMBAsync();
            //Filter by mfg
            var cmbList = cmbDepositTransactionList.Where(x => x.AccountID == getAccountId).ToList();
            //Combo box Code
            Dictionary<string, string> invoiceDictionary = new Dictionary<string, string>();
            invoiceDictionary.Add("-- Choose TransactionID --", Guid.NewGuid().ToString());

            // Populate the dictionary with category names and IDs
            foreach (var invoiceList in cmbList)
            {
                invoiceDictionary.Add(invoiceList.TransactionID, invoiceList.AccountID);
            }

            cmbTransactionId.DataSource = new BindingSource(invoiceDictionary, null);
            cmbTransactionId.DisplayMember = "Key"; // Display category names
            cmbTransactionId.ValueMember = "Value"; // Use category IDs as values
        }
    }
}
