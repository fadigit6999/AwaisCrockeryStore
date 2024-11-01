using BAL;
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
    public partial class frmRegisterAdjustmentAccount : Form
    {
        public frmAccountDeposit _frmAccountDeposit = null;
        public AdjustmentBAL _adjustmentBAL = null;
        private List<BML.ViewAdjustmentAccount> _accountAdjustmentList;

        public IReadOnlyList<BML.ViewAdjustmentAccount> List => _accountAdjustmentList.AsReadOnly();

        private readonly string _AccountId = null;

        public frmRegisterAdjustmentAccount(Form frm = null, string accountId = null)
        {
            InitializeComponent();
            _frmAccountDeposit = frm as frmAccountDeposit;
            _AccountId = accountId;
        }

        private async void PopulateComboBoxClients()
        {
            try
            {
                var cmbPartyBal = new BAL.Account(Helper.GetConnectionStringFromSettings());
                List<BML.Party> cmbPartyList = await cmbPartyBal.GetPartyAsync();

                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Choose Party --", Guid.NewGuid().ToString());
                // Populate the dictionary with category names and IDs
                foreach (var category in cmbPartyList)
                {
                    partyDictionary.Add(category.name, category.id);
                }

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbParty.DataSource = new BindingSource(partyDictionary, null);
                cmbParty.DisplayMember = "Key"; // Display category names
                cmbParty.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Party: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateComboBoxDepositType()
        {
            try
            {
                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Transaction Type --", Guid.NewGuid().ToString());
                partyDictionary.Add("Sale", Guid.NewGuid().ToString());
                partyDictionary.Add("Purchase", Guid.NewGuid().ToString());

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbType.DataSource = new BindingSource(partyDictionary, null);
                cmbType.DisplayMember = "Key"; // Display category names
                cmbType.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Payment Method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Get the value (ID) from the cmbParty (Party ComboBox)
                string selectedPartyValue = ((KeyValuePair<string, string>)cmbParty.SelectedItem).Value;
                string selectedPartyText = cmbParty.Text.ToString();

                // Get the text (Type) from the cmbType (Type ComboBox)
                string selectedTypeText = cmbType.Text;

                // Assign to variables
                string partyId = selectedPartyValue; // The selected Party's ID
                string partyType = selectedTypeText; // The selected Type text (e.g., Purchase/Sale)

                string transactionid = txtTransactionId.Text;
                decimal totalAmount = Convert.ToDecimal(txtTotalAmount.Text);

                string remarks = richtxtRemarks.Text;

                var accountAdjustmentBAL = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                int result = await accountAdjustmentBAL.CreateAdjustmentAccountAsync(partyId, partyType, transactionid,totalAmount,DateTime.Now,remarks);
                if (result == 1)
                {
                    Helper.Log($"Transaction Id Created For the Party ## {selectedPartyText} ##");
                    LoadGridDataAccount();
                    MessageBox.Show($"Transaction Id Created For the Party ## {selectedPartyText} ## successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Validate Party ComboBox
            if (string.IsNullOrEmpty(cmbParty.Text) || cmbParty.Text == "-- Choose Party --" || cmbParty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Party.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbParty.Focus();
                return false;
            }

            // Validate Type ComboBox
            if (string.IsNullOrEmpty(cmbType.Text) || cmbType.Text == "-- Transaction Type --" || cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Transaction Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbType.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTotalAmount.Text))
            {
                MessageBox.Show("Please enter the total amount for the Transaction Id.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbType.Focus();
                return false;
            }

            // If both validations pass
            return true;
        }

        private async void LoadGridDataAccount()
        {
            try
            {
                var accountBAL = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                _accountAdjustmentList = await accountBAL.GetAdjustmentAccountsAsync();
                _frmAccountDeposit.dataGridViewAdjustementAccount.DataSource = null;
                _frmAccountDeposit.dataGridViewAdjustementAccount.DataSource = _accountAdjustmentList;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmRegisterAdjustmentAccount_Load(object sender, EventArgs e)
        {
            //Combo boxes
            PopulateComboBoxClients();
            PopulateComboBoxDepositType();
            //Grid Load
            LoadGridDataAccount();
            //Load Transaction Id
            _adjustmentBAL = new AdjustmentBAL(WinHelper.Helper.GetConnectionStringFromSettings());
            txtTransactionId.Text = await _adjustmentBAL.GetUniqueTransactionIdAsync();
        }


        
        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
