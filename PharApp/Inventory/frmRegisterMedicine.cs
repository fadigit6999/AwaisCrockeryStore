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

namespace PharApp.Inventory
{
    public partial class frmRegisterMedicine : Form
    {
        private List<BML.Medicine> _medicinList;

        public IReadOnlyList<BML.Medicine> MedicineList => _medicinList.AsReadOnly();
        // Define a custom event
        public frmMedicine _frmMedicine = null;

        private readonly string _medId = null;

        public frmRegisterMedicine(Form frmMedicine, string medId = null)
        {
            InitializeComponent();
            _frmMedicine = frmMedicine as frmMedicine;
            _medicinList = new List<BML.Medicine>();
            _medId = medId;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string Name = txtName.Text;
                string NameUrdu = txtNameUrdu.Text;
                string Strength = txtStrength.Text;
                string GenericName = txtGenericName.Text;
                string medicine_shelf = txtMedicineShelf.Text;
                string BoxSize = txtBoxSize.Text;
                string Unit = cmbUnit.SelectedValue.ToString();
                string CategoryId = cmbCategory.SelectedValue.ToString();
                string MedicineTypeId = cmbType.SelectedValue.ToString();
                string ManufacturerId = cmbManufacturer.SelectedValue.ToString();
                decimal ManufacturerPrice = Convert.ToDecimal(txtMnfPrice.Text);
                decimal SellPrice = Convert.ToDecimal(txtSellPrice.Text);
                string Details = rtxtDetails.Text;

                var medinceBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                int result = await medinceBal.CreateMedicineAsync("", Name, Strength, GenericName, BoxSize, Unit, medicine_shelf, Details, MedicineTypeId, "", CategoryId, SellPrice, ManufacturerId, ManufacturerPrice,NameUrdu);

                if (result == 1)
                {
                    Helper.Log($"Medicine Created:Name {Name}, Manu. Price {ManufacturerPrice},Sale Price {SellPrice}");
                    ReLoadGridDataMedicine();
                    MessageBox.Show("Medicine registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register medicine. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private BML.Medicine GetMedicineFromForm()
        {
            BML.Medicine medicine = new BML.Medicine();
            return medicine;
        }

        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter the medicine name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtStrength.Text))
            {
                MessageBox.Show("Please enter the strength of the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtGenericName.Text))
            {
                MessageBox.Show("Please enter the generic name of the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxSize.Text))
            {
                MessageBox.Show("Please enter the Box Size of the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the Manufacturer, Mnf Price, and Sell Price fields are valid
            if (string.IsNullOrEmpty(cmbUnit.Text) || cmbUnit.Text == "Choose Unit" || cmbUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Unit of the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbCategory.Text) || cmbCategory.Text == "Choose Category" || cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Category of the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbType.Text) || cmbType.Text == "Choose Type" || cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Type of the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbManufacturer.Text) || cmbManufacturer.Text == "Choose Manufacturer" || cmbManufacturer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the manufacturer of the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal mnfPrice;
            if (!decimal.TryParse(txtMnfPrice.Text, out mnfPrice) || mnfPrice <= 0)
            {
                MessageBox.Show("Please enter a valid manufacturer price for the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal sellPrice;
            if (!decimal.TryParse(txtSellPrice.Text, out sellPrice) || sellPrice <= 0)
            {
                MessageBox.Show("Please enter a valid selling price for the medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validation passed
            return true;
        }

        private async void PopulateComboBoxUnit()
        {
            try
            {
                var cmbUnitBal = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                List<BML.Unit> cmbUnitList = await cmbUnitBal.GetUnitsAsync();

                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> unitDictionary = new Dictionary<string, string>();
                unitDictionary.Add("Choose Unit", Guid.NewGuid().ToString());
                // Populate the dictionary with category names and IDs
                foreach (var category in cmbUnitList)
                {
                    unitDictionary.Add(category.UnitName, category.UnitId);
                }

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbUnit.DataSource = new BindingSource(unitDictionary, null);
                cmbUnit.DisplayMember = "Key"; // Display category names
                cmbUnit.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PopulateComboBoxCategory()
        {
            try
            {
                var cmbCategoryBal = new BAL.Category(Helper.GetConnectionStringFromSettings());
                List<BML.Category> cmbCategoryList = await cmbCategoryBal.GetCategoriesAsync();

                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> categoryDictionary = new Dictionary<string, string>();
                categoryDictionary.Add("Choose Category", Guid.NewGuid().ToString());
                // Populate the dictionary with category names and IDs
                foreach (var category in cmbCategoryList)
                {
                    categoryDictionary.Add(category.CategoryName, category.CategoryId);
                }

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbCategory.DataSource = new BindingSource(categoryDictionary, null);
                cmbCategory.DisplayMember = "Key"; // Display category names
                cmbCategory.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PopulateComboBoxType()
        {
            try
            {
                var cmbTypeBal = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                List<BML.MedType> cmbTypeList = await cmbTypeBal.GetMedicineTypesAsync();

                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> typeDictionary = new Dictionary<string, string>();
                typeDictionary.Add("Choose Type", Guid.NewGuid().ToString());
                // Populate the dictionary with category names and IDs
                foreach (var type in cmbTypeList)
                {
                    typeDictionary.Add(type.TypeName, type.MedicineTypeId);
                }

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbType.DataSource = new BindingSource(typeDictionary, null);
                cmbType.DisplayMember = "Key"; // Display category names
                cmbType.ValueMember = "Value"; // Use category IDs as values

            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PopulateComboBoxManufacturer()
        {
            try
            {
                try
                {
                    var cmbManufacturerBal = new BAL.Manufacturer(Helper.GetConnectionStringFromSettings());
                    List<BML.Manufacturer> cmbManufacturerList = await cmbManufacturerBal.GetManufacturersAsync();

                    // Create a dictionary to hold the category names and IDs
                    Dictionary<string, string> ManufacturerDictionary = new Dictionary<string, string>();
                    ManufacturerDictionary.Add("Choose Manufacturer", Guid.NewGuid().ToString());
                    // Populate the dictionary with category names and IDs
                    foreach (var type in cmbManufacturerList)
                    {
                        ManufacturerDictionary.Add(type.ManufacturerName, type.ManufacturerId);
                    }

                    // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                    cmbManufacturer.DataSource = new BindingSource(ManufacturerDictionary, null);
                    cmbManufacturer.DisplayMember = "Key"; // Display category names
                    cmbManufacturer.ValueMember = "Value"; // Use category IDs as values

                }
                catch (Exception ex)
                {
                    // Handle exceptions, log, or show error message
                    MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmRegisterMedicine_Load(object sender, EventArgs e)
        {
            PopulateComboBoxUnit();
            PopulateComboBoxCategory();
            PopulateComboBoxType();
            PopulateComboBoxManufacturer();

            if (_medId is not null)
            {
                var medBAL = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                var medics = await medBAL.GetMedicinesAsync(_medId);
                txtName.Text = medics.Name;
                txtStrength.Text = medics.Strength;
                txtGenericName.Text = medics.GenericName;
                txtBoxSize.Text = medics.BoxSize;
                txtMedicineShelf.Text = medics.MedicineShelf;
                cmbUnit.SelectedValue = medics.Unit;
                cmbCategory.SelectedValue = medics.CategoryId;
                cmbType.SelectedValue = medics.MedicineTypeId;
                cmbManufacturer.SelectedValue = medics.ManufacturerId;
                txtMnfPrice.Text = medics.ManufacturerPrice?.ToString("F2");
                txtSellPrice.Text = medics.SellPrice?.ToString("F2");
                rtxtDetails.Text = medics.Details;
                btnRegister.Visible = false;
                btnRegisterAddOther.Visible = false;

            }
            else
            {

                txtMnfPrice.Text = "0.00";
                txtSellPrice.Text = "0.00";
                btnUpdate.Visible = false;
            }

        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                string Name = txtName.Text;
                string NameUrdu = txtNameUrdu.Text;
                string Strength = txtStrength.Text;
                string GenericName = txtGenericName.Text;
                string medicine_shelf = txtMedicineShelf.Text;
                string BoxSize = txtBoxSize.Text;
                string Unit = cmbUnit.SelectedValue.ToString();
                string CategoryId = cmbCategory.SelectedValue.ToString();
                string MedicineTypeId = cmbType.SelectedValue.ToString();
                string ManufacturerId = cmbManufacturer.SelectedValue.ToString();
                decimal ManufacturerPrice = Convert.ToDecimal(txtMnfPrice.Text);
                decimal SellPrice = Convert.ToDecimal(txtSellPrice.Text);
                string Details = rtxtDetails.Text;

                var medinceBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                int result = await medinceBal.CreateMedicineAsync("", Name, Strength, GenericName, BoxSize, Unit, medicine_shelf, Details, MedicineTypeId, "", CategoryId, SellPrice, ManufacturerId, ManufacturerPrice,NameUrdu);
                if (result == 1)
                {
                    Helper.Log($"Medicine Created:Name {Name}, Manu. Price {ManufacturerPrice},Sale Price {SellPrice}");
                    ReLoadGridDataMedicine();

                    MessageBox.Show("Medicine registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    var frm = new frmRegisterMedicine(_frmMedicine);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register medicine. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMnfPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            // Allow control characters like backspace and delete
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Allow digits (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Allow a single decimal point and ensure it's not already present
            if (e.KeyChar == '.' && !textBox.Text.Contains('.'))
            {
                e.Handled = false;
                return;
            }

            // Block any other character input
            e.Handled = true;

        }

        private void txtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            // Allow control characters like backspace and delete
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Allow digits (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Allow a single decimal point and ensure it's not already present
            if (e.KeyChar == '.' && !textBox.Text.Contains('.'))
            {
                e.Handled = false;
                return;
            }

            // Block any other character input
            e.Handled = true;
        }

        private async void ReLoadGridDataMedicine()
        {
            try
            {
                // Retrieve data asynchronously
                var cmbMedicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                _medicinList = await cmbMedicineBal.GetMedicinesGroupAsync();
                _frmMedicine.originalMedicineList = new BindingList<BML.Medicine>(_medicinList);
                _frmMedicine.filteredMedicineList = new BindingList<BML.Medicine>(_medicinList);
                // Bind the data to the DataGridView
                _frmMedicine.dataGridViewMedicine.DataSource = null; // Reset the DataSource
                _frmMedicine.dataGridViewMedicine.DataSource = _medicinList;

                // Configure the DataGridView columns
                ConfigureDataGridViewColumns();

                // Refresh the DataGridView
                _frmMedicine.dataGridViewMedicine.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            var dgv = _frmMedicine.dataGridViewMedicine;

            dgv.Columns["MedicineId"].HeaderText = "Medicine Id";
            dgv.Columns["Name"].HeaderText = "Name";
            dgv.Columns["Strength"].HeaderText = "Strength";
            dgv.Columns["GenericName"].HeaderText = "Generic Name";
            dgv.Columns["BoxSize"].HeaderText = "Box Size";
            dgv.Columns["Unit"].HeaderText = "Unit";
            dgv.Columns["MedicineShelf"].HeaderText = "Medicine Shelf";
            dgv.Columns["Details"].HeaderText = "Details";
            dgv.Columns["MedicineTypeId"].HeaderText = "Type";
            dgv.Columns["CategoryId"].HeaderText = "Category";
            dgv.Columns["SellPrice"].HeaderText = "Sell Price";
            dgv.Columns["ManufacturerId"].HeaderText = "Manufacturer";
            dgv.Columns["ManufacturerPrice"].HeaderText = "Manufacturer Price";

            // Hide unnecessary columns
            dgv.Columns["Barcode"].Visible = false;
            dgv.Columns["Image"].Visible = false;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string Name = txtName.Text;
                string Strength = txtStrength.Text;
                string GenericName = txtGenericName.Text;
                string medicine_shelf = txtMedicineShelf.Text;
                string BoxSize = txtBoxSize.Text;
                string Unit = cmbUnit.SelectedValue.ToString();
                string CategoryId = cmbCategory.SelectedValue.ToString();
                string MedicineTypeId = cmbType.SelectedValue.ToString();
                string ManufacturerId = cmbManufacturer.SelectedValue.ToString();
                decimal ManufacturerPrice = Convert.ToDecimal(txtMnfPrice.Text);
                decimal SellPrice = Convert.ToDecimal(txtSellPrice.Text);
                string Details = rtxtDetails.Text;

                var medinceBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                int result = await medinceBal.UpdateMedicineAsync(_medId,"",Name,Strength,GenericName,BoxSize,Unit,medicine_shelf,Details,MedicineTypeId,"",CategoryId,SellPrice,ManufacturerId,ManufacturerPrice);

                if (result == 1)
                {
                    Helper.Log($"Medicine Updated:Name {Name}, Manu. Price {ManufacturerPrice},Sale Price {SellPrice}");
                    ReLoadGridDataMedicine();
                    MessageBox.Show($"Medicine ## {Name} ## updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update medicine. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
