using BML;
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
    public partial class frmExpiryStock : Form
    {
        public BindingList<BML.MedicineStockExpiry> originalStockList;
        public BindingList<BML.MedicineStockExpiry> filteredStockList;

        private List<BML.MedicineStockExpiry> _stockList;
        private readonly BAL.DashBoard _dashBoardService;

        public IReadOnlyList<BML.MedicineStockExpiry> StockList => _stockList.AsReadOnly();
        public frmExpiryStock()
        {
            InitializeComponent();
            _stockList = new List<BML.MedicineStockExpiry>();
            _dashBoardService = new BAL.DashBoard(Helper.GetConnectionStringFromSettings());
        }

        private async void LoadGridDataStock()
        {
            try
            {
                var stockList = await _dashBoardService.DashboardExpiryMedicsAsync();

                originalStockList = new BindingList<BML.MedicineStockExpiry>(stockList);
                filteredStockList = new BindingList<BML.MedicineStockExpiry>(stockList);
                dataGridViewStock.DataSource = filteredStockList;

                // Bind the data to the grid
                //dataGridViewMedicine.DataSource = _medicinList;
                dataGridViewStock.Columns["MedName"].HeaderText = "Name";
                dataGridViewStock.Columns["Expiry"].HeaderText = "Expiry Date";
                dataGridViewStock.Columns["BatchId"].HeaderText = "Batch";
                dataGridViewStock.Columns["Quantity"].HeaderText = "Quantity";

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
                filteredStockList = new BindingList<MedicineStockExpiry>(originalStockList);
            }
            else
            {
                var filteredList = originalStockList.Where(stock =>
                    (stock.MedName != null && stock.MedName.ToLower().Contains(filterText))
                ).ToList();

                filteredStockList = new BindingList<MedicineStockExpiry>(filteredList);
            }

            dataGridViewStock.DataSource = filteredStockList;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            LoadGridDataStock();
        }
    }
}
