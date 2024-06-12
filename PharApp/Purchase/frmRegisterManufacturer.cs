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

namespace PharApp.Purchase
{
    public partial class frmRegisterManufacturer : Form
    {
        private List<BML.Manufacturer> _manufacturerList;

        public IReadOnlyList<BML.Manufacturer> MedicineList => _manufacturerList.AsReadOnly();

        public frmManufacturer _frmManufacturer = null;
        public frmRegisterManufacturer(Form frm)
        {
            InitializeComponent();
            _frmManufacturer = frm as frmManufacturer;
            _manufacturerList = new List<BML.Manufacturer>();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string mobile = txtMobile.Text;
                string name = txtName.Text;
                string address = richTxtAddress.Text;
                string detail = richTextDetail.Text;

                var manufacturerBAL = new BAL.Manufacturer(Helper.GetConnectionStringFromSettings());
                int result = await manufacturerBAL.CreateManufacturerAsync(name, address, mobile, detail);
                if (result == 1)
                {
                    LoadGridDataManufacturer();
                    MessageBox.Show("Manufacturer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Manufacturer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Check if the Name field is empty
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter the Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Mobile field is empty
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("Please enter the Mobile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Address field is empty
            if (string.IsNullOrEmpty(richTxtAddress.Text))
            {
                MessageBox.Show("Please enter the Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Detail field is empty
            if (string.IsNullOrEmpty(richTextDetail.Text))
            {
                MessageBox.Show("Please enter the Detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validation passed
            return true;
        }

        private async void LoadGridDataManufacturer()
        {
            try
            {
                var cmbManufacturerBal = new BAL.Manufacturer(Helper.GetConnectionStringFromSettings());
                _manufacturerList = await cmbManufacturerBal.GetManufacturersAsync();

                // Bind the data to the grid
                _frmManufacturer.dataGridViewManufacturer.DataSource = _manufacturerList;
                _frmManufacturer.dataGridViewManufacturer.Columns["ManufacturerId"].HeaderText = "Id";
                _frmManufacturer.dataGridViewManufacturer.Columns["ManufacturerName"].HeaderText = "Name";
                _frmManufacturer.dataGridViewManufacturer.Columns["ManufacturerAddress"].HeaderText = "Address";
                _frmManufacturer.dataGridViewManufacturer.Columns["ManufacturerMobile"].HeaderText = "Mobile";
                _frmManufacturer.dataGridViewManufacturer.Columns["ManufacturerDetails"].HeaderText = "Details";

                _frmManufacturer.dataGridViewManufacturer.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string mobile = txtMobile.Text;
                string name = txtName.Text;
                string address = richTxtAddress.Text;
                string detail = richTextDetail.Text;

                var manufacturerBAL = new BAL.Manufacturer(Helper.GetConnectionStringFromSettings());
                int result = await manufacturerBAL.CreateManufacturerAsync(name, address, mobile, detail);
                if (result == 1)
                {
                    LoadGridDataManufacturer();
                    MessageBox.Show("Manufacturer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var frm = new frmRegisterManufacturer(_frmManufacturer);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register Manufacturer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
