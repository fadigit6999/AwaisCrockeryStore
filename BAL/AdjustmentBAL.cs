using BML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class AdjustmentBAL
    {
        private readonly DAL.AccountAdjustmentDal _adjustmentDal;

        public AdjustmentBAL(string connectionString)
        {
            _adjustmentDal = new DAL.AccountAdjustmentDal(connectionString);
        }

        // Method to create a new AdjustmentDeposit record
        public async Task<int> CreateAdjustmentDepositAsync(string trxId, int serialId, string accountId, string transactionId, DateTime transactionDate, decimal totalAmount,
                                                            string paymentMethod, string bankName, string checkNo, decimal paidAmount, decimal balance, string remarks, int isPaid)
        {
            // Business logic validation
            if (string.IsNullOrEmpty(trxId) || serialId <= 0 || string.IsNullOrEmpty(accountId))
                throw new ArgumentException("Transaction ID, Serial ID, and Account ID are required fields.");

            if (totalAmount <= 0)
                throw new ArgumentException("Total amount must be greater than zero.");

            // Call DAL method
            return await _adjustmentDal.CreateAdjustmentDepositAsync(trxId, serialId, accountId, transactionId, transactionDate, totalAmount, paymentMethod, bankName, checkNo, paidAmount, balance, remarks, isPaid);
        }

        // Method to read records from AdjustmentDeposit
        public async Task<List<AdjustmentDeposit>> GetAdjustmentDepositsAsync(string trxId = null)
        {
            var deposits = await _adjustmentDal.ReadAdjustmentDepositAsync(trxId);

            // Additional business logic, e.g., filtering, could go here
            return deposits ?? new List<AdjustmentDeposit>();
        }

        // Method to create a new AdjustmentAccount record
        public async Task<int> CreateAdjustmentAccountAsync(string accountId, string transactionId, string transactionType, decimal totalDepositAmount, DateTime? depositDate = null, string remarks = null)
        {
            // Business logic validation
            if (string.IsNullOrEmpty(accountId) || string.IsNullOrEmpty(transactionId) || string.IsNullOrEmpty(transactionType))
                throw new ArgumentException("Account ID, Transaction ID, and Transaction Type are required fields.");

            if (totalDepositAmount <= 0)
                throw new ArgumentException("Total deposit amount must be greater than zero.");

            // Call DAL method
            return await _adjustmentDal.CreateAdjustmentAccountAsync(accountId, transactionId, transactionType, totalDepositAmount, depositDate, remarks);
        }

        // Method to read records from AdjustmentAccount
        public async Task<List<ViewAdjustmentAccount>> GetAdjustmentAccountsAsync()
        {
            var accounts = await _adjustmentDal.ReadAdjustmentAccountAsync();

            // Additional business logic, e.g., filtering, could go here
            return accounts ?? new List<ViewAdjustmentAccount>();
        }

        public async Task<string> GetUniqueTransactionIdAsync()
        {
            var TransactionId = await _adjustmentDal.GetUniqueTransactionIdAsync();

            // Additional business logic, e.g., filtering, could go here
            return TransactionId;
        }

    }
}
