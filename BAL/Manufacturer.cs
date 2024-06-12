using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Manufacturer
    {
        private readonly DAL.Manufacturer _manufacturerDAL;

        public Manufacturer(string connectionString)
        {
            _manufacturerDAL = new DAL.Manufacturer(connectionString);
        }

        public async Task<int> CreateManufacturerAsync(string manufacturerName, string manufacturerAddress, string manufacturerMobile, string manufacturerDetails)
        {
            try
            {
                return await _manufacturerDAL.CreateManufacturerAsync(manufacturerName, manufacturerAddress, manufacturerMobile, manufacturerDetails);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating manufacturer: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateManufacturerAsync(string manufacturerId, string manufacturerName, string manufacturerAddress, string manufacturerMobile, string manufacturerDetails)
        {
            try
            {
                return await _manufacturerDAL.UpdateManufacturerAsync(manufacturerId, manufacturerName, manufacturerAddress, manufacturerMobile, manufacturerDetails);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating manufacturer: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteManufacturerAsync(string manufacturerId)
        {
            try
            {
                return await _manufacturerDAL.DeleteManufacturerAsync(manufacturerId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting manufacturer: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Manufacturer>> GetManufacturersAsync()
        {
            try
            {
                return await _manufacturerDAL.GetManufacturersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting manufacturers: {ex.Message}");
                return new List<BML.Manufacturer>();
            }
        }
    }
}
