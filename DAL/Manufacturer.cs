using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Manufacturer
    {
        private readonly string _connectionString;

        public Manufacturer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateManufacturerAsync(string manufacturerName, string manufacturerAddress, string manufacturerMobile, string manufacturerDetails)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageManufacturer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@ManufacturerName", manufacturerName);
                command.Parameters.AddWithValue("@ManufacturerAddress", manufacturerAddress);
                command.Parameters.AddWithValue("@ManufacturerMobile", manufacturerMobile);
                command.Parameters.AddWithValue("@ManufacturerDetails", manufacturerDetails);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateManufacturerAsync(string manufacturerId, string manufacturerName, string manufacturerAddress, string manufacturerMobile, string manufacturerDetails)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageManufacturer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@ManufacturerId", manufacturerId);
                command.Parameters.AddWithValue("@ManufacturerName", manufacturerName);
                command.Parameters.AddWithValue("@ManufacturerAddress", manufacturerAddress);
                command.Parameters.AddWithValue("@ManufacturerMobile", manufacturerMobile);
                command.Parameters.AddWithValue("@ManufacturerDetails", manufacturerDetails);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteManufacturerAsync(string manufacturerId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageManufacturer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@ManufacturerId", manufacturerId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.Manufacturer>> GetManufacturersAsync()
        {
            List<BML.Manufacturer> manufacturers = new List<BML.Manufacturer>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageManufacturer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.Manufacturer manufacturer = new BML.Manufacturer
                        {
                            ManufacturerId = reader["ManufacturerId"].ToString(),
                            ManufacturerName = reader["ManufacturerName"].ToString(),
                            ManufacturerAddress = reader["ManufacturerAddress"].ToString(),
                            ManufacturerMobile = reader["ManufacturerMobile"].ToString(),
                            ManufacturerDetails = reader["ManufacturerDetails"].ToString()
                        };
                        manufacturers.Add(manufacturer);
                    }
                }
            }

            return manufacturers;
        }
    }
}
