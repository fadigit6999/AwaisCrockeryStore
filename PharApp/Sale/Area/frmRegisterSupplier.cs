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
using System.Xml.Linq;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
namespace PharApp.Sale.Area
{
    public partial class frmRegisterSupplier : Form
    {
        public frmArea _frmArea = null;
        private List<BML.Supplier> _supplierList;
        public IReadOnlyList<BML.Supplier> SupplierList => _supplierList.AsReadOnly();
        private readonly BAL.Supplier _supplier;
        public frmRegisterSupplier(Form frm = null)
        {
            InitializeComponent();
            _frmArea = frm as frmArea;
            _supplier = new BAL.Supplier(Helper.GetConnectionStringFromSettings());
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string company = txtCompany.Text;
                string address = richTxtAddress.Text;

                int result = await _supplier.CreateSupplierAsync(name,company,email,phone, address);
                if (result == 1)
                {
                    Helper.Log($"Supplier Created:Name {name}");
                    LoadGridDataSupplier();
                    MessageBox.Show("Supplier registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string company = txtCompany.Text;
                string address = richTxtAddress.Text;

                int result = await _supplier.CreateSupplierAsync(name, company, email, phone, address);
                if (result == 1)
                {
                    Helper.Log($"Supplier Created:Name {name}");
                    LoadGridDataSupplier();
                    MessageBox.Show("Supplier registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var frm = new frmRegisterSupplier(_frmArea);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register Unit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the Area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
        }


        private async void LoadGridDataSupplier()
        {
            try
            {
                _supplierList = await _supplier.GetSuppliersAsync();
                // Bind the data to the grid
                _frmArea.dataGridViewSupplier.DataSource = _supplierList;
                _frmArea.dataGridViewSupplier.Columns["SupplierID"].HeaderText = "Id";
                _frmArea.dataGridViewSupplier.Columns["Name"].HeaderText = "Name";
                _frmArea.dataGridViewSupplier.Columns["CompanyName"].HeaderText = "Company";
                _frmArea.dataGridViewSupplier.Columns["Email"].HeaderText = "Email";
                _frmArea.dataGridViewSupplier.Columns["Phone"].HeaderText = "Phone";
                _frmArea.dataGridViewSupplier.Columns["Address"].HeaderText = "Address";
                _frmArea.dataGridViewSupplier.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
