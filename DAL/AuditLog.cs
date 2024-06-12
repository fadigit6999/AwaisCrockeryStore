using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuditLog
    {
        private readonly string _connectionString;

        public AuditLog(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task CreateLogAsync(string log)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("LogAudit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@ChangeDescription", log);


                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<List<BML.AuditLog>> GetAuditLogsAsync(DateTime? date = null)
        {
            List<BML.AuditLog> auditLogs = new List<BML.AuditLog>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("LogAudit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                if (date.HasValue)
                {
                    command.Parameters.AddWithValue("@date", date.Value);
                }
                else
                {
                    // If no specific date provided, pass NULL to the stored procedure parameter
                    command.Parameters.AddWithValue("@date", DBNull.Value);
                }

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.AuditLog auditLog = new BML.AuditLog
                        {
                            // Assuming column names and types, adjust accordingly
                            ChangeDate = (DateTime)reader["ChangeDate"],
                            ChangeDescription = reader["ChangeDescription"].ToString()
                        };
                        auditLogs.Add(auditLog);
                    }
                }
            }

            return auditLogs;
        }

    }
}
