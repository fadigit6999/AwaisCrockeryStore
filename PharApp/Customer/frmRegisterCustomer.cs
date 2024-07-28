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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharApp.Customer
{
    public partial class frmRegisterCustomer : Form
    {
        public frmCustomers _frmCustomer = null;
        private List<BML.Customer> _customerList;
        public IReadOnlyList<BML.Customer> CustomerList => _customerList.AsReadOnly();
        private readonly string _customerId = null;
        public frmRegisterCustomer(Form frm, string customerId = null)
        {
            InitializeComponent();
            _frmCustomer = frm as frmCustomers;
            _customerId = customerId;
        }

        private async void btnRegistration_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string firstName = txtFristName.Text;
                string dsl = txtDSL.Text;
                string email = string.IsNullOrEmpty(txtEmail.Text) ? string.Empty : txtEmail.Text;
                string phone = string.IsNullOrEmpty(txtPhoneno.Text) ? string.Empty : txtPhoneno.Text;
                string address = txtAddress.Text; // assuming txtAddress represents the address line
                string customerType = string.IsNullOrEmpty(txtType.Text) ? string.Empty : txtType.Text;
                string category = cmbCustomerCategory.Text;
                var customerBAL = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                int result = await customerBAL.CreateCustomerAsync(firstName, email, phone, address, customerType, category, dsl);
                if (result == 1)
                {
                    Helper.Log("Customer Created: " + " ," + firstName + " ," + email + " ," + address + " ," + customerType + " ," + category + " ," + dsl);
                    LoadGridDataCustomer(); // Assuming this method reloads the grid with customer data
                    MessageBox.Show("Customer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFristName.Text))
            {
                MessageBox.Show("Please enter the First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Manufacturer, Mnf Price, and Sell Price fields are valid
            if (string.IsNullOrEmpty(cmbCustomerCategory.Text) || cmbCustomerCategory.Text == "Choose Category")
            {
                MessageBox.Show("Please select Valid Category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }


        private async void LoadGridDataCustomer()
        {
            try
            {
                var customerBal = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                _customerList = await customerBal.GetCustomersAsync();
                // Bind the data to the grid
                _frmCustomer.dataGridViewCustomer.DataSource = _customerList;

                _frmCustomer.dataGridViewCustomer.DataSource = _customerList;
                _frmCustomer.dataGridViewCustomer.Columns["CustomerID"].HeaderText = "Id";
                _frmCustomer.dataGridViewCustomer.Columns["FullName"].HeaderText = "Name";
                _frmCustomer.dataGridViewCustomer.Columns["DSL"].HeaderText = "DSL";
                _frmCustomer.dataGridViewCustomer.Columns["Email"].HeaderText = "Email";
                _frmCustomer.dataGridViewCustomer.Columns["Phone"].HeaderText = "Phone No";
                _frmCustomer.dataGridViewCustomer.Columns["CustomerType"].HeaderText = "Type";
                _frmCustomer.dataGridViewCustomer.Columns["AddressLine1"].HeaderText = "Address";
                _frmCustomer.dataGridViewCustomer.Columns["Category"].HeaderText = "Category";

                _frmCustomer.dataGridViewCustomer.Columns["CustomerID"].DisplayIndex = 1;
                _frmCustomer.dataGridViewCustomer.Columns["FullName"].DisplayIndex = 2;
                _frmCustomer.dataGridViewCustomer.Columns["DSL"].DisplayIndex = 3;
                _frmCustomer.dataGridViewCustomer.Columns["Category"].DisplayIndex = 4;
                _frmCustomer.dataGridViewCustomer.Columns["Email"].DisplayIndex = 5;
                _frmCustomer.dataGridViewCustomer.Columns["Phone"].DisplayIndex = 6;
                _frmCustomer.dataGridViewCustomer.Columns["CustomerType"].DisplayIndex = 7;
                _frmCustomer.dataGridViewCustomer.Columns["AddressLine1"].DisplayIndex = 8;

                _frmCustomer.dataGridViewCustomer.Columns["FirstName"].Visible = false;

                _frmCustomer.dataGridViewCustomer.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRegisterAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string firstName = txtFristName.Text;
                string dsl = txtDSL.Text;
                string email = string.IsNullOrEmpty(txtEmail.Text) ? string.Empty : txtEmail.Text;
                string phone = string.IsNullOrEmpty(txtPhoneno.Text) ? string.Empty : txtPhoneno.Text;
                string address = txtAddress.Text; // assuming txtAddress represents the address line
                string customerType = string.IsNullOrEmpty(txtType.Text) ? string.Empty : txtType.Text;
                string category = cmbCustomerCategory.Text;

                var customerBAL = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                int result = await customerBAL.CreateCustomerAsync(firstName, email, phone, address, customerType, category, dsl);
                if (result == 1)
                {
                    Helper.Log("Customer Created: " + " ," + firstName + " ," + email + " ," + address + " ," + customerType + " ," + category + " ," + dsl);

                    LoadGridDataCustomer(); // Assuming this method reloads the grid with customer data
                    MessageBox.Show("Customer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Hide the current form

                    // Open a new form for registering another customer
                    var frmCustomer = new frmRegisterCustomer(_frmCustomer); // Assuming _frmMedicine is a reference to the parent form
                    frmCustomer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void frmRegisterCustomer_Load(object sender, EventArgs e)
        {
            // Step 1: Add items to the ComboBox.
            cmbCustomerCategory.Items.Add("NTN");
            cmbCustomerCategory.Items.Add("PMDC");
            cmbCustomerCategory.Items.Add("None");

            // Step 2: Insert the "Choose category" item at the beginning.
            cmbCustomerCategory.Items.Insert(0, "Choose Category");

            // Step 3: Set the default selected index to 0
            cmbCustomerCategory.SelectedIndex = 0;

            if (_customerId is not null)
            {
                var customerBAL = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                var customerlist = await customerBAL.GetCustomersAsync();
                var singleCustomer = customerlist.Where(x => x.CustomerID == _customerId).FirstOrDefault();
                GetFillCustomer(singleCustomer);
                btnRegistration.Visible = false;
                btnRegisterAdd.Visible = false;

            }
            else
            {
                btnUpdate.Visible = false;
            }
        }

        void GetFillCustomer(BML.Customer customer)
        {
            txtFristName.Text = customer.FullName;
            txtDSL.Text = customer.DSL;
            txtEmail.Text = customer.Email;
            txtPhoneno.Text = customer.Phone;
            txtAddress.Text = customer.AddressLine1; // assuming txtAddress represents the address line
            txtType.Text = customer.CustomerType;
            cmbCustomerCategory.Text = customer.Category;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string firstName = txtFristName.Text;
                string dsl = txtDSL.Text;
                string email = string.IsNullOrEmpty(txtEmail.Text) ? string.Empty : txtEmail.Text;
                string phone = string.IsNullOrEmpty(txtPhoneno.Text) ? string.Empty : txtPhoneno.Text;
                string address = txtAddress.Text; // assuming txtAddress represents the address line
                string customerType = string.IsNullOrEmpty(txtType.Text) ? string.Empty : txtType.Text;
                string category = cmbCustomerCategory.Text;
                var customerBAL = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                int result = await customerBAL.UpdateCustomerAsync(_customerId,firstName,email,phone,address,category,customerType,dsl);
                if (result == 1)
                {
                    Helper.Log("Customer Updated: " + " ," + firstName + " ," + email + " ," + address + " ," + customerType + " ," + category + " ," + dsl);
                    LoadGridDataCustomer(); // Assuming this method reloads the grid with customer data
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
