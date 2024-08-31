using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharApp.About;
using PharApp.Audit;
using PharApp.Backup;
using PharApp.Customer;
using PharApp.Inventory;
using PharApp.Purchase;
using PharApp.RdlcReports.Purchase;
using PharApp.RdlcReports.Sale;
using PharApp.Sale;
using PharApp.Sale.Area;
using PharApp.Settings;
using PharApp.Users;
using PharApp.WinHelper;
namespace PharApp.Main
{
    public partial class frmMain : Form
    {
        private readonly BAL.DashBoard _dashboardService;
        public frmMain()
        {
            InitializeComponent();
            _dashboardService = new BAL.DashBoard(Helper.GetConnectionStringFromSettings());

        }

        private void OpenUserManagerForm()
        {
            // Open the form to enter database connection information
            frmManageUsers manageUsers = new frmManageUsers();
            manageUsers.ShowDialog();
        }

        private void OpenUserManage()
        {
            // Open the form to enter database connection information
            frmDbConfig config = new frmDbConfig();
            config.ShowDialog();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            await LoadMetrics();
            await LoadExpiryStock();
            toolStripStatuslblVersion.Text = "Awais Plastic Store 1.0.0";
            this.timerMain.Start();
            SetMenuVisibility(BML.UserSession.User.UserRole.ToUpper().ToString());
        }

        private async Task LoadMetrics()
        {
            var dashBoard = await _dashboardService.DashboardMetricsAsync();
            if (dashBoard != null)
            {
                lblTotalCustomer.Text = "Customers: " + dashBoard.Customer.ToString();
                lblManufacturer.Text = "Manufacturers: " + dashBoard.Manufacturer.ToString();
                lblTotalPurchase.Text = "Purchase: " + dashBoard.Purchase.ToString();
                lblTotalSale.Text = "Sale: " + dashBoard.Sale.ToString();
                lblTotalInventory.Text = "Inventory: " + dashBoard.Inventory.ToString();
                lblstock.Text = "Stock: " + dashBoard.Stock.ToString();
                lblExpiry.Text = "Expiry Alert: " + dashBoard.Expiry.ToString();

            }
        }

        private async Task LoadExpiryStock()
        {
            var dashBoard = await _dashboardService.DashboardExpiryMedicsAsync();
            if (dashBoard != null && dashBoard.Count > 0)
            {
                PlayAlertSound();
                var frm = new frmExpiryStock();
                frm.ShowDialog();

            }
        }

        private void PlayAlertSound()
        {
            // Play the system alert sound
            SystemSounds.Exclamation.Play();
        }

        #region Menu Strip Privileges
        public void SetMenuVisibility(string role)
        {
            if (Enum.TryParse<PharApp.WinHelper.UserRole>(role, true, out PharApp.WinHelper.UserRole userRole))
            {
                foreach (ToolStripMenuItem item in menuStrip.Items)
                {
                    switch (userRole)
                    {
                        case PharApp.WinHelper.UserRole.ADMIN:
                            item.Visible = true;
                            break;
                        case PharApp.WinHelper.UserRole.OPERATOR:
                            if (item.Text == "&Users")
                            {
                                item.Visible = false;
                            }
                            else
                            {
                                item.Visible = true;
                            }
                            break;
                        default:
                            item.Visible = false;
                            break;
                    }
                }
            }

        }

        #endregion

        private void databaseConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDbConfig = new frmDbConfig();
            frmDbConfig.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUserManagerForm();
        }

        private void medicineToolStripMedicine_Click(object sender, EventArgs e)
        {
            var frmMedicine = new frmMedicine();
            frmMedicine.ShowDialog();
        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmManufacturer = new frmManufacturer();
            frmManufacturer.ShowDialog();
        }

        private void procurementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPurc = new frmPurchase();
            frmPurc.ShowDialog();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCompany();
            frm.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPyament();
            frm.ShowDialog();
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void registerSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSale();
            frm.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                // Replace MyForm with the name of the form you want to open
                var myForm = new frmCustomers();
                myForm.ShowDialog();
            }

            if (e.Control && e.KeyCode == Keys.I)
            {
                // Replace MyForm with the name of the form you want to open
                var myForm = new frmMedicine();
                myForm.ShowDialog();
            }

            if (e.Control && e.KeyCode == Keys.M)
            {
                // Replace MyForm with the name of the form you want to open
                var myForm = new frmManufacturer();
                myForm.ShowDialog();
            }

            if (e.Control && e.KeyCode == Keys.P)
            {
                // Replace MyForm with the name of the form you want to open
                var myForm = new frmPurchase();
                myForm.ShowDialog();
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                // Replace MyForm with the name of the form you want to open
                var myForm = new frmSale();
                myForm.ShowDialog();
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                // Replace MyForm with the name of the form you want to open
                var myForm = new frmDbConfig();
                myForm.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                // Replace MyForm with the name of the form you want to open
                var myForm = new frmManageUsers();
                myForm.ShowDialog();
            }
        }

        private void auditReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new AuditLog();
            myForm.ShowDialog();
        }

        private void procurementReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmPurchaseReturn();
            myForm.ShowDialog();
        }

        private void saleAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmArea();
            myForm.ShowDialog();
        }

        private void saleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmSaleReturn();
            myForm.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmStock();
            myForm.ShowDialog();
        }

        private void pictureBoxCustomer_Click(object sender, EventArgs e)
        {
            var frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void pictureBoxManufacturer_Click(object sender, EventArgs e)
        {
            var frm = new frmManufacturer();
            frm.ShowDialog();
        }

        private void pictureBoxInventory_Click(object sender, EventArgs e)
        {
            var frm = new frmMedicine();
            frm.ShowDialog();
        }

        private void pictureBoxPurchase_Click(object sender, EventArgs e)
        {
            var frm = new frmPurchase();
            frm.ShowDialog();
        }

        private void pictureBoxSale_Click(object sender, EventArgs e)
        {
            var frm = new frmSale();
            frm.ShowDialog();
        }

        private void pictureBoxStock_Click(object sender, EventArgs e)
        {
            var frm = new frmStock();
            frm.ShowDialog();
        }

        private void pictureBoxExpiryAlert_Click(object sender, EventArgs e)
        {

            var frm = new frmExpiryStock();
            frm.ShowDialog();
        }

        private void manualBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmManualBackup();
            frm.ShowDialog();
        }

        private void pictureBoxExpiry_Click(object sender, EventArgs e)
        {
            var frm = new frmExpiryStock();
            frm.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void stickyNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("ms-sticky-notes://");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAbout();
            frm.ShowDialog();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelLoginUser.Text = $"User: {BML.UserSession.User.UserRole.ToUpper().ToString()} ({BML.UserSession.User.FirstName.ToUpper().ToString()} {BML.UserSession.User.LastName.ToUpper().ToString()}) Time: {DateTime.Now.ToString("F")}";
        }

        private void saleSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new rptSSR();
            frm.ShowDialog();
        }

        private void purchaseSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new rptPSR();
            frm.ShowDialog();
        }
    }

}
