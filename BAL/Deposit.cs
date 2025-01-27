using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Deposit
    {
        private readonly DAL.Deposit _deposit;

        public Deposit(string connectionString)
        {
            _deposit = new DAL.Deposit(connectionString);
        }

        public async Task<int> CreateDepositAsync(DateTime depositDate,string accountId, string invoiceNo, string transactionType, decimal totalAmount, string paymentMethod, decimal credit, decimal debit, string bankName = "", string checkNo = "", string remarks = "")
        {
            try
            {
                return await _deposit.CreateDepositAsync(depositDate, accountId, invoiceNo, transactionType, totalAmount, paymentMethod, credit, debit, bankName, checkNo, remarks);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating deposit: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Deposit>> GetDepositsAsync()
        {
            try
            {
                return await _deposit.GetDepositsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting deposits: {ex.Message}");
                return new List<BML.Deposit>();
            }
        }

        public async Task<List<BML.ViewDeposit>> ViewDepositsAsync()
        {
            try
            {
                return await _deposit.ViewDepositsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting deposits: {ex.Message}");
                return new List<BML.ViewDeposit>();
            }
        }

        public async Task<List<BML.ViewAccountDeposit>> ViewAccountDepositsAsync()
        {
            try
            {
                return await _deposit.ViewAccountDepositsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting deposits: {ex.Message}");
                return new List<BML.ViewAccountDeposit>();
            }
        }
    }
}
