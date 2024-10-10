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
        public async Task<int> CreateDepositAsync(DateTime depositdate,string accountId, string invoiceNo, string transactionType, decimal totalAmount, string paymentMethod, decimal paidAmount, decimal balance, string bankName = "", string checkNo = "", string remarks = "")
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
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.Parameters.AddWithValue("@PaidAmount", paidAmount);
                command.Parameters.AddWithValue("@Balance", balance);
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
                                TransactionID = reader["TransactionID"].ToString(),
                                AccountID = reader["AccountID"].ToString(),
                                InvoiceNo = reader["InvoiceNo"].ToString(),
                                TransactionType = reader["TransactionType"].ToString(),
                                TransactionDate = reader["TransactionDate"].ToString(),
                                TotalAmount = (decimal)reader["TotalAmount"],
                                PaymentMethod = reader["PaymentMethod"].ToString(),
                                PaidAmount = (decimal)reader["PaidAmount"],
                                Balance = (decimal)reader["Balance"],
                                BankName = reader["BankName"].ToString(),
                                CheckNo = reader["CheckNo"].ToString(),
                                Remarks = reader["Remarks"].ToString()
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
