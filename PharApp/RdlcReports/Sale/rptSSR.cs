using Microsoft.Reporting.WinForms;
using PharApp.RdlcReports.Purchase;
using PharApp.WinHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharApp.RdlcReports.Sale
{
    public partial class rptSSR : Form
    {
        public rptSSR()
        {
            InitializeComponent();
            DateTime dtTo = toDateControl.Value.AddDays(1);
            toDateControl.Value = dtTo;
        }

        private void rptSale_Load(object sender, EventArgs e)
        {
            PopulateComboBoxPaymentType();
            PopulateComboBoxArea();
            PopulateComboBoxBooker();
            PopulateComboBoxSupplier();
            PopulateComboBoxCustomer();
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

                    foreach (var pt in cmbPaymentTypeList)
                    {
                        pTypeDictionary.Add(pt.TypeName, pt.PaymentTypeId);
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
        private void btnReport_Click(object sender, EventArgs e)
        {
            string paymenttype = null;
            string saleArea = null;
            string booker = null;
            string supplier = null;
            string customer = null;



            if (checkBoxDate.Checked == true)
            {
                if (!string.IsNullOrEmpty(cmbArea.Text) || cmbArea.Text != "Choose Area" || cmbArea.SelectedIndex != -1)
                {
                    saleArea = cmbArea.SelectedValue?.ToString();
                }
                if (!string.IsNullOrEmpty(cmbPaymentType.Text) || cmbPaymentType.Text != "Choose Payment Type" || cmbPaymentType.SelectedIndex != -1)
                {
                    paymenttype = cmbPaymentType.SelectedValue?.ToString();
                }
                if (!string.IsNullOrEmpty(cmbBooker.Text) || cmbBooker.Text != "Choose Booker" || cmbBooker.SelectedIndex != -1)
                {
                    booker = cmbBooker.SelectedValue?.ToString();
                }

                if (!string.IsNullOrEmpty(cmbSupplier.Text) || cmbSupplier.Text != "Choose Supplier" || cmbSupplier.SelectedIndex != -1)
                {
                    supplier = cmbSupplier.SelectedValue?.ToString();
                }

                if (!string.IsNullOrEmpty(cmbCustomer.Text) || cmbCustomer.Text != "Choose Customer" || cmbCustomer.SelectedIndex != -1)
                {
                    customer = cmbCustomer.SelectedValue?.ToString();
                }

            }
            else
            {
                if (cmbArea.Text != "Choose Area")
                {
                    saleArea = cmbArea.SelectedValue?.ToString();
                }
                if (cmbPaymentType.Text != "Choose Payment Type")
                {
                    paymenttype = cmbPaymentType.SelectedValue?.ToString();
                }
                if (cmbBooker.Text != "Choose Booker")
                {
                    booker = cmbBooker.SelectedValue?.ToString();
                }

                if (cmbSupplier.Text != "Choose Supplier")
                {
                    supplier = cmbSupplier.SelectedValue?.ToString();
                }

                if (cmbCustomer.Text != "Choose Customer")
                {
                    customer = cmbCustomer.SelectedValue?.ToString();
                }
            }


            LoadReport(paymenttype,saleArea,booker,supplier,customer);
        }
        void LoadReport(string PaymentType, string saleArea,string booker,string supplier,string customer)
        {
            try
            {
                // Extract the date values from DateTimePicker controls
                DateTime? startDate = fromDateControl?.Value;
                DateTime? endDate = toDateControl?.Value;

                string connectionString = Helper.GetConnectionStringFromSettings();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("ManageSalesOrder", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "SaleSummary_rpt");
                        if (checkBoxDate.Checked == true)
                        {
                            if (cmbArea.Text != "Choose Area")
                            {
                                cmd.Parameters.AddWithValue("@ManufacturerId", (object)saleArea ?? DBNull.Value);
                            }
                            if (cmbPaymentType.Text != "Choose Payment Type")
                            {
                                cmd.Parameters.AddWithValue("@PaymentTypeId", (object)PaymentType ?? DBNull.Value);
                            }
                            if (cmbBooker.Text != "Choose Booker")
                            {
                                cmd.Parameters.AddWithValue("@BookerId", (object)booker ?? DBNull.Value);
                            }

                            if (cmbSupplier.Text != "Choose Supplier")
                            {
                                cmd.Parameters.AddWithValue("@SupplierId", (object)supplier ?? DBNull.Value);
                            }

                            if (cmbCustomer.Text != "Choose Customer")
                            {
                                cmd.Parameters.AddWithValue("@CustomerId", (object)customer ?? DBNull.Value);
                            }

                            cmd.Parameters.AddWithValue("@EndDate", SqlDbType.Date).Value = (object)endDate ?? DBNull.Value;
                            // Set the parameters
                            cmd.Parameters.AddWithValue("@StartDate", SqlDbType.Date).Value = (object)startDate ?? DBNull.Value;
                        }
                        else
                        {
                            if (cmbArea.Text != "Choose Area")
                            {
                                cmd.Parameters.AddWithValue("@Sale_Area", (object)saleArea ?? DBNull.Value);
                            }
                            if (cmbPaymentType.Text != "Choose Payment Type")
                            {
                                cmd.Parameters.AddWithValue("@PaymentTypeId", (object)PaymentType ?? DBNull.Value);
                            }
                            if (cmbBooker.Text != "Choose Booker")
                            {
                                cmd.Parameters.AddWithValue("@BookerId", (object)booker ?? DBNull.Value);
                            }

                            if (cmbSupplier.Text != "Choose Supplier")
                            {
                                cmd.Parameters.AddWithValue("@SupplierId", (object)supplier ?? DBNull.Value);
                            }

                            if (cmbCustomer.Text != "Choose Customer")
                            {
                                cmd.Parameters.AddWithValue("@CustomerId", (object)customer ?? DBNull.Value);
                            }
                        }

                        if (
                           (cmbArea.Text == "Choose Area") && 
                           (cmbPaymentType.Text == "Choose Payment Type") &&
                           (cmbBooker.Text == "Choose Booker") &&
                           (cmbSupplier.Text == "Choose Supplier") &&
                           (cmbCustomer.Text == "Choose Customer")
                           )
                        {
                            cmd.Parameters.AddWithValue("@EndDate", SqlDbType.Date).Value = (object)endDate ?? DBNull.Value;
                            // Set the parameters
                            cmd.Parameters.AddWithValue("@StartDate", SqlDbType.Date).Value = (object)startDate ?? DBNull.Value;

                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DSPurchase ds = new DSPurchase();
                        da.Fill(ds, "DT_SSR"); 

                        ReportDataSource dataSource = new ReportDataSource("DSSSR", ds.Tables[2]);
                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dataSource);

                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharApp.RdlcReports.Sale.rptSSR.rdlc";

                        this.reportViewer1.RefreshReport();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
