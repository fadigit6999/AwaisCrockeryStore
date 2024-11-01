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

namespace PharApp.Account
{
    public partial class frmAccountDeposit : Form
    {
        private List<BML.ViewAccount> _accountList;
        private List<BML.ViewAdjustmentAccount> _accountAdjustmentList;
        private List<BML.ViewDeposit> _depositList;


        public IReadOnlyList<BML.ViewAccount> AccountList => _accountList.AsReadOnly();
        public IReadOnlyList<BML.ViewAdjustmentAccount> AccountAdjustmentList => _accountAdjustmentList.AsReadOnly();
        public IReadOnlyList<BML.ViewDeposit> DepositList => _depositList.AsReadOnly();


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
                var accountAdjustmentBAL = new BAL.AdjustmentBAL(Helper.GetConnectionStringFromSettings());
                _accountAdjustmentList = await accountAdjustmentBAL.GetAdjustmentAccountsAsync();
                dataGridViewAdjustementAccount.DataSource = _accountAdjustmentList;
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
          item.TransactionID.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.AccountID.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.TransactionType.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.TransactionDate.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.InvoiceNo.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.CheckNo.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.BankName.ToLower().Contains(txtSearchDeposit.Text.ToLower()) ||
          item.PaymentMethod.ToLower().Contains(txtSearchDeposit.Text.ToLower())
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
        }

        private void btnRegisterAdjustmentAccount_Click(object sender, EventArgs e)
        {
            var frm = new frmRegisterAdjustmentAccount(this);
            frm.ShowDialog();
        }
    }
}
