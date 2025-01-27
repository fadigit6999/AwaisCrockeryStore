using BML;
using DocumentFormat.OpenXml.Office2010.Excel;
using PharApp.RdlcReports.Account;
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

namespace PharApp.Account
{
    public partial class frmAccountDeposit : Form
    {
        private List<BML.ViewAccount> _accountList;
        private List<BML.ViewAdjustmentAccount> _accountTransactionList;

        private List<BML.ViewAdjustmentAccount> _accountAdjustmentList;
        private List<BML.ViewDeposit> _depositList;
        private List<BML.ViewAdjustmentDeposit> _AdjustmentDepositList;


        public IReadOnlyList<BML.ViewAccount> AccountList => _accountList.AsReadOnly();

        public IReadOnlyList<BML.ViewAdjustmentAccount> AccountTransactionList => _accountTransactionList.AsReadOnly();

        public IReadOnlyList<BML.ViewAdjustmentAccount> AccountAdjustmentList => _accountAdjustmentList.AsReadOnly();

        public IReadOnlyList<BML.ViewDeposit> DepositList => _depositList.AsReadOnly();
        public IReadOnlyList<BML.ViewAdjustmentDeposit> AdjustmentDepositList => _AdjustmentDepositList.AsReadOnly();


        //public IReadOnlyList<AspNetRole> UserRolesList => _userRolesList.AsReadOnly();

        public frmAccountDeposit()
        {
            InitializeComponent();

        }

        private async Task LoadUsersAsync()
        {
            try
            {
                var accountBAL = new BAL.Account(Helper.GetConnectionStringFromSettings());
                _accountList = await accountBAL.GetAccountsAsync();
                accountGrid.DataSource = _accountList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }

        private async Task LoadAdjustmentAccountAsync()
        {
            try
            {
                //    var accountAdjustmentBAL = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                //    _accountAdjustmentList = await accountAdjustmentBAL.GetAdjustmentAccountsAsync();
                //    dataGridViewAdjustementAccount.DataSource = _accountAdjustmentList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }

        private async Task LoadTransactionAccountAsync()
        {
            try
            {
                var accountAdjustmentBAL = new BAL.Account(Helper.GetConnectionStringFromSettings());
                _accountTransactionList = await accountAdjustmentBAL.GetTransactionAccountsAsync();
                dataGridViewTransactionAccount.DataSource = _accountTransactionList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }

        private async Task LoadDepositsAsync()
        {
            try
            {
                var accountBAL = new BAL.Deposit(Helper.GetConnectionStringFromSettings());
                _depositList = await accountBAL.ViewDepositsAsync();
                depositGrid.DataSource = _depositList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }
        private async Task LoadAdjustmentDepositsAsync()
        {
            try
            {
                //var adjustmentDepositBAL = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                //_AdjustmentDepositList = await adjustmentDepositBAL.GetAdjustmentDepositsAsync();
                //dataGridViewAdjustmentDepositGrid.DataSource = _AdjustmentDepositList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterAccount(this, null);
            frm.ShowDialog();
        }

        private void txtSearchAccount_KeyUp(object sender, KeyEventArgs e)
        {
            var filterList = _accountList.Where(item =>
            item.AccountID.ToLower().Contains(txtSearchAccount.Text.ToLower()) ||
            item.SerialId.ToLower().Contains(txtSearchAccount.Text.ToLower()) ||
            item.Name.ToLower().Contains(txtSearchAccount.Text.ToLower()) ||
            item.Mobile.ToLower().Contains(txtSearchAccount.Text.ToLower()) ||
            item.CreatedDate.ToLower().Contains(txtSearchAccount.Text.ToLower())
            // Add conditions for other fields as needed
            ).ToList();
            accountGrid.DataSource = null;
            accountGrid.DataSource = filterList;
            accountGrid.Refresh();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var frm = new frmDeposit(this);
            frm.ShowDialog();
        }

        private void tabAccount_Click(object sender, EventArgs e)
        {

        }

        private void textSearchDeposit_KeyUp(object sender, KeyEventArgs e)
        {
            var filterList = _depositList.Where(item =>
          item.AccountID.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.AccountID.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.TransactionType.ToLower().Contains(txtSearchDeposit.Text.ToLower())
          // Add conditions for other fields as needed
          ).ToList();
            depositGrid.DataSource = null;
            depositGrid.DataSource = filterList;
            depositGrid.Refresh();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private async void btnRefreshDeposit_Click(object sender, EventArgs e)
        {
            await LoadDepositsAsync();
        }

        private async void frmAccountDeposit_Load(object sender, EventArgs e)
        {

            await LoadUsersAsync();
            await LoadDepositsAsync();
            await LoadAdjustmentAccountAsync();
            await LoadAdjustmentDepositsAsync();
            await LoadTransactionAccountAsync();
        }

        private void btnRegisterAdjustmentAccount_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterAdjustmentAccount(this);
            frm.ShowDialog();
        }

        private void txtSearchAdjustementAccount_KeyUp(object sender, KeyEventArgs e)
        {
            var filterList = _accountAdjustmentList.Where(item =>
         item.AccountID.ToLower().Contains(txtSearchAdjustementAccount.Text.ToLower()) ||
         item.TransactionID.ToLower().Contains(txtSearchAdjustementAccount.Text.ToLower()) ||
         item.TransactionType.ToLower().Contains(txtSearchAdjustementAccount.Text.ToLower())
         // Add conditions for other fields as needed
         ).ToList();
            dataGridViewAdjustementAccount.DataSource = null;
            dataGridViewAdjustementAccount.DataSource = filterList;
            dataGridViewAdjustementAccount.Refresh();
        }

        private void btnAdjustmentDeposit_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterAdjustmentDeposit(this);
            frm.ShowDialog();
        }

        private void txtAdjustmentDepositSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var filterList = _AdjustmentDepositList.Where(item =>
        item.AccountID.ToLower().Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.TransactionID.ToLower().Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.TransactionType.ToLower().Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.TransactionDate.Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.TotalAmount.Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.PaymentMethod.Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||

        item.BankName.Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.CheckNo.Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.PaidAmount.Contains(txtAdjustmentDepositSearch.Text.ToLower()) ||
        item.Balance.Contains(txtAdjustmentDepositSearch.Text.ToLower())
        // Add conditions for other fields as needed
        ).ToList();
            dataGridViewAdjustmentDepositGrid.DataSource = null;
            dataGridViewAdjustmentDepositGrid.DataSource = filterList;
            dataGridViewAdjustmentDepositGrid.Refresh();
        }

        private async void btnRefreshAdjustementAccount_Click(object sender, EventArgs e)
        {
            await LoadAdjustmentAccountAsync();
        }

        private async void btnRefreshAdjustmentDepositGrid_Click(object sender, EventArgs e)
        {
            await LoadAdjustmentDepositsAsync();
        }

        private void btnRegisterAccountTransaction_Click(object sender, EventArgs e)
        {
            var frm = new frmAccountTransaction(this);
            frm.ShowDialog();
        }

        private async void btnAccountTransactionRefresh_Click(object sender, EventArgs e)
        {
            await LoadTransactionAccountAsync();
        }

        private void depositGrid_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the row index at the mouse position
            int rowIndex = depositGrid.HitTest(e.X, e.Y).RowIndex;

            // If a row is clicked
            if (rowIndex >= 0)
            {
                // Select the clicked row
                depositGrid.ClearSelection();
                depositGrid.Rows[rowIndex].Selected = true;

                // Show the context menu strip at the mouse position
                contextMenuStripDeposit.Show(depositGrid, e.Location);
            }
        }

        private void generalLedgerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (depositGrid.SelectedRows.Count > 0)
            {
                string name = depositGrid.SelectedRows[0].Cells["AccountID"].Value.ToString();
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show($"Are you sure to generate account ledger report of ## {name} ## ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected row
                    string Id = depositGrid.SelectedRows[0].Cells["TrxAccountId"].Value.ToString();

                    var rpt = new rptAccountLedger(Id);
                    rpt.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a account Trx Id to view Report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (depositGrid.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                string Id = depositGrid.SelectedRows[0].Cells["TrxAccountId"].Value.ToString();

                var rpt = new frmViewDeposits(Id);
                rpt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a Trx Account ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
