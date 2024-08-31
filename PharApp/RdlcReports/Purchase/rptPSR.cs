using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Reporting.WinForms;
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

namespace PharApp.RdlcReports.Purchase
{
    public partial class rptPSR : Form
    {
        public rptPSR()
        {
            InitializeComponent();
        }

        private void rptPurchase_Load(object sender, EventArgs e)
        {
            PopulateComboBoxPaymentType();
            PopulateComboBoxManufacturer();
            DateTime dtTo = toDateControl.Value.AddDays(1);
            toDateControl.Value = dtTo;
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            string paymenttype = null;
            string mgf = null;

            if(checkBoxDate.Checked == true)
            {
                if (!string.IsNullOrEmpty(cmbManufacturer.Text) || cmbManufacturer.Text != "Choose Manufacturer" || cmbManufacturer.SelectedIndex != -1)
                {
                    mgf = cmbManufacturer.SelectedValue?.ToString();
                }
                if (!string.IsNullOrEmpty(cmbPaymentType.Text) || cmbPaymentType.Text != "Choose Payment Type" || cmbPaymentType.SelectedIndex != -1)
                {
                    paymenttype = cmbPaymentType.SelectedValue?.ToString();
                }
                
            }
            else
            {
                if (cmbManufacturer.Text != "Choose Manufacturer")
                {
                    mgf = cmbManufacturer.SelectedValue?.ToString();
                }
                if (cmbPaymentType.Text != "Choose Payment Type")
                {
                    paymenttype = cmbPaymentType.SelectedValue?.ToString();
                }
            }


            LoadReport(paymenttype, mgf);
        }

        void LoadReport(string PaymentType, string Mgf)
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

                    using (SqlCommand cmd = new SqlCommand("ManagePurchaseOrder", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "PurchaseSummary_rpt");
                        if (checkBoxDate.Checked == true)
                        {
                            if (cmbManufacturer.Text != "Choose Manufacturer")
                            {
                                cmd.Parameters.AddWithValue("@ManufacturerId", (object)Mgf ?? DBNull.Value);
                              
                            }
                            if (cmbPaymentType.Text != "Choose Payment Type")
                            {
                                cmd.Parameters.AddWithValue("@PaymentTypeId", (object)PaymentType ?? DBNull.Value);
                            }

                            cmd.Parameters.AddWithValue("@EndDate", SqlDbType.Date).Value = (object)endDate ?? DBNull.Value;
                            // Set the parameters
                            cmd.Parameters.AddWithValue("@StartDate", SqlDbType.Date).Value = (object)startDate?? DBNull.Value;
                        }
                        else
                        {
                            if (cmbManufacturer.Text != "Choose Manufacturer")
                            {
                                cmd.Parameters.AddWithValue("@ManufacturerId", (object)Mgf ?? DBNull.Value);
                            }
                            if (cmbPaymentType.Text != "Choose Payment Type")
                            {
                                cmd.Parameters.AddWithValue("@PaymentTypeId", (object)PaymentType ?? DBNull.Value);
                            }
                        }

                        if ((cmbManufacturer.Text == "Choose Manufacturer") && (cmbPaymentType.Text == "Choose Payment Type"))
                        {
                            cmd.Parameters.AddWithValue("@EndDate", SqlDbType.Date).Value = (object)endDate ?? DBNull.Value;
                            // Set the parameters
                            cmd.Parameters.AddWithValue("@StartDate", SqlDbType.Date).Value = (object)startDate ?? DBNull.Value;

                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DSPurchase ds = new DSPurchase();
                        da.Fill(ds, "DT_PSR"); // Ensure the DataTable  RDLC

                        ReportDataSource dataSource = new ReportDataSource("DSPSR", ds.Tables[1]);
                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dataSource);

                        // Set the path to the RDLC file relative to the executable
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharApp.RdlcReports.Purchase.rptPSR.rdlc";

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
