﻿using BML;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class Account
    {
        private readonly string _connectionString;

        public Account(string connectionString)
        {
            _connectionString = connectionString;
        }

        // done
        public async Task<int> CreateAccountAsync(string accountName, string accountType)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection)) // Assuming stored procedure name is 'ManageAccount'
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "CreateAccount");
                command.Parameters.AddWithValue("@AccountName", accountName);
                command.Parameters.AddWithValue("@AccountType", accountType);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        // Update an existing account
        public async Task<int> UpdateAccountAsync(string accountId, string accountName, decimal currentBalance)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@AccountId", accountId);
                command.Parameters.AddWithValue("@AccountName", accountName);
                command.Parameters.AddWithValue("@CurrentBalance", currentBalance);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        // Delete an account
        public async Task<int> DeleteAccountAsync(string accountId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@AccountId", accountId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        // done
        public async Task<List<BML.ViewAccount>> GetAccountsAsync()
        {
            List<BML.ViewAccount> accounts = new List<BML.ViewAccount>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection))  // Assuming your SP name is 'ManageAccountAndDeposit'
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ReadAccount");  // This operation name based on your requirement

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.ViewAccount account = new BML.ViewAccount
                        {
                            AccountID = reader["AccountID"].ToString(),
                            AccountName = reader["AccountName"].ToString(),
                            SerialId = reader["SerialId"].ToString(),
                            Name = reader["Name"].ToString(),
                            Mobile = reader["Mobile"].ToString(),
                            AccountType = reader["AccountType"].ToString(),
                            CurrentBalance = reader["CurrentBalance"].ToString(),
                            CreatedDate = reader["CreatedDate"].ToString()
                        };
                        accounts.Add(account);
                    }
                }
            }

            return accounts;
        }


        public async Task<List<BML.Party>> GetPartiesAsync()
        {
            List<BML.Party> parties = new List<BML.Party>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "GetParty");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.Party party = new BML.Party
                        {
                            id = reader["id"].ToString(),
                            name = reader["name"].ToString()
                        };
                        parties.Add(party);
                    }
                }
            }

            return parties;
        }


        public async Task<List<BML.CmbDepositInvoice>> GetInvoicesAsync()
        {
            List<BML.CmbDepositInvoice> invoices = new List<BML.CmbDepositInvoice>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection)) // Assuming the stored procedure name is 'ManageAccountAndDeposit'
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "GetInvoices"); // Set the operation to 'GetInvoices'

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.CmbDepositInvoice invoice = new BML.CmbDepositInvoice
                        {
                            Orderid = reader["orderid"].ToString(),
                            MfgId = reader["id"].ToString(),
                            InvoiceNo = reader["invoice"].ToString(),
                              Total = reader["total"].ToString()
                        };
                        invoices.Add(invoice);
                    }
                }
            }

            return invoices;
        }

        // Create a new record in TransactionAccount
        public async Task<int> CreateAdjustmentAccountAsync(string accountId, string transactionId, string transactionType, decimal totalDepositAmount, DateTime? depositDate = null, string remarks = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Operation", "CreateTA");
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
        public async Task<List<ViewAdjustmentAccount>> ReadTransactionAccountAsync()
        {
            List<ViewAdjustmentAccount> accounts = new List<ViewAdjustmentAccount>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ReadTA");

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
            using (var command = new SqlCommand("ManageAccountAndDeposit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "GetTransactionAccountUniqueId");

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
