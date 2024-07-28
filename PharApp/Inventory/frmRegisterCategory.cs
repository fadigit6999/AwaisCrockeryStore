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

namespace PharApp.Inventory
{
    public partial class frmRegisterCategory : Form
    {
        public frmMedicine _frmMedicine = null;
        private List<BML.Category> _categoryList;

        public IReadOnlyList<BML.Category> CategoryList => _categoryList.AsReadOnly();
        private readonly string _categoryId = null;
        public frmRegisterCategory(Form frm, string categoryId = null)
        {
            InitializeComponent();
            _frmMedicine = frm as frmMedicine;
            _categoryList = new List<BML.Category>();
            _categoryId = categoryId;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string Name = txtName.Text;
                string NameUrdu = txtNameUrdu.Text;
                var unitBAL = new BAL.Category(Helper.GetConnectionStringFromSettings());
                int result = await unitBAL.CreateCategoryAsync(Name, NameUrdu);
                if (result == 1)
                {
                    Helper.Log($"Category Created:Name {Name},Urdu Name: {NameUrdu}");
                    ReLoadGridDataCategory();
                    MessageBox.Show("Category registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrWhiteSpace(txtNameUrdu.Text))
            {
                MessageBox.Show("Please enter the Category in Urdu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {
            


            if (ValidateInput())
            {
                string Name = txtName.Text;
                string NameUrdu = txtNameUrdu.Text;
                var unitBAL = new BAL.Category(Helper.GetConnectionStringFromSettings());
                int result = await unitBAL.CreateCategoryAsync(Name,NameUrdu);
                if (result == 1)
                {
                    Helper.Log($"Category Created:Name {Name}, Urdu Name: {NameUrdu}");
                    ReLoadGridDataCategory();
                    MessageBox.Show("Category registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var frmCategory = new frmRegisterCategory(_frmMedicine);
                    frmCategory.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register Category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ReLoadGridDataCategory()
        {
            try
            {
                var cmbCategoryBal = new BAL.Category(Helper.GetConnectionStringFromSettings());
                _categoryList = await cmbCategoryBal.GetCategoriesAsync();
                _frmMedicine.dataGridViewMedicineCategory.DataSource = null;
                // Bind the data to the grid
                _frmMedicine.dataGridViewMedicineCategory.DataSource = _categoryList;
                _frmMedicine.dataGridViewMedicineCategory.Columns["CategoryId"].HeaderText = "Category Id";
                _frmMedicine.dataGridViewMedicineCategory.Columns["CategoryName"].HeaderText = "Item Category";
                _frmMedicine.dataGridViewMedicineCategory.Columns["CategoryNameUrdu"].HeaderText = "Item Category Urdu";


                _frmMedicine.dataGridViewMedicineCategory.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmRegisterCategory_Load(object sender, EventArgs e)
        {
            if (_categoryId is not null)
            {
                var categoryBAL = new BAL.Category(Helper.GetConnectionStringFromSettings());
                var categorylist = await categoryBAL.GetCategoriesAsync();
                var singleUnit = categorylist.Where(x => x.CategoryId == _categoryId).FirstOrDefault();
                txtName.Text = singleUnit.CategoryName;
                btnRegister.Visible = false;
                btnRegisterAddOther.Visible = false;

            }
            else
            {
                btnUpdate.Visible = false;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string Name = txtName.Text;
                string NameUrdu = txtNameUrdu.Text;
                var unitBAL = new BAL.Category(Helper.GetConnectionStringFromSettings());
                int result = await unitBAL.UpdateCategoryAsync(_categoryId,Name,NameUrdu);
                if (result == 1)
                {
                    Helper.Log($"Category Updated:Name {Name},Name Urdu: {NameUrdu}");
                    ReLoadGridDataCategory();
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to updated Category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
