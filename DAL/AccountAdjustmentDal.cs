using BML;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountAdjustmentDal
    {
        private readonly string _connectionString;

        public AccountAdjustmentDal(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Create a new record in AdjustmentDeposit
        public async Task<int> CreateAdjustmentDepositAsync(string accountId, string transactionId, DateTime transactionDate, decimal totalAmount,
                                                            string paymentMethod, string bankName, string checkNo, decimal paidAmount, decimal balance, string remarks)
        {
            int result = 0;
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAdjustmentRecords", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TableName", "AdjustmentDeposit");
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@AccountID", accountId);
                command.Parameters.AddWithValue("@TransactionID", transactionId);
                command.Parameters.AddWithValue("@TransactionDate", transactionDate);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.Parameters.AddWithValue("@BankName", bankName);
                command.Parameters.AddWithValue("@CheckNo", checkNo);
                command.Parameters.AddWithValue("@PaidAmount", paidAmount);
                command.Parameters.AddWithValue("@Balance", balance);
                command.Parameters.AddWithValue("@Remarks", remarks);

                await connection.OpenAsync();
                return result = await command.ExecuteNonQueryAsync();
            }
        }

        // Read records from AdjustmentDeposit
        public async Task<List<ViewAdjustmentDeposit>> ReadAdjustmentDepositAsync(string trxId = null)
        {
            List<ViewAdjustmentDeposit> deposits = new List<ViewAdjustmentDeposit>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAdjustmentRecords", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TableName", "AdjustmentDeposit");
                command.Parameters.AddWithValue("@Operation", "Read");
                command.Parameters.AddWithValue("@TrxId", trxId ?? (object)DBNull.Value);

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        deposits.Add(new ViewAdjustmentDeposit
                        {
                            TrxId = reader["TrxId"].ToString(),
                            SerialId = reader["SerialId"].ToString(),
                            AccountID = reader["AccountID"].ToString(),
                            TransactionID = reader["TransactionID"].ToString(),
                            TransactionType = reader["TransactionType"].ToString(),
                            TransactionDate = reader["TransactionDate"].ToString(),
                            TotalAmount = reader["TotalAmount"].ToString(),
                            PaymentMethod = reader["PaymentMethod"].ToString(),
                            BankName = reader["BankName"].ToString(),
                            CheckNo = reader["CheckNo"].ToString(),
                            PaidAmount = reader["PaidAmount"].ToString(),
                            Balance = reader["Balance"].ToString(),
                            Remarks = reader["Remarks"].ToString(),
                            CreatedDate = reader["CreatedDate"].ToString(),
                            isPaid = reader["isPaid"].ToString()
                        });
                    }
                }
            }

            return deposits;
        }

        // Create a new record in AdjustmentAccount
        public async Task<int> CreateAdjustmentAccountAsync(string accountId, string transactionId, string transactionType, decimal totalDepositAmount, DateTime? depositDate = null, string remarks = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAdjustmentRecords", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TableName", "AdjustmentAccount");
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@AccountID", accountId);
                command.Parameters.AddWithValue("@TransactionID", transactionId);
                command.Parameters.AddWithValue("@TransactionType", transactionType);
                command.Parameters.AddWithValue("@TotalDepositAmount", totalDepositAmount);
                command.Parameters.AddWithValue("@DepositDate", depositDate ?? DateTime.Now);
                command.Parameters.AddWithValue("@Remarks", remarks ?? (object)DBNull.Value);

                await connection.OpenAsync();
                return await command.ExecuteNonQueryAsync();
            }
        }

        // Read records from AdjustmentAccount
        public async Task<List<ViewAdjustmentAccount>> ReadAdjustmentAccountAsync()
        {
            List<ViewAdjustmentAccount> accounts = new List<ViewAdjustmentAccount>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAdjustmentRecords", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TableName", "AdjustmentAccount");
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        accounts.Add(new ViewAdjustmentAccount
                        {
                            AccountID = reader["AccountID"].ToString(),
                            AccountHolder = reader["AccountHolder"].ToString(),

                            TransactionID = reader["TransactionID"].ToString(),
                            TransactionType = reader["TransactionType"].ToString(),
                            DepositDate = reader["DepositDate"].ToString(),
                            TotalDepositAmount = reader["TotalDepositAmount"].ToString(),
                            Remarks = reader["Remarks"].ToString()
                        });
                    }
                }
            }

            return accounts;
        }

        public async Task<string> GetUniqueTransactionIdAsync()
        {
            string transactionId = null;
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAdjustmentRecords", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TableName", "AdjustmentAccount");
                command.Parameters.AddWithValue("@Operation", "GetTransactionUniqueId");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        transactionId = reader["UniqueTransactionID"].ToString();
                    }
                }
            }

            return transactionId;
        }

        public async Task<List<ViewTransactionIdCMB>> GetTransactionIdCMB()
        {
            List<ViewTransactionIdCMB> transactionIdCMBs = new List<ViewTransactionIdCMB>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAdjustmentRecords", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TableName", "AdjustmentAccount");
                command.Parameters.AddWithValue("@Operation", "GetTransactionIdCMB");   

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        transactionIdCMBs.Add(new ViewTransactionIdCMB
                        {
                            AccountID = reader["AccountID"].ToString(),
                            TransactionID = reader["TransactionID"].ToString()
                        });
                    }
                }
            }

            return transactionIdCMBs;
        }

    }
}
