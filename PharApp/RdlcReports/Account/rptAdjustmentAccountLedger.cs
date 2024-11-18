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

namespace PharApp.RdlcReports.Account
{
    public partial class rptAdjustmentAccountLedger : Form
    {
        public rptAdjustmentAccountLedger()
        {
            InitializeComponent();
        }

        private void rptPurchase_Load(object sender, EventArgs e)
        {
            PopulateComboBoxAccountId();
            PopulateComboBoxPaymentMethod();
        }
        private async void PopulateComboBoxAccountId()
        {
            try
            {
                var cmbPartyBal = new BAL.Account(Helper.GetConnectionStringFromSettings());
                List<BML.ViewAccount> cmbPartyList = await cmbPartyBal.GetAccountsAsync();

                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Choose Account --", Guid.NewGuid().ToString());
                // Populate the dictionary with category names and IDs
                foreach (var category in cmbPartyList)
                {
                    partyDictionary.Add(category.Name, category.AccountName);
                }

                cmbAccount.DataSource = new BindingSource(partyDictionary, null);
                cmbAccount.DisplayMember = "Key"; // Display category names
                cmbAccount.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Party: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateComboBoxPaymentMethod()
        {
            try
            {
                // Create a dictionary to hold the category names and IDs
                Dictionary<string, string> partyDictionary = new Dictionary<string, string>();
                partyDictionary.Add("-- Choose Method --", Guid.NewGuid().ToString());
                partyDictionary.Add("Cash", Guid.NewGuid().ToString());
                partyDictionary.Add("Debit", Guid.NewGuid().ToString());
                partyDictionary.Add("Credit", Guid.NewGuid().ToString());
                partyDictionary.Add("Online Banking", Guid.NewGuid().ToString());
                partyDictionary.Add("Check", Guid.NewGuid().ToString());

                // Set the DataSource and DisplayMember/ValueMember for the ComboBox
                cmbPaymtMethod.DataSource = new BindingSource(partyDictionary, null);
                cmbPaymtMethod.DisplayMember = "Key"; // Display category names
                cmbPaymtMethod.ValueMember = "Value"; // Use category IDs as values
            }
            catch (Exception ex)
            {
                // Handle exceptions, log, or show error message
                MessageBox.Show($"Error while populating Payment Method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        void LoadReport()
        {
            try
            {

                string connectionString = Helper.GetConnectionStringFromSettings();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("ManageAdjustmentRecords", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TableName", "AdjustmentAccount");
                        cmd.Parameters.AddWithValue("@Operation", "GetAdjustmentTransactionRunningBalance");
                        if (!(cmbAccount.Text == "-- Choose Account --"))
                        {
                            cmd.Parameters.AddWithValue("@AccountID",cmbAccount.SelectedValue.ToString());
                        }

                        if (!(cmbPaymtMethod.Text == "-- Choose Method --"))
                        {
                            cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymtMethod.Text);
                        }


                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        Account ds = new Account();
                        da.Fill(ds, "AdjustmentAccountLedger"); // Ensure the DataTable  RDLC

                        ReportDataSource dataSource = new ReportDataSource("AdjustmentAccountDS", ds.Tables[1]);
                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dataSource);

                        // Set the path to the RDLC file relative to the executable
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharApp.RdlcReports.Account.rptAdjustmentAccountLedger.rdlc";

                        this.reportViewer1.RefreshReport();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset ComboBox controls
            cmbAccount.Text = "-- Choose Account --";
            cmbPaymtMethod.Text = "-- Choose Method --";
        }
    }
}
