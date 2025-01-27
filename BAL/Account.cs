using BML;
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

        // Method to create a new AdjustmentAccount record
        public async Task<int> CreateAdjustmentAccountAsync(string accountId, string transactionId, string transactionType, decimal totalDepositAmount, DateTime? depositDate = null, string remarks = null)
        {
            // Business logic validation
            if (string.IsNullOrEmpty(accountId) || string.IsNullOrEmpty(transactionId) || string.IsNullOrEmpty(transactionType))
                throw new ArgumentException("Account ID, Transaction ID, and Transaction Type are required fields.");

            // Call DAL method
            return await _account.CreateAdjustmentAccountAsync(accountId, transactionId, transactionType, totalDepositAmount, depositDate, remarks);
        }

        // Method to read records from AdjustmentAccount
        public async Task<List<ViewAdjustmentAccount>> GetTransactionAccountsAsync()
        {
            var accounts = await _account.ReadTransactionAccountAsync();

            // Additional business logic, e.g., filtering, could go here
            return accounts ?? new List<ViewAdjustmentAccount>();
        }

        public async Task<string> GetUniqueTransactionIdAsync()
        {
            var TransactionId = await _account.GetUniqueTransactionIdAsync();

            // Additional business logic, e.g., filtering, could go here
            return TransactionId;
        }

        public async Task<List<ViewTransactionIdCMB>> GetTransactionIdCMBAsync()
        {
            var TransactionId = await _account.GetTransactionIdCMB();

            // Additional business logic, e.g., filtering, could go here
            return TransactionId ?? new List<ViewTransactionIdCMB>();
        }


    }
}

