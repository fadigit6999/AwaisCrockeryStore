using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        private readonly string _connectionString;

        public User(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateUserAsync(string firstName, string lastName, string userName, string email, string passwordHash, string phoneNumber, bool emailConfirmed, bool phoneNumberConfirmed, bool twoFactorEnabled, bool lockoutEnabled, int accessFailedCount, DateTime dateCreated)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_Users", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "CREATE");
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@EmailConfirmed", emailConfirmed);
                command.Parameters.AddWithValue("@PhoneNumberConfirmed", phoneNumberConfirmed);
                command.Parameters.AddWithValue("@TwoFactorEnabled", twoFactorEnabled);
                command.Parameters.AddWithValue("@LockoutEnabled", lockoutEnabled);
                command.Parameters.AddWithValue("@AccessFailedCount", accessFailedCount);
                command.Parameters.AddWithValue("@DateCreated", dateCreated);

                await connection.OpenAsync();

                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateUserAsync(string userId, string firstName, string lastName, string userName, string email, string passwordHash, string phoneNumber, bool emailConfirmed, bool phoneNumberConfirmed, bool twoFactorEnabled, bool lockoutEnabled, int accessFailedCount)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_Users", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "UPDATE");
                command.Parameters.AddWithValue("@Id", userId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@EmailConfirmed", emailConfirmed);
                command.Parameters.AddWithValue("@PhoneNumberConfirmed", phoneNumberConfirmed);
                command.Parameters.AddWithValue("@TwoFactorEnabled", twoFactorEnabled);
                command.Parameters.AddWithValue("@LockoutEnabled", lockoutEnabled);
                command.Parameters.AddWithValue("@AccessFailedCount", accessFailedCount);

                await connection.OpenAsync();

                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteUserAsync(string userId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_Users", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "DELETE");
                command.Parameters.AddWithValue("@Id", userId);

                await connection.OpenAsync();

                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.AspNetUser>> ReadUserAsync()
        {
            List<BML.AspNetUser> userList = new List<BML.AspNetUser>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_Users", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "READ");

                await connection.OpenAsync();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.AspNetUser user = new BML.AspNetUser
                        {
                            Id = reader["Id"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            UserName = reader["UserName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            DateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated")),
                            Status = reader["EmailConfirmed"].ToString() == "True" ? "Enabled" : "Disabled",
                            UserRole = reader["userRole"].ToString()

                        };
                        userList.Add(user);
                    }
                }
            }

            return userList;
        }

        public async Task<(string, string)> GetUserCredentialsByUsernameAsync(string username)
        {
            string retrievedUsername = null;
            string retrievedPassword = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("Manage_Users", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Action", "GETBYUSERNAME");
                    command.Parameters.AddWithValue("@UserName", username);

                    try
                    {
                        await connection.OpenAsync();
                        SqlDataReader reader = await command.ExecuteReaderAsync();
                        if (reader.Read())
                        {
                            // Retrieve username and password from reader
                            retrievedUsername = reader["UserName"].ToString();
                            retrievedPassword = reader["PasswordHash"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return (retrievedUsername, retrievedPassword);
        }

    }
}
