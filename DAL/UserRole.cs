using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRole
    {
        private readonly string _connectionString;

        public UserRole(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> ManageUserRoleAsync(string operation, string roleId = null, string roleName = null, string normalizedName = null, string concurrencyStamp = null, string userId = null)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_UserRole", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", operation);
                command.Parameters.AddWithValue("@RoleId", roleId);
                command.Parameters.AddWithValue("@RoleName", roleName);
                command.Parameters.AddWithValue("@NormalizedName", normalizedName);
                command.Parameters.AddWithValue("@ConcurrencyStamp", concurrencyStamp);
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    await connection.OpenAsync();
                    result = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine(ex.Message);
                }
            }

            return result;
        }

        //public async Task<List<User>> GetUsersByRoleAsync(string roleId)
        //{
        //    List<User> userList = new List<User>();

        //    using (var connection = new SqlConnection(_connectionString))
        //    using (var command = new SqlCommand("Manage_UserRole", connection))
        //    {
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.Parameters.AddWithValue("@Operation", "GetUsersByRole");
        //        command.Parameters.AddWithValue("@RoleId", roleId);

        //        try
        //        {
        //            await connection.OpenAsync();

        //            using (var reader = await command.ExecuteReaderAsync())
        //            {
        //                while (await reader.ReadAsync())
        //                {
        //                    // Populate user data from reader
        //                    // Adjust this part based on your actual user data structure
        //                    User user = new User
        //                    {
        //                        // Populate user properties
        //                    };
        //                    userList.Add(user);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle exceptions
        //            Console.WriteLine(ex.Message);
        //        }
        //    }

        //    return userList;
        //}

        public async Task<int> CreateRoleAsync(string roleId, string roleName, string normalizedName, string concurrencyStamp)
        {
            return await ManageUserRoleAsync("CreateRole", string.Empty, roleName, roleName.ToUpper(), string.Empty);
        }

        public async Task<List<BML.AspNetRole>> ReadUserRolesAsync()
        {
            List<BML.AspNetRole> userRoleList = new List<BML.AspNetRole>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_UserRole", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ReadRole");

                await connection.OpenAsync();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.AspNetRole userRoles = new BML.AspNetRole
                        {
                            Id = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                        };
                        userRoleList.Add(userRoles);
                    }
                }
            }

            return userRoleList;
        }

        public async Task<int> UpdateRoleAsync(string roleId, string roleName, string normalizedName, string concurrencyStamp)
        {
            return await ManageUserRoleAsync("UpdateRole", roleId, roleName, normalizedName, concurrencyStamp);
        }

        public async Task<int> DeleteRoleAsync(string roleId)
        {
            return await ManageUserRoleAsync("DeleteRole", roleId);
        }

        public async Task<int> AssignUserRoleAsync(string userId, string roleId)
        {
            return await ManageUserRoleAsync("AssignUserRole", roleId: roleId, userId: userId);
        }

        public async Task<int> RemoveUserRoleAsync(string userId, string roleId)
        {
            return await ManageUserRoleAsync("RemoveUserRole", roleId: roleId, userId: userId);
        }

        // Add other methods as needed for your specific requirements

    }
}
