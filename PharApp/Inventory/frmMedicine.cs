﻿using BML;
using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PharApp.Inventory
{
    public partial class frmMedicine : Form
    {
        //search
        public BindingList<BML.Medicine> originalMedicineList;
        public BindingList<BML.Medicine> filteredMedicineList;

        private List<BML.MedType> _typeList;
        private List<BML.Category> _categoryList;
        private List<BML.Unit> _unitList;
        private List<BML.Medicine> _medicinList;

        public IReadOnlyList<BML.MedType> TypeList => _typeList.AsReadOnly();
        public IReadOnlyList<BML.Category> CategoryList => _categoryList.AsReadOnly();
        public IReadOnlyList<BML.Unit> UnitList => _unitList.AsReadOnly();
        public IReadOnlyList<BML.Medicine> MedicineList => _medicinList.AsReadOnly();

        public frmMedicine()
        {
            InitializeComponent();
            _typeList = new List<BML.MedType>();
            _categoryList = new List<BML.Category>();
            _unitList = new List<BML.Unit>();
            _medicinList = new List<BML.Medicine>();
        }

        private void btnRegisterMedicine_Click(object sender, EventArgs e)
        {
            var frmRegisterMedicine = new frmRegisterMedicine(this);
            frmRegisterMedicine.ShowDialog();
        }

        private void btnRegisterType_Click(object sender, EventArgs e)
        {
            var frmRegisterMedicineType = new frmRegisterType(this);
            frmRegisterMedicineType.ShowDialog();
        }

        private void btnRegisterCategory_Click(object sender, EventArgs e)
        {
            var frmRegisterMedicineCategory = new frmRegisterCategory(this);
            frmRegisterMedicineCategory.ShowDialog();
        }

        private void btnRegisterUnit_Click(object sender, EventArgs e)
        {
            var frmRegisterMedicineUnit = new frmRegisterUnit(this);
            frmRegisterMedicineUnit.ShowDialog();
        }

        private void frmMedicine_Load(object sender, EventArgs e)
        {
            LoadGridDataType();
            LoadGridDataCategory();
            LoadGridDataUnit();
            LoadGridDataMedicine();
        }

        private async void LoadGridDataType()
        {
            try
            {
                var cmbTypeBal = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                _typeList = await cmbTypeBal.GetMedicineTypesAsync();

                // Bind the data to the grid
                dataGridViewMedicineType.DataSource = _typeList;
                dataGridViewMedicineType.Columns["MedicineTypeId"].HeaderText = "Type Id";
                dataGridViewMedicineType.Columns["TypeName"].HeaderText = "Medicine Type";

                dataGridViewMedicineType.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadGridDataCategory()
        {
            try
            {
                var cmbCategoryBal = new BAL.Category(Helper.GetConnectionStringFromSettings());
                _categoryList = await cmbCategoryBal.GetCategoriesAsync();

                // Bind the data to the grid
                dataGridViewMedicineCategory.DataSource = _categoryList;
                dataGridViewMedicineCategory.Columns["CategoryId"].HeaderText = "Category Id";
                dataGridViewMedicineCategory.Columns["CategoryName"].HeaderText = "Medicine Category";

                dataGridViewMedicineCategory.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadGridDataUnit()
        {
            try
            {
                var cmbUnitBal = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                _unitList = await cmbUnitBal.GetUnitsAsync();

                // Bind the data to the grid
                dataGridViewMedicineUnit.DataSource = _unitList;
                dataGridViewMedicineUnit.Columns["UnitId"].HeaderText = "Id";
                dataGridViewMedicineUnit.Columns["UnitName"].HeaderText = "Medicine Unit";

                dataGridViewMedicineUnit.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadGridDataMedicine()
        {
            try
            {
                var cmbMedicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                var medicineList = await cmbMedicineBal.GetMedicinesGroupAsync();

                originalMedicineList = new BindingList<BML.Medicine>(medicineList);
                filteredMedicineList = new BindingList<BML.Medicine>(medicineList);
                dataGridViewMedicine.DataSource = filteredMedicineList;

                // Bind the data to the grid
                //dataGridViewMedicine.DataSource = _medicinList;
                dataGridViewMedicine.Columns["MedicineId"].HeaderText = "Id";
                dataGridViewMedicine.Columns["Name"].HeaderText = "Name";
                dataGridViewMedicine.Columns["Strength"].HeaderText = "Strength";
                dataGridViewMedicine.Columns["GenericName"].HeaderText = "Gen. Name";
                dataGridViewMedicine.Columns["BoxSize"].HeaderText = "Box Size";
                dataGridViewMedicine.Columns["Unit"].HeaderText = "Unit";
                dataGridViewMedicine.Columns["MedicineShelf"].HeaderText = "Med. Shelf";
                dataGridViewMedicine.Columns["Details"].HeaderText = "Details";
                dataGridViewMedicine.Columns["MedicineTypeId"].HeaderText = "Type";
                dataGridViewMedicine.Columns["CategoryId"].HeaderText = "Category";
                dataGridViewMedicine.Columns["SellPrice"].HeaderText = "Sell Price";
                dataGridViewMedicine.Columns["ManufacturerId"].HeaderText = "Man.";
                dataGridViewMedicine.Columns["ManufacturerPrice"].HeaderText = "Man. Price";

                dataGridViewMedicine.Columns["Barcode"].Visible = false;
                dataGridViewMedicine.Columns["Image"].Visible = false;

                dataGridViewMedicine.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicine_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewMedicine.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewMedicine.ClearSelection();
                dataGridViewMedicine.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripMedGrid.Show(dataGridViewMedicine, e.Location);
            }
        }

        private void dataGridViewMedicine_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //// Check if it's a right-click
            //if (e.Button == MouseButtons.Right)
            //{

            //}
        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewMedicine.SelectedRows.Count > 0)
            {
                string name = dataGridViewMedicine.SelectedRows[0].Cells["Name"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string medicineId = dataGridViewMedicine.SelectedRows[0].Cells["MedicineId"].Value.ToString();


                    var medinceBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                    var success = await medinceBal.DeleteMedicineAsync(medicineId);
                    if (success == 1)
                    {
                        Helper.Log($"Medicine Deleted:Name {name},");
                        LoadGridDataMedicine();
                        // Show success message
                        MessageBox.Show("Medicine deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicineUnit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        //Unit
        private void dataGridViewMedicineUnit_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewMedicineUnit.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewMedicineUnit.ClearSelection();
                dataGridViewMedicineUnit.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripUnitGrid.Show(dataGridViewMedicineUnit, e.Location);
            }
        }

        private async void deleteMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewMedicineUnit.SelectedRows.Count > 0)
            {
                string name = dataGridViewMedicineUnit.SelectedRows[0].Cells["UnitName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewMedicineUnit.SelectedRows[0].Cells["UnitId"].Value.ToString();

                    var unitBal = new BAL.Unit(Helper.GetConnectionStringFromSettings());
                    var success = await unitBal.DeleteUnitAsync(Id);
                    if (success == 1)
                    {
                        Helper.Log($"Unit Deleted:Name {name},");
                        LoadGridDataUnit();
                        // Show success message
                        MessageBox.Show("Unit deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine Unit to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Category
        private async void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewMedicineCategory.SelectedRows.Count > 0)
            {
                string name = dataGridViewMedicineCategory.SelectedRows[0].Cells["CategoryName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewMedicineCategory.SelectedRows[0].Cells["CategoryId"].Value.ToString();

                    var categoryBal = new BAL.Category(Helper.GetConnectionStringFromSettings());
                    var success = await categoryBal.DeleteCategoryAsync(Id);
                    if (success == 1)
                    {
                        Helper.Log($"Category Deleted:Name {name},");
                        LoadGridDataCategory();
                        // Show success message
                        MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine Category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicineCategory_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewMedicineCategory.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewMedicineCategory.ClearSelection();
                dataGridViewMedicineCategory.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripCategory.Show(dataGridViewMedicineCategory, e.Location);
            }
        }

        //Type
        private async void deleteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewMedicineType.SelectedRows.Count > 0)
            {
                string name = dataGridViewMedicineType.SelectedRows[0].Cells["TypeName"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = dataGridViewMedicineType.SelectedRows[0].Cells["MedicineTypeId"].Value.ToString();

                    var typeBal = new BAL.MedType(Helper.GetConnectionStringFromSettings());
                    var success = await typeBal.DeleteMedicineTypeAsync(Id);
                    if (success == 1)
                    {
                        Helper.Log($"Type Deleted:Name {name},");
                        LoadGridDataType();
                        // Show success message
                        MessageBox.Show("Type deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine Type to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicineType_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewMedicineType.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewMedicineType.ClearSelection();
                dataGridViewMedicineType.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripType.Show(dataGridViewMedicineType, e.Location);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filterText))
            {
                filteredMedicineList = new BindingList<BML.Medicine>(originalMedicineList);
            }
            else
            {
                var filteredList = originalMedicineList.Where(medicine =>
                    medicine.MedicineId.ToString().ToLower().Contains(filterText) ||
                    medicine.Name.ToLower().Contains(filterText) ||
                    medicine.Strength.ToLower().Contains(filterText) ||
                    medicine.GenericName.ToLower().Contains(filterText) ||
                    medicine.BoxSize.ToString().ToLower().Contains(filterText) ||
                    medicine.Unit.ToLower().Contains(filterText) ||
                    medicine.MedicineShelf.ToLower().Contains(filterText) ||
                    medicine.Details.ToLower().Contains(filterText) ||
                    medicine.MedicineTypeId.ToString().ToLower().Contains(filterText) ||
                    medicine.CategoryId.ToString().ToLower().Contains(filterText) ||
                    medicine.SellPrice.ToString().ToLower().Contains(filterText) ||
                    medicine.ManufacturerId.ToString().ToLower().Contains(filterText) ||
                    medicine.ManufacturerPrice.ToString().ToLower().Contains(filterText)
                ).ToList();

                filteredMedicineList = new BindingList<BML.Medicine>(filteredList);
            }

            dataGridViewMedicine.DataSource = filteredMedicineList;
        }
        //Update by menu strip
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewMedicine.SelectedRows.Count > 0)
            {
                string name = dataGridViewMedicine.SelectedRows[0].Cells["Name"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to Update this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string medicineId = dataGridViewMedicine.SelectedRows[0].Cells["MedicineId"].Value.ToString();


                    var medinceBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                    var frm = new frmRegisterMedicine(this,medicineId);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
