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
    public partial class rptAccountLedger : Form
    {
        private readonly string _id;

        public rptAccountLedger(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void rptPurchase_Load(object sender, EventArgs e)
        {
            LoadReport(_id);
        }


        void LoadReport(string id)
        {
            try
            {

                string connectionString = Helper.GetConnectionStringFromSettings();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("ManageAccountAndDeposit", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Operation", "AccountGeneralLedgerRunningBalance");
                        cmd.Parameters.AddWithValue("@TransactionID", id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        Account ds = new Account();
                        da.Fill(ds, "InvoiceAccountLedger"); // Ensure the DataTable  RDLC

                        ReportDataSource dataSource = new ReportDataSource("AccountLedger", ds.Tables[0]);
                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(dataSource);

                        // Set the path to the RDLC file relative to the executable
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharApp.RdlcReports.Account.rptGeneralAccountLedger.rdlc";

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
