﻿using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharApp.Account
{
    public partial class frmDeposit : Form
    {
        public frmAccountDeposit _frmAccountDeposit = null;

        private bool _isInitializingAccountID = true;
        private bool _isInitializingInvoice = true;
        private bool _isBalanceRemainng = false;
        private decimal _hardCodedBalance = 0;

        private List<BML.ViewDeposit> _depositList;
        public IReadOnlyList<BML.ViewDeposit> DepositList => _depositList.AsReadOnly();

        public frmDeposit(Form frm = null)
        {
            InitializeComponent();

            _frmAccountDeposit = frm as frmAccountDeposit;

            _isInitializingAccountID = true;
            _isInitializingInvoice = true;

            PopulateComboBoxAccountId();
            PopulateComboBoxPaymentMethod();
            PopulateComboBoxDepositType();
        }

        private async void PopulateComboBoxAccountId()
        {
            try
            {
                var cmbPartyBal = new BAL.Account(Helper.GetConnectionStringFromSettings());
                var cmbPartyList = await cmbPartyBal.GetTransactionAccountsAsync();

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
            //string getMfgId = await GetMFGByAccountID(getAccountId);
            //find the manufacture or customer with its all invoices
            var cmbDepositInvoiceBal = new BAL.Account(Helper.GetConnectionStringFromSettings());
            var cmbDepositInvoiceList = await cmbDepositInvoiceBal.GetTransactionAccountsAsync();
            //Filter by mfg
            var cmbList = cmbDepositInvoiceList.Where(x => x.AccountID == getAccountId).ToList();
            //Combo box Code
            Dictionary<string, string> invoiceDictionary = new Dictionary<string, string>();
            invoiceDictionary.Add("-- Choose TRXACID --", Guid.NewGuid().ToString());

            // Populate the dictionary with category names and IDs
            foreach (var invoiceList in cmbList)
            {
                invoiceDictionary.Add(invoiceList.TransactionID, invoiceList.AccountID);
            }

            cmbInvoiceno.DataSource = new BindingSource(invoiceDictionary, null);
            cmbInvoiceno.DisplayMember = "Key"; // Display category names
            cmbInvoiceno.ValueMember = "Value"; // Use category IDs as values
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

        private void PopulateComboBoxDepositType()
        {
            try
            {
                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Deposit Type --", Guid.NewGuid().ToString());
                partyDictionary.Add("Sale", Guid.NewGuid().ToString());
                partyDictionary.Add("Purchase", Guid.NewGuid().ToString());

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbDepositType.DataSource = new BindingSource(partyDictionary, null);
                cmbDepositType.DisplayMember = "Key"; // Display category names
                cmbDepositType.ValueMember = "Value"; // Use category IDs as values
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
                string checkNo = txtCheckNo.Text.Trim();
                decimal debit = 0;

                if (!string.IsNullOrWhiteSpace(txtDebit.Text.Trim()) && decimal.TryParse(txtDebit.Text.Trim(), out decimal parsedValue))
                {
                    debit = parsedValue;
                }

                decimal credit = 0;

                if (!string.IsNullOrWhiteSpace(txtCredit.Text.Trim()) && decimal.TryParse(txtCredit.Text.Trim(), out decimal parsedValueCredit))
                {
                    credit = parsedValueCredit;
                }

                string remarks = richtxtRemarks.Text.Trim();

                // Retrieve the selected values from ComboBox controls
                string accountId = cmbAccountId.SelectedValue?.ToString();
                string invoiceNo = cmbInvoiceno.Text?.ToString();
                string paymentMethod = cmbPaymentMethod.Text?.ToString();
                string depositType = cmbDepositType.Text?.ToString();

                // Retrieve the date from DateTimePicker control
                DateTime depositDate = dateTimeDeposit.Value;

                var accountBal = new BAL.Deposit(Helper.GetConnectionStringFromSettings());
                int result = await accountBal.CreateDepositAsync(depositDate, accountId, invoiceNo, depositType, 0, paymentMethod, credit, debit, bankName, checkNo, remarks);

                if (result >= 1)
                {
                    Helper.Log($"Deposited Invoice:AccountID: {accountId},Invoice: {invoiceNo},Deposit Type: {depositType},Total Amount: {0},Credit: {credit},Debit {debit},Bank Name: {bankName},Check {checkNo}, Remarks {remarks}");
                    //ReLoadGridDataMedicine();
                    MessageBox.Show("Amount Deposited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
           

            // Check if the Manufacturer, Mnf Price, and Sell Price fields are valid
            if (string.IsNullOrEmpty(cmbAccountId.Text) || cmbAccountId.Text == "-- Choose Account --" || cmbAccountId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Account ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbInvoiceno.Text) || cmbInvoiceno.Text == "-- Choose TRXACID --" || cmbInvoiceno.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Invoice!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbPaymentMethod.Text) || cmbPaymentMethod.Text == "-- Choose Payment Method --" || cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Payment Method!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cmbDepositType.Text) || cmbDepositType.Text == "-- Deposit Type --" || cmbDepositType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Deposit Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }


        private async void LoadGridDataDeposit()
        {
            try
            {
                var depositBAL = new BAL.Deposit(Helper.GetConnectionStringFromSettings());
                _depositList = await depositBAL.ViewDepositsAsync();

                _frmAccountDeposit.depositGrid.DataSource = null;
                _frmAccountDeposit.depositGrid.DataSource = _depositList;
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
            txtCheckNo.Text = string.Empty;
            txtDebit.Text = string.Empty;

            // Reset RichTextBox control
            richtxtRemarks.Text = string.Empty;

            // Reset ComboBox controls
            cmbAccountId.Text = "-- Choose Account --";
            cmbInvoiceno.Text = "-- Choose Invoice --";
            cmbPaymentMethod.Text = "-- Choose Payment Method --";
            cmbDepositType.Text = "-- Deposit Type --";

            // Reset DateTimePicker control
            dateTimeDeposit.Value = DateTime.Now; // Set to the current date or any default date

            // Optionally, reset focus to the first control (optional)
            txtBankName.Focus();
        }

        private void txtDebit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Reference the TextBox control
            TextBox textBox = sender as TextBox;

            // Allow control keys, numeric digits, and only one decimal point
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') ||
                (e.KeyChar == '.' && textBox.Text.Contains(".")))
            {
                e.Handled = true; // Block invalid input
            }
        }

        private void txtCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Reference the TextBox control
            TextBox textBox = sender as TextBox;

            // Allow control keys, numeric digits, and only one decimal point
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') ||
                (e.KeyChar == '.' && textBox.Text.Contains(".")))
            {
                e.Handled = true; // Block invalid input
            }
        }
    }
}
