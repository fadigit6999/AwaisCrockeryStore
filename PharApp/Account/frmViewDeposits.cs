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
    public partial class frmViewDeposits : Form
    {
        private List<BML.ViewAccountDeposit> _depositList;

        public IReadOnlyList<BML.ViewAccountDeposit> DepositList => _depositList.AsReadOnly();

        private string _id;

        public frmViewDeposits(string id)
        {
            InitializeComponent();
            _id = id;
            LoadDepositsAsync();
            LoadFields();
        }

        private async Task LoadDepositsAsync()
        {
            try
            {
                var accountBAL = new BAL.Deposit(Helper.GetConnectionStringFromSettings());
                _depositList = await accountBAL.ViewAccountDepositsAsync();
                dataGridViewDeposit.DataSource = _depositList.Where(x=>x.TrxAccountId.ToLower() == _id.ToLower()).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }

        async Task LoadFields() 
        {
            var accountBAL = new BAL.Deposit(Helper.GetConnectionStringFromSettings());
            _depositList = await accountBAL.ViewAccountDepositsAsync();
            var getFields = _depositList.Where(x=>x.TrxAccountId.ToLower() == _id.ToLower()).FirstOrDefault();
            lblAccountHolder.Text = getFields.AccountID.ToString();
            lblTRXAccount.Text = getFields.TrxAccountId.ToString();
        }

    }
}
