using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Area
    {
        private readonly string _connectionString;

        public Area(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateAreaAsync(string areaName, string areaDescription)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesArea", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@AreaName", areaName);
                command.Parameters.AddWithValue("@AreaDescription", areaDescription);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateAreaAsync(string areaId, string areaName, string areaDescription)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesArea", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@AreaId", areaId);
                command.Parameters.AddWithValue("@AreaName", areaName);
                command.Parameters.AddWithValue("@AreaDescription", areaDescription);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteAreaAsync(string areaId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesArea", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@AreaId", areaId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.Area>> GetAreasAsync()
        {
            List<BML.Area> areas = new List<BML.Area>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageSalesArea", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.Area area = new BML.Area
                        {
                            AreaId = reader["AreaId"].ToString(),
                            AreaName = reader["AreaName"].ToString(),
                            AreaDescription = reader["AreaDescription"].ToString()
                        };
                        areas.Add(area);
                    }
                }
            }

            return areas;
        }
    }

}
