using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BML;

namespace DAL
{
    public class Dashboard
    {
        private readonly string _connectionString;

        public Dashboard(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<BML.Dashboard> GetDashboardMetricsAsync()
        {
            var dashboardMetrics = new BML.Dashboard();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageDashboard", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "DashBoarMetrics");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        dashboardMetrics.Purchase = reader.GetInt32(reader.GetOrdinal("Purchase"));
                        dashboardMetrics.Sale = reader.GetInt32(reader.GetOrdinal("Sale"));
                        dashboardMetrics.Stock = reader.IsDBNull(reader.GetOrdinal("Stock")) ? 0 : reader.GetInt32(reader.GetOrdinal("Stock"));
                        dashboardMetrics.Inventory = reader.GetInt32(reader.GetOrdinal("Inventory"));
                        dashboardMetrics.Customer = reader.GetInt32(reader.GetOrdinal("Customer"));
                        dashboardMetrics.Manufacturer = reader.GetInt32(reader.GetOrdinal("Manufacturer"));
                        dashboardMetrics.Expiry = reader.GetInt32(reader.GetOrdinal("Expiry"));
                    }
                }
            }

            return dashboardMetrics;
        }

        public async Task<List<BML.MedicineStockExpiry>> GetExpiryMedicinesAsync()
        {
            List<BML.MedicineStockExpiry> expiryMedicines = new List<BML.MedicineStockExpiry>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageDashboard", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ExpiryMedics");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var medicineStockInfo = new BML.MedicineStockExpiry
                        {
                            MedName = reader["MedName"].ToString(),
                            Expiry = reader["expiry"].ToString(),
                            BatchId = reader["BatchId"].ToString(),
                            Quantity = reader["Quantity"].ToString()
                        };

                        expiryMedicines.Add(medicineStockInfo);
                    }
                }
            }

            return expiryMedicines;
        }
    }
}
