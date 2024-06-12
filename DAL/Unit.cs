using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Unit
    {
        private readonly string _connectionString;

        public Unit(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateUnitAsync(string unitName)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageUnit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@UnitName", unitName);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateUnitAsync(string unitId, string unitName)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageUnit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@UnitId", unitId);
                command.Parameters.AddWithValue("@UnitName", unitName);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteUnitAsync(string unitId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageUnit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@UnitId", unitId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.Unit>> GetUnitsAsync()
        {
            List<BML.Unit> units = new List<BML.Unit>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageUnit", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.Unit unit = new BML.Unit
                        {
                            UnitId = reader["UnitId"].ToString(),
                            UnitName = reader["UnitName"].ToString()
                        };
                        units.Add(unit);
                    }
                }
            }

            return units;
        }
    }
}
