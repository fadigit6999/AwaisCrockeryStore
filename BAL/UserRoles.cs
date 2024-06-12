using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class UserRoles
    {
        private readonly DAL.UserRole _userRoleDAL;

        public UserRoles(string connectionString)
        {
            _userRoleDAL = new DAL.UserRole(connectionString);
        }

        public async Task<int> CreateRoleAsync(string roleName)
        {
            try
            {
                return await _userRoleDAL.CreateRoleAsync(string.Empty,roleName,string.Empty,string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating role: {ex.Message}");
                return 0; // Or any appropriate error code or handling
            }
        }

        public async Task<List<BML.AspNetRole>> ReadUserRolesAsync()
        {
            try
            {
                return await _userRoleDAL.ReadUserRolesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading user roles: {ex.Message}");
                return new List<BML.AspNetRole>(); // Or any appropriate error handling
            }
        }

        public async Task<int> UpdateRoleAsync(string roleId, string roleName, string normalizedName, string concurrencyStamp)
        {
            try
            {
                return await _userRoleDAL.UpdateRoleAsync(roleId, roleName, normalizedName, concurrencyStamp);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating role: {ex.Message}");
                return 0; // Or any appropriate error code or handling
            }
        }

        public async Task<int> DeleteRoleAsync(string roleId)
        {
            try
            {
                return await _userRoleDAL.DeleteRoleAsync(roleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting role: {ex.Message}");
                return 0; // Or any appropriate error code or handling
            }
        }

        public async Task<int> AssignUserRoleAsync(string userId, string roleId)
        {
            try
            {
                return await _userRoleDAL.AssignUserRoleAsync(userId, roleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error assigning user role: {ex.Message}");
                return 0; // Or any appropriate error code or handling
            }
        }

        public async Task<int> RemoveUserRoleAsync(string userId, string roleId)
        {
            try
            {
                return await _userRoleDAL.RemoveUserRoleAsync(userId, roleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing user role: {ex.Message}");
                return 0; // Or any appropriate error code or handling
            }
        }

        //public async Task<List<User>> GetUsersByRoleAsync(string roleId)
        //{
        //    try
        //    {
        //        return await _userRoleDAL.GetUsersByRoleAsync(roleId);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error getting users by role: {ex.Message}");
        //        return new List<User>(); // Or any appropriate error handling
        //    }
        //}

        // Add other methods as needed for your specific requirements
    }


}
