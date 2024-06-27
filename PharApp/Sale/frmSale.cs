using BML;
using PharApp.RdlcReports.Purchase;
using PharApp.RdlcReports.Sale;
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

namespace PharApp.Sale
{
    public partial class frmSale : Form
    {
        private BindingList<ViewSale> originalBindingList;
        private BindingList<ViewSale> filteredBindingList;
        public frmSale()
        {
            InitializeComponent();
        }
        private void frmSale_Load(object sender, EventArgs e)
        {
            PopulateComboBoxBooker();
            PopulateComboBoxSupplier();
            PopulateComboBoxCustomer();
            PopulateComboBoxMedicine();
            PopulateComboBoxPaymentType();
            PopulateComboBoxArea();
            LoadFutureInvoice();
            DefaultDetails();
            ClearDetailsGrid();
            LoadGridDataViewSale();
        }
        private async void PopulateComboBoxCustomer()
        {
            try
            {
                try
                {
                    var cmbCustomerBal = new BAL.Customer(Helper.GetConnectionStringFromSettings());
                    List<BML.Customer> cmbManufacturerList = await cmbCustomerBal.GetCustomersAsync();

                    // Create a dictionary to hold the category names and IDs
                    Dictionary<string, string> ManufacturerDictionary = new Dictionary<string, string>();
                    ManufacturerDictionary.Add("Choose Customer", Guid.NewGuid().ToString());
                    // Populate the dictionary with category names and IDs
                    foreach (var type in cmbManufacturerList)
                    {
                        ManufacturerDictionary.Add(type.FullName, type.CustomerID);
                    }

                    // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                    cmbCustomer.DataSource = new BindingSource(ManufacturerDictionary, null);
                    cmbCustomer.DisplayMember = "Key"; // Display category names
                    cmbCustomer.ValueMember = "Value"; // Use category IDs as values

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
        private async void PopulateComboBoxMedicine()
        {
            try
            {
                try
                {
                    var cmbMedicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                    List<BML.Medicine> cmbMedicineList = await cmbMedicineBal.GetMedicinesDropdownStockBasedGroupAsync();


                    Dictionary<string, string> MedicineDictionary = new Dictionary<string, string>();
                    MedicineDictionary.Add("Choose Item", Guid.NewGuid().ToString());

                    foreach (var medicine in cmbMedicineList)
                    {
                        MedicineDictionary.Add($"{medicine.Name}({medicine.Strength}{medicine.Unit}-{medicine.BoxSize})", medicine.MedicineId);
                    }

                    cmbMedInformation.DataSource = new BindingSource(MedicineDictionary, null);
                    cmbMedInformation.DisplayMember = "Key";
                    cmbMedInformation.ValueMember = "Value";

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while populating units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PopulateComboBoxPaymentType()
        {
            try
            {
                try
                {
                    var cmbPaymentTypeBal = new BAL.PaymentType(Helper.GetConnectionStringFromSettings());
                    List<BML.PaymentType> cmbPaymentTypeList = await cmbPaymentTypeBal.GetPaymentTypesAsync();


                    Dictionary<string, string> pTypeDictionary = new Dictionary<string, string>();
                    pTypeDictionary.Add("Choose Payment Type", Guid.NewGuid().ToString());
                    if (cmbPaymentTypeList != null && cmbPaymentTypeList.Count > 0)
                    {
                        foreach (var pt in cmbPaymentTypeList)
                        {
                            pTypeDictionary.Add(pt.TypeName, pt.PaymentTypeId);
                        }
                    }


                    cmbPaymentType.DataSource = new BindingSource(pTypeDictionary, null);
                    cmbPaymentType.DisplayMember = "Key";
                    cmbPaymentType.ValueMember = "Value";

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error while populating Payment Type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while populating Payment Type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PopulateComboBoxArea()
        {
            try
            {
                try
                {
                    var cmbAreaBal = new BAL.Area(Helper.GetConnectionStringFromSettings());
                    List<BML.Area> cmbAreaList = await cmbAreaBal.GetAreasAsync();


                    Dictionary<string, string> pTypeDictionary = new Dictionary<string, string>();
                    pTypeDictionary.Add("Choose Area", Guid.NewGuid().ToString());

                    foreach (var pt in cmbAreaList)
                    {
                        pTypeDictionary.Add(pt.AreaName, pt.AreaId);
                    }

                    cmbArea.DataSource = new BindingSource(pTypeDictionary, null);
                    cmbArea.DisplayMember = "Key";
                    cmbArea.ValueMember = "Value";

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error while populating Payment Type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while populating Payment Type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PopulateComboBoxBooker()
        {
            try
            {
                try
                {
                    var cmbBookerBal = new BAL.Booker(Helper.GetConnectionStringFromSettings());
                    List<BML.Booker> cmbBookerList = await cmbBookerBal.GetBookersAsync();


                    Dictionary<string, string> pTypeDictionary = new Dictionary<string, string>();
                    pTypeDictionary.Add("Choose Booker", Guid.NewGuid().ToString());

                    foreach (var pt in cmbBookerList)
                    {
                        pTypeDictionary.Add(pt.Name, pt.BookerID);
                    }
                    //combobox
                    cmbBooker.DataSource = new BindingSource(pTypeDictionary, null);
                    cmbBooker.DisplayMember = "Key";
                    cmbBooker.ValueMember = "Value";

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error while populating Booker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while populating Booker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PopulateComboBoxSupplier()
        {
            try
            {
                try
                {
                    var cmbSupplierBal = new BAL.Supplier(Helper.GetConnectionStringFromSettings());
                    List<BML.Supplier> cmbSupplierList = await cmbSupplierBal.GetSuppliersAsync();


                    Dictionary<string, string> pTypeDictionary = new Dictionary<string, string>();
                    pTypeDictionary.Add("Choose Supplier", Guid.NewGuid().ToString());

                    foreach (var pt in cmbSupplierList)
                    {
                        pTypeDictionary.Add(pt.Name, pt.SupplierID);
                    }

                    cmbSupplier.DataSource = new BindingSource(pTypeDictionary, null);
                    cmbSupplier.DisplayMember = "Key";
                    cmbSupplier.ValueMember = "Value";

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error while populating Supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error while populating Supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadFutureInvoice()
        {
            var saleOrderBal = new BAL.SaleOrder(Helper.GetConnectionStringFromSettings());
            string futureInvoiceNumber = await saleOrderBal.GetNextInvoiceNumberAsync();


            if (futureInvoiceNumber != null)
            {
                txtInvoice.Text = futureInvoiceNumber;
            }
            else
            {
                txtInvoice.Text = futureInvoiceNumber;
            }
        }
        private void UpdateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
            {
                // Skip the row if it is a new row or if the cell value is null or empty
                if (!row.IsNewRow && row.Cells["TotalColumn"].Value != null)
                {
                    // Convert the cell value to a decimal and add it to the grand total
                    grandTotal += Convert.ToDecimal(row.Cells["TotalColumn"].Value);
                }
            }

            // Display the grand total in the txtGrandTotal TextBox
            txtTotal.Text = grandTotal.ToString();
            txtGrandTotal.Text = grandTotal.ToString();
        }
        private void dataGridViewPurchaseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSaleDetails.Columns["RemoveColumn"].Index)
            {
                // Remove the corresponding row
                dataGridViewSaleDetails.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void dataGridViewPurchaseDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the grand total when there is a change in the "Total" column
            if (e.ColumnIndex == dataGridViewSaleDetails.Columns["TotalColumn"].Index)
            {
                UpdateGrandTotal();
            }
        }
        private void dataGridViewPurchaseDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateGrandTotal();
        }
        private void dataGridViewPurchaseDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateGrandTotal();
        }
        private List<BML.PurchaseDetail> GetPurchaseDetailsFromGrid()
        {
            List<BML.PurchaseDetail> purchaseDetails = new List<BML.PurchaseDetail>();

            foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
            {
                if (!row.IsNewRow)
                {
                    BML.PurchaseDetail purchaseDetail = new BML.PurchaseDetail();

                    // Assuming the order of columns in the DataGridView matches the order of properties in the PurchaseDetail class
                    //purchaseDetail.MedInformation = row.Cells["MedInformationColumn"].Value.ToString();
                    //purchaseDetail.Batched = row.Cells["BatchedColumn"].Value.ToString();
                    purchaseDetail.ExpiryDate = Convert.ToDateTime(row.Cells["ExpiryDateColumn"].Value);
                    purchaseDetail.Quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    //purchaseDetail.ManufacturePrice = Convert.ToDecimal(row.Cells["ManufacturePriceColumn"].Value);
                    purchaseDetail.Total = Convert.ToDecimal(row.Cells["TotalColumn"].Value);

                    purchaseDetails.Add(purchaseDetail);
                }
            }

            return purchaseDetails;
        }
        private async void cmbMedInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Initialize BAL instances
            var medicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
            var stockBal = new BAL.Stock(Helper.GetConnectionStringFromSettings());

            // Retrieve list of medicines and stock asynchronously
            List<BML.Medicine> medicineList = await medicineBal.GetMedicinesGroupAsync();
            List<BML.Stock> stockList = await stockBal.GetMedicineStockAsync();

            // Get the selected Medicine ID from the combo box
            string selectedMedicineId = cmbMedInformation.SelectedValue.ToString();

            // Find the corresponding medicine and stock in the lists
            var selectedMedicine = medicineList.FirstOrDefault(m => m.MedicineId == selectedMedicineId);
            var selectedStock = stockList.Where(s => s.MedicineID == selectedMedicineId);
            if (selectedMedicine != null)
            {
                Dictionary<string, string> StockDictionary = new Dictionary<string, string>();
                StockDictionary.Add("Item Code", Guid.NewGuid().ToString());

                var addedBatchIds = new HashSet<string>();

                foreach (var stock in selectedStock)
                {
                    if (!addedBatchIds.Contains(stock.BatchID.ToString()))
                    {
                        StockDictionary.Add(stock.BatchID.ToUpper().ToString(), stock.MedicineID);
                        addedBatchIds.Add(stock.MedicineID.ToString());
                    }

                }

                cmbBatchId.DataSource = new BindingSource(StockDictionary, null);
                cmbBatchId.DisplayMember = "Key";
                cmbBatchId.ValueMember = "Value";
            }
        }
        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            if (ValidateDetails())
            {
                if (!CalculateStockQuantity())
                {
                    MessageBox.Show($"Medicine quantity is exceeding from stock quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Get values from text boxes
                    // Extract the selected value and text from the ComboBox
                    string medInformationId = cmbMedInformation.SelectedValue?.ToString();
                    string medInformation = cmbMedInformation.Text;
                    // Extract other information from the text boxes
                    string batchid = cmbBatchId.Text;
                    string expiryDate = txtExpiryDate.Text;
                    int quantity = Convert.ToInt32(txtSaleQnt.Text);
                    decimal manufacturePrice = Convert.ToDecimal(txtManfPrice.Text);
                    decimal gstTax = Convert.ToDecimal(txtGSTtx.Text);
                    int discountPercentage = Convert.ToInt32(txtDisc.Text);
                    string bonus = txtBonus.Text;

                    // Calculate the total before any discounts or taxes
                    decimal totalBeforeDiscount = quantity * manufacturePrice;

                    // Calculate the total after applying the discount
                    decimal totalAfterDiscount = totalBeforeDiscount * (1 - (decimal)discountPercentage / 100);

                    // Calculate the total with GST included
                    decimal totalWithTax = totalAfterDiscount * (1 + gstTax / 100);

                    // Calculate the total by summing up all the values
                    decimal total = totalWithTax;

                    // Add a new row to the DataGridView
                    dataGridViewSaleDetails.Rows.Add(medInformationId, medInformation, batchid, gstTax, discountPercentage, expiryDate, quantity, manufacturePrice, Math.Round(total, 2), "X");

                    txtAdvTax.Text = "";
                }

            }
        }
        private void dataGridViewPurchaseDetails_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the right mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // Get the cell at the clicked point
                DataGridView.HitTestInfo hitTestInfo = dataGridViewSaleDetails.HitTest(e.X, e.Y);

                // Check if a cell is clicked and it's in the RemoveColumn
                try
                {
                    if (hitTestInfo.RowIndex >= 0 &&
                    dataGridViewSaleDetails.Columns[hitTestInfo.ColumnIndex].Name == "RemoveColumn")
                    {
                        // Remove the corresponding row
                        dataGridViewSaleDetails.Rows.RemoveAt(hitTestInfo.RowIndex);
                    }
                }
                catch (Exception)
                {

                }

            }
        }
        private void txtAdvDisc_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAdvTax.Text, out decimal advTaxPercentage))
            {
                if (decimal.TryParse(txtTotal.Text, out decimal total))
                {
                    decimal advTaxAmount = total * (advTaxPercentage / 100);

                    decimal grandTotal = total + advTaxAmount;

                    txtGrandTotal.Text = grandTotal.ToString("0.00");
                }
            }
            else
            {
                txtGrandTotal.Text = txtTotal.Text;
            }
        }
        private bool ValidateDetails()
        {
            if (string.IsNullOrEmpty(cmbMedInformation.Text) || cmbMedInformation.Text == "Choose Item" || cmbMedInformation.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Batch ID validation
            if (string.IsNullOrEmpty(cmbBatchId.Text) || cmbBatchId.Text == "Item Code")
            {
                MessageBox.Show("Please enter Item Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //// Expiry Date validation
            //if (!DateTime.TryParse(dateTimeMedExpiry.Text, out DateTime expiryDate) || expiryDate < DateTime.Today)
            //{
            //    MessageBox.Show("Please enter a valid future Expiry Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            // Quantity validation
            if (!int.TryParse(txtSaleQnt.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid Quantity (greater than 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Manufacture Price validation
            if (!decimal.TryParse(txtManfPrice.Text, out decimal manufacturePrice) || manufacturePrice <= 0)
            {
                MessageBox.Show("Please enter a valid Manufacture Price (greater than 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // GST Tax validation
            if (!decimal.TryParse(txtGSTtx.Text, out decimal gstTax) || gstTax < 0)
            {
                MessageBox.Show("Please enter a valid GST Tax (greater than or equal to 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Discount Percentage validation
            if (!int.TryParse(txtDisc.Text, out int discountPercentage) || discountPercentage < 0 || discountPercentage > 100)
            {
                MessageBox.Show("Please enter a valid Discount Percentage (between 0 and 100).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (!int.TryParse(txtBonus.Text, out int bonus) || bonus < 0)
            //{
            //    MessageBox.Show("Please enter a valid Bonus (a non-negative integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            if (txtStockQuantity.Text == "0")
            {
                MessageBox.Show("Medicine is out of stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Bonus validation (optional)
            // You can add additional validations here as needed

            // All validations passed
            return true;
        }
        public void DefaultDetails()
        {
            // Set default values for the text boxes
            cmbMedInformation.Text = "Choose Item";
            cmbBatchId.DataSource = null;
            txtExpiryDate.Text = "MM/DD/YYYY";
            txtStockQuantity.Text = "";
            txtSaleQnt.Text = "1";
            txtManfPrice.Text = "0.00";
            txtGSTtx.Text = "0";
            txtDisc.Text = "0";
            txtBonus.Text = "0";
        }
        public void ClearDetailsGrid()
        {
            // Clear the DataGridView
            dataGridViewSaleDetails.DataSource = null;
            dataGridViewSaleDetails.Columns.Clear();

            // Add columns
            dataGridViewSaleDetails.Columns.Add("MedIdColumn", "Id");
            dataGridViewSaleDetails.Columns.Add("MedInformationColumn", "Item");
            dataGridViewSaleDetails.Columns.Add("BatchedColumn", "Item Code");
            dataGridViewSaleDetails.Columns.Add("GstTaxColumn", "GSTTx.");
            dataGridViewSaleDetails.Columns.Add("DsicColumn", "Disc");
            //dataGridViewSaleDetails.Columns.Add("BonusColumn", "Bonus");
            dataGridViewSaleDetails.Columns.Add("ExpiryDateColumn", "Ex. Date");
            dataGridViewSaleDetails.Columns.Add("QuantityColumn", "Qnt.");
            dataGridViewSaleDetails.Columns.Add("ManfPriceColumn", "Sale Price");
            dataGridViewSaleDetails.Columns.Add("TotalColumn", "Total");
            dataGridViewSaleDetails.Columns.Add("RemoveColumn", "Remove");
        }
        private async void btnPurchase_Click(object sender, EventArgs e)
        {
            if (ValidateOrder())
            {
                if (dataGridViewSaleDetails.Rows.Count == 0)
                {
                    MessageBox.Show("Please ensure there is at least one Medicine in the Sale details grid before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string orderId = Guid.NewGuid().ToString();
                    string detail = txtDetail.Text;
                    string invoice = txtInvoice.Text;
                    decimal totalDecimal = decimal.Parse(txtTotal.Text);
                    decimal grandTotalDecimal = decimal.Parse(txtGrandTotal.Text);
                    decimal advTaxDecimal;
                    string warrantry = string.Empty;
                    string Area = string.Empty;
                    string Booker = string.Empty;
                    string Supplier = string.Empty;
                    warrantry = "warranty";

                    if (string.IsNullOrEmpty(txtAdvTax.Text))
                    {
                        advTaxDecimal = 0;
                    }
                    else
                    {
                        decimal.TryParse(txtAdvTax.Text, out advTaxDecimal);
                    }

                    string purchaseDateStr = saleDate.Value.ToString("yyyy-MM-dd");
                    string paymentType = cmbPaymentType.SelectedValue?.ToString();
                    string customer = cmbCustomer.SelectedValue?.ToString();
                    Area = cmbArea.SelectedValue?.ToString();
                    Booker = cmbBooker.SelectedValue?.ToString();
                    Supplier = cmbSupplier.SelectedValue?.ToString();

                    //Order Process
                    var saleOrderBAL = new BAL.SaleOrder(Helper.GetConnectionStringFromSettings());
                    int result = await saleOrderBAL.CreateSaleOrderAsync(orderId, customer, Convert.ToDateTime(saleDate.Value), paymentType, invoice, totalDecimal, grandTotalDecimal, advTaxDecimal, warrantry, "", "", "");
                    Helper.Log("Sale Order Created: " + " ," + orderId + " ," + customer + " ," + Convert.ToDateTime(saleDate.Value) + " ," + paymentType + " ," + invoice + " ," + totalDecimal + " ," + grandTotalDecimal + " ," + advTaxDecimal);
                    if (result >= 1)
                    {
                        foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string purchaseDetailId = Guid.NewGuid().ToString();
                                string purchaseOrderId = orderId.ToString();
                                string medicineId = row.Cells["MedIdColumn"].Value?.ToString();
                                string batchId = row.Cells["BatchedColumn"].Value?.ToString();
                                DateTime expiryDate = DateTime.TryParse(row.Cells["ExpiryDateColumn"].Value?.ToString(), out DateTime tempExpiryDate) ? tempExpiryDate : DateTime.MinValue;
                                int quantity = int.TryParse(row.Cells["QuantityColumn"].Value?.ToString(), out int tempQuantity) ? tempQuantity : 0;
                                decimal total = decimal.TryParse(row.Cells["TotalColumn"].Value?.ToString(), out decimal tempTotal) ? tempTotal : 0;
                                decimal gstTax = decimal.TryParse(row.Cells["GstTaxColumn"].Value?.ToString(), out decimal tempGstTax) ? tempGstTax : 0;
                                decimal salePrice = decimal.TryParse(row.Cells["ManfPriceColumn"].Value?.ToString(), out decimal tempSalePrice) ? tempSalePrice : 0;
                                //int bonus = int.TryParse(row.Cells["BonusColumn"].Value?.ToString(), out int tempBonus) ? tempBonus : 0;
                                decimal distDisc = decimal.TryParse(row.Cells["DsicColumn"].Value?.ToString(), out decimal tempDistDisc) ? tempDistDisc : 0;
                                bool isWarranty = warrantry.Equals("warranty", StringComparison.OrdinalIgnoreCase);
                                var saleOrderDetailsBAL = new BAL.SaleDetail(Helper.GetConnectionStringFromSettings());
                                result = await saleOrderDetailsBAL.CreateSaleOrderDetailAsync(purchaseOrderId, medicineId, Helper.ProcessString(batchId), expiryDate, quantity, total, gstTax, 0, salePrice, distDisc, DateTime.UtcNow, isWarranty);
                                Helper.Log("Sale details Created: " + purchaseOrderId + " ," + medicineId + " ," + batchId + " ," + expiryDate + " ," + quantity + " ," + total + " ," + gstTax + " ," + salePrice + " ," + distDisc);
                                if (result >= 1)
                                {
                                    var stockBAL = new BAL.Stock(Helper.GetConnectionStringFromSettings());
                                    result = await stockBAL.SaleStockAsync("Sale", medicineId, batchId.ToString().ToLower().Replace(" ", ""), expiryDate, quantity, 0, 0);
                                    Helper.Log("Sale Stock Changes:" + medicineId + " ," + batchId.ToString().ToLower().Replace(" ", "") + " ," + expiryDate + " ," + quantity + " ," + 0 + " ," + 0);
                                }
                            }
                        }

                        if (result >= 1)
                        {
                            DefaultDetails();
                            ClearOrderValues();
                            ClearDetailsGrid();
                            LoadGridDataViewSale();
                            DialogResult msg = MessageBox.Show("Sale registered successfully. Do you want to print the Sale?",
                                    "Success",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                            if (msg == DialogResult.Yes)
                            {
                                var frm = new rptSale(orderId);
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to register the Sale. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private bool ValidateOrder()
        {
            if (string.IsNullOrEmpty(cmbCustomer.Text) || cmbCustomer.Text == "Choose Customer" || cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the ## Customer ## .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cmbPaymentType.Text) || cmbPaymentType.Text == "Choose Payment Type" || cmbPaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Payment Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (string.IsNullOrEmpty(cmbArea.Text) || cmbArea.Text == "Choose Area" || cmbArea.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please select the Area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            //if (string.IsNullOrEmpty(cmbBooker.Text) || cmbBooker.Text == "Choose Booker" || cmbBooker.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please select the Booker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            //if (string.IsNullOrEmpty(cmbSupplier.Text) || cmbSupplier.Text == "Choose Supplier" || cmbSupplier.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please select the Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            return true;
        }
        private void btnClearDetails_Click(object sender, EventArgs e)
        {
            DefaultDetails();
        }
        private void ClearOrderValues()
        {
            // Clear TextBoxes
            txtDetail.Text = string.Empty;
            LoadFutureInvoice();
            txtTotal.Text = string.Empty;
            txtGrandTotal.Text = string.Empty;
            txtAdvTax.Text = string.Empty;

            // Clear ComboBoxes
            cmbPaymentType.Text = "Choose Payment Type";
            cmbCustomer.Text = "Choose Customer";

            if (checkBoxWarranty.Checked == true)
            {
                checkBoxWarranty.Checked = false;
            }

            // Clear DateTimePicker
            saleDate.Value = DateTime.Now;
        }
        private void ClearAll()
        {
            DefaultDetails();
            ClearOrderValues();
            ClearDetailsGrid();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private async void LoadGridDataViewSale()
        {
            try
            {
                var saleBal = new BAL.SaleOrder(Helper.GetConnectionStringFromSettings());
                var saleList = await saleBal.GetSaleOrdersAsync();

                originalBindingList = new BindingList<ViewSale>(saleList);
                filteredBindingList = new BindingList<ViewSale>(saleList);
                dataGridViewSale.DataSource = originalBindingList;

                dataGridViewSale.Columns["OrderID"].HeaderText = "Id";
                dataGridViewSale.Columns["InvoiceNo"].HeaderText = "Invoice";
                dataGridViewSale.Columns["MedName"].HeaderText = "Item";
                dataGridViewSale.Columns["Customer"].HeaderText = "Customer";
                dataGridViewSale.Columns["Quantity"].HeaderText = "Quantity";
                dataGridViewSale.Columns["Total"].HeaderText = "Gr. Total";
                dataGridViewSale.Columns["TypeName"].HeaderText = "Payment";
                dataGridViewSale.Columns["ExpiryDate"].HeaderText = "Ex. Date";
                dataGridViewSale.Columns["BatchId"].HeaderText = "Item Code";
                dataGridViewSale.Columns["InvType"].HeaderText = "Invoice Type";
                dataGridViewSale.Columns["AreaName"].HeaderText = "Area";
                dataGridViewSale.Columns["BookerName"].HeaderText = "Booker";
                dataGridViewSale.Columns["SupplierName"].HeaderText = "Supplier";



                dataGridViewSale.Columns["OrderID"].DisplayIndex = 0;
                dataGridViewSale.Columns["InvoiceNo"].DisplayIndex = 1;
                dataGridViewSale.Columns["MedName"].DisplayIndex = 4;
                dataGridViewSale.Columns["Customer"].DisplayIndex = 6;
                dataGridViewSale.Columns["TypeName"].DisplayIndex = 7;
                dataGridViewSale.Columns["Quantity"].DisplayIndex = 8;
                dataGridViewSale.Columns["Total"].DisplayIndex = 9;
                dataGridViewSale.Columns["AreaName"].DisplayIndex = 10;
                dataGridViewSale.Columns["BookerName"].DisplayIndex = 11;
                dataGridViewSale.Columns["SupplierName"].DisplayIndex = 12;
                dataGridViewSale.Columns["ExpiryDate"].DisplayIndex = 5;
                dataGridViewSale.Columns["BatchId"].DisplayIndex = 3;
                dataGridViewSale.Columns["InvType"].DisplayIndex = 2;

                dataGridViewSale.Columns["AreaName"].Visible = false;
                dataGridViewSale.Columns["BookerName"].Visible= false;
                dataGridViewSale.Columns["SupplierName"].Visible= false;
                dataGridViewSale.Columns["InvType"].Visible= false;

                dataGridViewSale.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error loading grid data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void cmbBatchId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Initialize BAL instances
                var medicineBal = new BAL.Medicine(Helper.GetConnectionStringFromSettings());
                var stockBal = new BAL.Stock(Helper.GetConnectionStringFromSettings());

                // Retrieve list of medicines and stock asynchronously
                List<BML.Medicine> medicineList = await medicineBal.GetMedicinesGroupAsync();
                List<BML.Stock> stockList = await stockBal.GetMedicineStockAsync();

                // Get the selected Medicine ID from the combo box
                string selectedStockId = cmbBatchId.Text.ToString().ToLower();
                string selectedMedicineId = cmbMedInformation.SelectedValue.ToString();

                // Find the corresponding medicine and stock in the lists
                var selectedMedicine = medicineList.FirstOrDefault(m => m.MedicineId == selectedMedicineId);
                var selectedStock = stockList.FirstOrDefault(s => s.BatchID == selectedStockId && s.MedicineID == selectedMedicineId);

                if (selectedStock != null)
                {
                    // Update UI with medicine information
                    txtManfPrice.Text = selectedMedicine.SellPrice.ToString();
                    txtExpiryDate.Text = Convert.ToDateTime(selectedStock.ExpiryDate).ToString("MM/dd/yyyy");
                    if (selectedStock.Quantity == 0)
                    {
                        txtStockQuantity.Text = selectedStock != null ? selectedStock.Quantity.ToString() : "0";
                        MessageBox.Show($"Medicine ## {selectedMedicine.Name} ## with Item Code ## {selectedStockId} ## is out of stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        txtStockQuantity.Text = selectedStock.Quantity.ToString();
                    }

                }
                else
                {
                    txtExpiryDate.Text = "MM/DD/YYYY";
                    txtManfPrice.Text = "0.00";
                    txtStockQuantity.Text = "0";
                }
            }
            catch (Exception)
            {

            }

        }
        private void txtPurchaseQnt_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStockQuantity.Text) && !string.IsNullOrEmpty(txtSaleQnt.Text))
            {
                if (!CalculateStockQuantity())
                {
                    MessageBox.Show($"Medicine quantity is exceeding from stock quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int CalculateTotalQuantityInGrid(string medicineId, string batchId)
        {
            int totalQuantity = 0;

            foreach (DataGridViewRow row in dataGridViewSaleDetails.Rows)
            {
                if (row.Cells["MedIdColumn"].Value != null && row.Cells["BatchedColumn"].Value != null)
                {
                    string rowMedicineId = row.Cells["MedIdColumn"].Value.ToString();
                    string rowBatchId = row.Cells["BatchedColumn"].Value.ToString();

                    if (rowMedicineId == medicineId && rowBatchId == batchId)
                    {
                        int quantity;
                        if (int.TryParse(row.Cells["QuantityColumn"].Value.ToString(), out quantity))
                        {
                            totalQuantity += quantity;
                        }
                    }
                }
            }

            return totalQuantity;
        }

        private bool CalculateStockQuantity()
        {
            int totalStockQuantity = Convert.ToInt32(txtStockQuantity.Text);
            int quantity = Convert.ToInt32(txtSaleQnt.Text);
            int totalGridQuantity = CalculateTotalQuantityInGrid(cmbMedInformation.SelectedValue.ToString(), cmbBatchId.Text);
            int totalRequiredQuantity = quantity + totalGridQuantity;
            if (totalStockQuantity > totalRequiredQuantity || totalStockQuantity == totalRequiredQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filterText))
            {
                filteredBindingList = new BindingList<ViewSale>(originalBindingList);
            }
            else
            {
                var filteredList = originalBindingList.Where(sale =>
                    sale.OrderID.ToString().ToLower().Contains(filterText) ||
                    sale.InvoiceNo.ToLower().Contains(filterText) ||
                    sale.MedName.ToLower().Contains(filterText) ||
                    sale.Customer.ToLower().Contains(filterText) ||
                    sale.Quantity.ToString().ToLower().Contains(filterText) ||
                    sale.Total.ToString().ToLower().Contains(filterText) ||
                    sale.TypeName.ToLower().Contains(filterText) ||
                    sale.ExpiryDate.ToString().ToLower().Contains(filterText) ||
                    sale.BatchId.ToLower().Contains(filterText) ||
                    sale.InvType.ToLower().Contains(filterText) ||
                    sale.AreaName.ToLower().Contains(filterText) ||
                    sale.BookerName.ToLower().Contains(filterText) ||
                    sale.SupplierName.ToLower().Contains(filterText)
                ).ToList();

                filteredBindingList = new BindingList<ViewSale>(filteredList);
            }

            dataGridViewSale.DataSource = filteredBindingList;
        }

        private void txtSaleQnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtGSTtx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtAdvTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, numeric digits, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtSaleQnt_Click(object sender, EventArgs e)
        {
            txtSaleQnt.Text = string.Empty;
        }

        private void txtBonus_Click(object sender, EventArgs e)
        {
            txtBonus.Text = string.Empty;
        }

        private void txtDisc_Click(object sender, EventArgs e)
        {
            txtDisc.Text = string.Empty;
        }

        private void txtGSTtx_Click(object sender, EventArgs e)
        {
            txtGSTtx.Text = string.Empty;
        }

        private void txtAdvTax_Click(object sender, EventArgs e)
        {
            txtAdvTax.Text = string.Empty;
        }

        private void dataGridViewSale_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = dataGridViewSale.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                dataGridViewSale.ClearSelection();
                dataGridViewSale.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripSale.Show(dataGridViewSale, e.Location);
            }
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewSale.SelectedRows.Count > 0)
            {
                string name = dataGridViewSale.SelectedRows[0].Cells["InvoiceNo"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to Print Report this ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string OrderId = dataGridViewSale.SelectedRows[0].Cells["OrderID"].Value.ToString();
                    // Code to print the purchase
                    var frm = new rptSale(Helper.FormatGuid(OrderId));
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewSale.SelectedRows.Count > 0)
            {
                string name = dataGridViewSale.SelectedRows[0].Cells["InvoiceNo"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to return this ## {name} ## Invoice ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string invoiceno = dataGridViewSale.SelectedRows[0].Cells["InvoiceNo"].Value.ToString();
                    // Code to print the purchase
                    var frm = new frmSaleReturn(invoiceno);
                    frm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGridDataViewSale();
        }

    }
}
