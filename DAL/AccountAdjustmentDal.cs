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
        public async Task<int> CreateAdjustmentDepositAsync(string trxId, int serialId, string accountId, string transactionId, DateTime transactionDate, decimal totalAmount,
                                                            string paymentMethod, string bankName, string checkNo, decimal paidAmount, decimal balance, string remarks, int isPaid)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAdjustmentRecords", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TableName", "AdjustmentDeposit");
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@TrxId", trxId);
                command.Parameters.AddWithValue("@SerialId", serialId);
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
                command.Parameters.AddWithValue("@isPaid", isPaid);

                await connection.OpenAsync();
                return await command.ExecuteNonQueryAsync();
            }
        }

        // Read records from AdjustmentDeposit
        public async Task<List<AdjustmentDeposit>> ReadAdjustmentDepositAsync(string trxId = null)
        {
            List<AdjustmentDeposit> deposits = new List<AdjustmentDeposit>();

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
                        deposits.Add(new AdjustmentDeposit
                        {
                            TrxId = reader["TrxId"].ToString(),
                            SerialId = (int)reader["SerialId"],
                            AccountID = reader["AccountID"].ToString(),
                            TransactionID = reader["TransactionID"].ToString(),
                            TransactionDate = (DateTime)reader["TransactionDate"],
                            TotalAmount = (decimal)reader["TotalAmount"],
                            PaymentMethod = reader["PaymentMethod"].ToString(),
                            BankName = reader["BankName"].ToString(),
                            CheckNo = reader["CheckNo"].ToString(),
                            PaidAmount = (decimal)reader["PaidAmount"],
                            Balance = (decimal)reader["Balance"],
                            Remarks = reader["Remarks"].ToString(),
                            CreatedDate = (DateTime)reader["CreatedDate"],
                            isPaid = (int)reader["isPaid"]
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
                            TransactionID = reader["TransactionID"].ToString(),
                            TransactionType = reader["TransactionType"].ToString(),
                            DepositDate = (DateTime)reader["DepositDate"],
                            TotalDepositAmount = (decimal)reader["TotalDepositAmount"],
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

    }
}
