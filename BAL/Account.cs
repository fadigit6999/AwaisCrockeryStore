using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Account
    {
        private readonly DAL.Account _account;

        public Account(string connectionString)
        {
            _account = new DAL.Account(connectionString);
        }

        public async Task<int> CreateAccountAsync(string accountName, string accountType)
        {
            try
            {
                return await _account.CreateAccountAsync(accountName, accountType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating account: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateAccountAsync(string accountId, string accountName, decimal currentBalance)
        {
            try
            {
                return await _account.UpdateAccountAsync(accountId, accountName, currentBalance);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating account: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteAccountAsync(string accountId)
        {
            try
            {
                return await _account.DeleteAccountAsync(accountId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting account: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.ViewAccount>> GetAccountsAsync()
        {
            try
            {
                return await _account.GetAccountsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting accounts: {ex.Message}");
                return new List<BML.ViewAccount>();
            }
        }

        public async Task<List<BML.Party>> GetPartyAsync()
        {
            try
            {
                return await _account.GetPartiesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting accounts: {ex.Message}");
                return new List<BML.Party>();
            }
        }

        public async Task<List<BML.CmbDepositInvoice>> GetInvoicesAsync()
        {
            try
            {
                return await _account.GetInvoicesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting invoices: {ex.Message}");
                return new List<BML.CmbDepositInvoice>();
            }
        }

    }
}

