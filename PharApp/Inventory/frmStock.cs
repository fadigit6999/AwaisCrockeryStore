using BML;
using ClosedXML.Excel;
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
    public partial class frmStock : Form
    {
        public BindingList<BML.ViewStock> originalStockList;
        public BindingList<BML.ViewStock> filteredStockList;

        private List<BML.ViewStock> _stockList;

        public IReadOnlyList<BML.ViewStock> StockList => _stockList.AsReadOnly();
        public frmStock()
        {
            InitializeComponent();
            _stockList = new List<BML.ViewStock>();
        }

        private async void LoadGridDataStock()
        {
            try
            {
                var cmbStockBal = new BAL.Stock(Helper.GetConnectionStringFromSettings());
                var stockList = await cmbStockBal.GetViewStockAsync();

                originalStockList = new BindingList<BML.ViewStock>(stockList);
                filteredStockList = new BindingList<BML.ViewStock>(stockList);
                dataGridViewStock.DataSource = filteredStockList;

                // Bind the data to the grid
                //dataGridViewMedicine.DataSource = _medicinList;
                dataGridViewStock.Columns["SL"].HeaderText = "SL.";
                dataGridViewStock.Columns["MedName"].HeaderText = "Item Name";
                dataGridViewStock.Columns["ManufacturerName"].HeaderText = "Mfg.";
                dataGridViewStock.Columns["SalePrice"].HeaderText = "Sale Price";
                dataGridViewStock.Columns["PurchasePrice"].HeaderText = "Purchase Price";
                dataGridViewStock.Columns["InQuantity"].HeaderText = "In Quantity";
                dataGridViewStock.Columns["SoldQuantity"].HeaderText = "Sold Quantity";
                dataGridViewStock.Columns["Stock"].HeaderText = "Stock";
                dataGridViewStock.Columns["StockSellPrice"].HeaderText = "Stock Sell Price";
                dataGridViewStock.Columns["StockPurchasePrice"].HeaderText = "Stock Purchase Price";
                dataGridViewStock.Columns["BatchId"].HeaderText = "Item Code";

                dataGridViewStock.Columns["SL"].DisplayIndex = 0;
                dataGridViewStock.Columns["MedName"].DisplayIndex = 1;
                dataGridViewStock.Columns["ManufacturerName"].DisplayIndex = 2;
                dataGridViewStock.Columns["BatchId"].DisplayIndex = 3;
                dataGridViewStock.Columns["SalePrice"].DisplayIndex = 4;
                dataGridViewStock.Columns["PurchasePrice"].DisplayIndex = 5;
                dataGridViewStock.Columns["InQuantity"].DisplayIndex = 6;
                dataGridViewStock.Columns["SoldQuantity"].DisplayIndex = 7;
                dataGridViewStock.Columns["Stock"].DisplayIndex = 8;
                dataGridViewStock.Columns["StockSellPrice"].DisplayIndex = 9;
                dataGridViewStock.Columns["StockPurchasePrice"].DisplayIndex = 10;

                dataGridViewStock.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filterText))
            {
                filteredStockList = new BindingList<ViewStock>(originalStockList);
            }
            else
            {
                var filteredList = originalStockList.Where(stock =>
                    (stock.SL != null && stock.SL.ToLower().Contains(filterText)) ||
                    (stock.MedName != null && stock.MedName.ToLower().Contains(filterText)) ||
                    (stock.ManufacturerName != null && stock.ManufacturerName.ToLower().Contains(filterText)) ||
                    (stock.SalePrice != null && stock.SalePrice.ToLower().Contains(filterText)) ||
                    (stock.PurchasePrice != null && stock.PurchasePrice.ToLower().Contains(filterText)) ||
                    (stock.InQuantity != null && stock.InQuantity.ToLower().Contains(filterText)) ||
                    (stock.SoldQuantity != null && stock.SoldQuantity.ToLower().Contains(filterText)) ||
                    (stock.Stock != null && stock.Stock.ToLower().Contains(filterText)) ||
                    (stock.StockSellPrice != null && stock.StockSellPrice.ToLower().Contains(filterText)) ||
                    (stock.StockPurchasePrice != null && stock.StockPurchasePrice.ToLower().Contains(filterText)) ||
                    (stock.BatchId != null && stock.BatchId.ToLower().Contains(filterText))
                ).ToList();

                filteredStockList = new BindingList<ViewStock>(filteredList);
            }

            dataGridViewStock.DataSource = filteredStockList;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            LoadGridDataStock();
        }

        private void btnExportInventory_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dataGridViewStock, saveFileDialog.FileName);
            }
        }

        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            // Check if the DataGridView is empty
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create a new workbook
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Column headers
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                }

                // Rows
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Auto-fit columns
                worksheet.Columns().AdjustToContents();

                // Save the Excel file
                workbook.SaveAs(filePath);

                MessageBox.Show("Exported successfully.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
