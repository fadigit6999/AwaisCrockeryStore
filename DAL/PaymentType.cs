using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PaymentType
    {
        private readonly string _connectionString;

        public PaymentType(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreatePaymentTypeAsync(string typeName)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePaymentType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@TypeName", typeName);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdatePaymentTypeAsync(string paymentTypeId, string typeName)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePaymentType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@PaymentTypeId", paymentTypeId);
                command.Parameters.AddWithValue("@TypeName", typeName);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeletePaymentTypeAsync(string paymentTypeId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePaymentType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@PaymentTypeId", paymentTypeId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.PaymentType>> GetPaymentTypesAsync()
        {
            List<BML.PaymentType> paymentTypes = new List<BML.PaymentType>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManagePaymentType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.PaymentType paymentType = new BML.PaymentType
                        {
                            PaymentTypeId = reader["PaymentTypeId"].ToString(),
                            TypeName = reader["TypeName"].ToString()
                        };
                        paymentTypes.Add(paymentType);
                    }
                }
            }

            return paymentTypes;
        }
    }
}
