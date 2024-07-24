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
    public partial class frmRegisterType : Form
    {
        private List<BML.MedType> _typeList;

        public IReadOnlyList<BML.MedType> TypeList => _typeList.AsReadOnly();

        public frmMedicine _frmMedicine = null;


        private readonly string _typeId = null;


        public frmRegisterType(Form frm, string typeId = null)
        {
            InitializeComponent();
            _frmMedicine = frm as frmMedicine;
            _typeList = new List<BML.MedType>();
            _typeId = typeId;
        }

        private bool ValidateInput()
        {
            // Check if the Name, Strength, and Generic Name fields are empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validation passed
            return true;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;


            if (ValidateInput())
            {
                var typeBAL = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                int result = await typeBAL.CreateMedicineTypeAsync(Name);
                if (result == 1)
                {
                    Helper.Log($"Item Type Created:Name {Name}");
                    LoadGridDataType();
                    MessageBox.Show("Item Type registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to register Type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnRegisterAddOther_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;


            if (ValidateInput())
            {
                var typeBAL = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                int result = await typeBAL.CreateMedicineTypeAsync(Name);
                if (result == 1)
                {
                    Helper.Log($"Type Created:Name {Name}");
                    LoadGridDataType();
                    MessageBox.Show("Teype registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    var frmType = new frmRegisterType(_frmMedicine);
                    frmType.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to register Type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadGridDataType()
        {
            try
            {
                var cmbTypeBal = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                _typeList = await cmbTypeBal.GetMedicineTypesAsync();
                _frmMedicine.dataGridViewMedicineType.DataSource = null;
                // Bind the data to the grid
                _frmMedicine.dataGridViewMedicineType.DataSource = _typeList;
                _frmMedicine.dataGridViewMedicineType.Columns["MedicineTypeId"].HeaderText = "Type Id";
                _frmMedicine.dataGridViewMedicineType.Columns["TypeName"].HeaderText = "Item Type";

                _frmMedicine.dataGridViewMedicineType.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmRegisterType_Load(object sender, EventArgs e)
        {
            if (_typeId is not null)
            {
                var typeBAL = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                var typelist = await typeBAL.GetMedicineTypesAsync();
                var singleUnit = typelist.Where(x => x.MedicineTypeId == _typeId).FirstOrDefault();
                txtName.Text = singleUnit.TypeName;
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
                var typeBAL = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                int result = await typeBAL.UpdateMedicineTypeAsync(_typeId,Name);
                if (result == 1)
                {
                    Helper.Log($"Item Type Updated:Name {Name}");
                    LoadGridDataType();
                    MessageBox.Show("Item type updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
