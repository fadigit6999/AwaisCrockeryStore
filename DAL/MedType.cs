using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedType
    {
        private readonly string _connectionString;

        public MedType(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateMedicineTypeAsync(string typeName)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@TypeName", typeName);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateMedicineTypeAsync(string typeId, string typeName)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@TypeId", typeId);
                command.Parameters.AddWithValue("@TypeName", typeName);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteMedicineTypeAsync(string typeId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@TypeId", typeId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.MedType>> GetMedicineTypesAsync()
        {
            List<BML.MedType> medicineTypes = new List<BML.MedType>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.MedType medicineType = new BML.MedType
                        {
                            MedicineTypeId = reader["MedicineTypeId"].ToString(),
                            TypeName = reader["TypeName"].ToString()
                        };
                        medicineTypes.Add(medicineType);
                    }
                }
            }

            return medicineTypes;
        }
    }
}
