using DAL;

namespace BAL
{
    public class User
    {
        private readonly DAL.User _userDAL;

        public User(string connectionString)
        {
            _userDAL = new DAL.User(connectionString);
        }

        public async Task<int> CreateUserAsync(string firstName, string lastName, string userName, string email, string passwordHash, string phoneNumber, bool emailConfirmed, bool phoneNumberConfirmed, bool twoFactorEnabled, bool lockoutEnabled, int accessFailedCount, DateTime dateCreated)
        {
            try
            {
                return await _userDAL.CreateUserAsync(firstName, lastName, userName, email, passwordHash, phoneNumber, emailConfirmed, phoneNumberConfirmed, twoFactorEnabled, lockoutEnabled, accessFailedCount, dateCreated);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating user: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateUserAsync(string userId, string firstName, string lastName, string userName, string email, string passwordHash, string phoneNumber, bool emailConfirmed, bool phoneNumberConfirmed, bool twoFactorEnabled, bool lockoutEnabled, int accessFailedCount)
        {
            try
            {
                return await _userDAL.UpdateUserAsync(userId, firstName, lastName, userName, email, passwordHash, phoneNumber, emailConfirmed, phoneNumberConfirmed, twoFactorEnabled, lockoutEnabled, accessFailedCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.AspNetUser>> ReadUserAsync()
        {
            try
            {
                return await _userDAL.ReadUserAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Reading user: {ex.Message}");
                return new List<BML.AspNetUser>();
            }
        }

        public async Task<(string, string)> GetUserCredentialsByUsernameAsync(string username)
        {
            try
            {
                return await _userDAL.GetUserCredentialsByUsernameAsync(username);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error: {ex.Message}");
                throw; // Rethrow the exception to the caller
            }
        }
    }
}
