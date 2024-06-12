using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Customer
    {
        private readonly DAL.Customer _customerDAL;

        public Customer(string connectionString)
        {
            _customerDAL = new DAL.Customer(connectionString);
        }

        public async Task<int> CreateCustomerAsync(string firstName, string email, string phone, string addressLine1, string customerType,string category,string dsl)
        {
            try
            {
                return await _customerDAL.CreateCustomerAsync(firstName, email, phone, addressLine1, customerType,category,dsl);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating customer: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateCustomerAsync(string customerId, string firstName, string lastName, string email, string phone, string addressLine1, DateTime entryDate, string customerType)
        {
            try
            {
                return await _customerDAL.UpdateCustomerAsync(customerId, firstName, lastName, email, phone, addressLine1, entryDate, customerType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating customer: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteCustomerAsync(string customerId)
        {
            try
            {
                return await _customerDAL.DeleteCustomerAsync(customerId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting customer: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Customer>> GetCustomersAsync()
        {
            try
            {
                return await _customerDAL.GetCustomersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting customers: {ex.Message}");
                return new List<BML.Customer>();
            }
        }
    }
}
