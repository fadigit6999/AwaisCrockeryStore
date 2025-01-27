using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Deposit
    {
        private readonly string _connectionString;

        public Deposit(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Create a new deposit (transaction)
        public async Task<int> CreateDepositAsync(DateTime depositdate,string accountId, string invoiceNo, string transactionType, decimal totalAmount, string paymentMethod, decimal credit, decimal debit, string bankName = "", string checkNo = "", string remarks = "")
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection)) // Assuming stored procedure name is 'ManageDeposit'
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "CreateDeposit");
                command.Parameters.AddWithValue("@TransactionDate", depositdate);

                command.Parameters.AddWithValue("@AccountID", accountId);
                command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                command.Parameters.AddWithValue("@TransactionType", transactionType);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.Parameters.AddWithValue("@DebitAmount", debit);
                command.Parameters.AddWithValue("@CreditAmount", credit);
                command.Parameters.AddWithValue("@BankName", bankName);
                command.Parameters.AddWithValue("@CheckNo", checkNo);
                command.Parameters.AddWithValue("@Remarks", remarks);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        // Get all deposits (transactions)
        public async Task<List<BML.Deposit>> GetDepositsAsync()
        {
            try
            {
                List<BML.Deposit> deposits = new List<BML.Deposit>();

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("ManageAccountAndDeposit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operation", "ReadDeposit");

                    await connection.OpenAsync();
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            BML.Deposit deposit = new BML.Deposit
                            {
                                TransactionID = reader["TransactionID"].ToString(),
                                AccountID = reader["AccountID"].ToString(),
                                InvoiceNo = reader["InvoiceNo"].ToString(),
                                TransactionType = reader["TransactionType"].ToString(),
                                TransactionDate = (DateTime)reader["TransactionDate"],
                                TotalAmount = (decimal)reader["TotalAmount"],
                                PaymentMethod = reader["PaymentMethod"].ToString(),
                                PaidAmount = (decimal)reader["PaidAmount"],
                                Balance = (decimal)reader["Balance"],
                                BankName = reader["BankName"].ToString(),
                                CheckNo = reader["CheckNo"].ToString(),
                                Remarks = reader["Remarks"].ToString(),
                                CreatedDate = reader["CreatedDate"].ToString(),
                                IsPaid = Convert.ToInt16(reader["isPaid"].ToString())
                            };
                            deposits.Add(deposit);
                        }
                    }
                }

                return deposits;
            }
            catch (Exception ex)
            {

                string message = ex.ToString();
                return null;
            }
           
        }

        // Get all deposits (transactions)
        public async Task<List<BML.ViewDeposit>> ViewDepositsAsync()
        {
            try
            {
                List<BML.ViewDeposit> deposits = new List<BML.ViewDeposit>();

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("ManageAccountAndDeposit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operation", "ViewDeposit");

                    await connection.OpenAsync();
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            BML.ViewDeposit deposit = new BML.ViewDeposit
                            {
                                TrxAccountId = reader["TrxAccountId"].ToString(),
                                AccountID = reader["AccountID"].ToString(),
                                TransactionType = reader["TransactionType"].ToString(),
                                Total= reader["Credit"].ToString(),
                                Paid= reader["Debit"].ToString(),
                                Balanace= reader["Balanace"].ToString()
                            };
                            deposits.Add(deposit);
                        }
                    }
                }

                return deposits;
            }
            catch (Exception ex)
            {

                string message = ex.ToString();
                return null;
            }

        }

        public async Task<List<BML.ViewAccountDeposit>> ViewAccountDepositsAsync()
        {
            try
            {
                List<BML.ViewAccountDeposit> deposits = new List<BML.ViewAccountDeposit>();

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("ManageAccountAndDeposit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operation", "ViewAccountDeposit");

                    await connection.OpenAsync();
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            BML.ViewAccountDeposit deposit = new BML.ViewAccountDeposit
                            {
                                AccountID = reader["AccountID"].ToString(),
                                SerialId = reader["SerialId"].ToString(),
                                TrxAccountId = reader["TrxAccountId"].ToString(),
                                TransactionType = reader["TransactionType"].ToString(),
                                TransactionDate = reader["TransactionDate"].ToString(),
                                DebitAmount = reader["DebitAmount"].ToString(),
                                CreditAmount = reader["CreditAmount"].ToString(),
                                PaymentMethod = reader["PaymentMethod"].ToString(),
                                BankName = reader["BankName"].ToString(),
                                CheckNo = reader["CheckNo"].ToString(),
                                Remarks= reader["Remarks"].ToString(),
                            };
                            deposits.Add(deposit);
                        }
                    }
                }

                return deposits;
            }
            catch (Exception ex)
            {

                string message = ex.ToString();
                return null;
            }

        }
    }
}
