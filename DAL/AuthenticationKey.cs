using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuthenticationKey
    {
        private readonly string _connectionString;

        public AuthenticationKey(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> SaveKeyAndIVAsync(string key, string iv)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("INSERT INTO AuthenticationKey (EncryKey, IV) VALUES (@EncryKey, @IV)", connection))
            {
                command.Parameters.AddWithValue("@EncryKey", key);
                command.Parameters.AddWithValue("@IV", iv);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<BML.AuthenticationKey> GetKeysAndIVsAsync()
        {
            var keysAndIVs = new BML.AuthenticationKey();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SELECT EncryKey, IV FROM AuthenticationKey", connection))
            {
                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        keysAndIVs.Key= reader["EncryKey"].ToString();
                        keysAndIVs.Iv = reader["IV"].ToString();
                    }
                }
            }

            return keysAndIVs;
        }
    }
}
