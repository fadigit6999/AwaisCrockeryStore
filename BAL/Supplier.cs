using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Supplier
    {
        private readonly DAL.Supplier _supplierDAL;

        public Supplier(string connectionString)
        {
            _supplierDAL = new DAL.Supplier(connectionString);
        }

        public async Task<int> CreateSupplierAsync(string name, string companyName, string email, string phone, string address)
        {
            try
            {
                return await _supplierDAL.CreateSupplierAsync(name, companyName, email, phone, address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating supplier: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateSupplierAsync(string supplierId, string name, string companyName, string email, string phone, string address)
        {
            try
            {
                return await _supplierDAL.UpdateSupplierAsync(supplierId, name, companyName, email, phone, address);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating supplier: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteSupplierAsync(string supplierId)
        {
            try
            {
                return await _supplierDAL.DeleteSupplierAsync(supplierId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting supplier: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Supplier>> GetSuppliersAsync()
        {
            try
            {
                return await _supplierDAL.GetSuppliersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting suppliers: {ex.Message}");
                return new List<BML.Supplier>();
            }
        }
    }
}
