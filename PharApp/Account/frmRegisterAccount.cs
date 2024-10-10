using PharApp.Inventory;
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
    public partial class frmRegisterAccount : Form
    {
        public frmAccountDeposit _frmAccountDeposit = null;
        private List<BML.ViewAccount> _accountList;

        public IReadOnlyList<BML.ViewAccount> UnitList => _accountList.AsReadOnly();

        private readonly string _AccountId = null;
        public frmRegisterAccount(Form frm = null, string accountId = null)
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

        private async void PopulateComboBoxType()
        {
            try
            {
                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Choose Type --", Guid.NewGuid().ToString());
                partyDictionary.Add("Supplier", Guid.NewGuid().ToString());
                partyDictionary.Add("Customer", Guid.NewGuid().ToString());

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbType.DataSource = new BindingSource(partyDictionary, null);
                cmbType.DisplayMember = "Key"; // Display category names
                cmbType.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(cmbType.Text) || cmbType.Text == "-- Choose Type --" || cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbType.Focus();
                return false;
            }

            // If both validations pass
            return true;
        }


        private async void btnAccount_Click(object sender, EventArgs e)
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

                var accountBAL = new BAL.Account(Helper.GetConnectionStringFromSettings());
                int result = await accountBAL.CreateAccountAsync(partyId,partyType);
                if (result == 1)
                {
                    Helper.Log($"Account Created For the Party ## {selectedPartyText} ##");
                    LoadGridDataAccount();
                    MessageBox.Show($"Account Created For the Party ## {selectedPartyText} ## successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {

            //if (ValidateInput())
            //{
            //    string Name = txtName.Text;
            //    var unitBAL = new BAL.Unit(Helper.GetConnectionStringFromSettings());
            //    int result = await unitBAL.CreateUnitAsync(Name);
            //    if (result == 1)
            //    {
            //        Helper.Log($"Unit Created:Name {Name}");
            //        LoadGridDataUnit();
            //        MessageBox.Show("Unit registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Hide();

            //        var frmUnit = new frmRegisterUnit(_frmMedicine);
            //        frmUnit.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to register Unit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadGridDataAccount()
        {
            try
            {
                var accountBAL = new BAL.Account(Helper.GetConnectionStringFromSettings());
                _accountList = await accountBAL.GetAccountsAsync();
                _frmAccountDeposit.accountGrid.DataSource = null;
                _frmAccountDeposit.accountGrid.DataSource = _accountList;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmregisterunit_Load(object sender, EventArgs e)
        {
            //if (_unitId is not null)
            //{
            //    var unitBAL = new BAL.Unit(Helper.GetConnectionStringFromSettings());
            //    var unitlist = await unitBAL.GetUnitsAsync();
            //    var singleUnit = unitlist.Where(x => x.UnitId == _unitId).FirstOrDefault();
            //    txtName.Text = singleUnit.UnitName;
            //    btnRegister.Visible = false;
            //    btnRegisterAddOther.Visible = false;

            //}
            //else
            //{
            //    btnUpdate.Visible = false;
            //}
        }

        private void frmRegisterAccount_Load(object sender, EventArgs e)
        {
            PopulateComboBoxClients();
            PopulateComboBoxType();
        }
    }
}
