using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAL
{
    public class AuthenticationKey
    {
        private readonly DAL.AuthenticationKey _authDAL;

        public AuthenticationKey(string connectionString)
        {
            _authDAL = new DAL.AuthenticationKey(connectionString);
        }

        public async Task<int> SaveAuthKeyIvAsync(string key, string iv)
        {
            try
            {
                return await _authDAL.SaveKeyAndIVAsync(key, iv);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating Authentication: {ex.Message}");
                return 0;
            }
        }

        public async Task<BML.AuthenticationKey> GetKeysAndIVsAsync()
        {
            try
            {
                return await _authDAL.GetKeysAndIVsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating Authentication: {ex.Message}");
                return null;
            }
        }
    }
}
