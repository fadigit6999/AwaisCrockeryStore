using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Booker
    {
        private readonly DAL.Booker _bookerDAL;

        public Booker(string connectionString)
        {
            _bookerDAL = new DAL.Booker(connectionString);
        }

        public async Task<int> CreateBookerAsync(string name, string email, string phone, string notes)
        {
            try
            {
                return await _bookerDAL.CreateBookerAsync(name, email, phone, notes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating booker: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateBookerAsync(string bookerId, string name, string email, string phone, string notes)
        {
            try
            {
                return await _bookerDAL.UpdateBookerAsync(bookerId, name, email, phone, notes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating booker: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteBookerAsync(string bookerId)
        {
            try
            {
                return await _bookerDAL.DeleteBookerAsync(bookerId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting booker: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Booker>> GetBookersAsync()
        {
            try
            {
                return await _bookerDAL.GetBookersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting bookers: {ex.Message}");
                return new List<BML.Booker>();
            }
        }
    }
}
