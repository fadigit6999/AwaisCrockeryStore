using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Customer
    {
        private readonly string _connectionString;

        public Customer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateCustomerAsync(string firstName, string email, string phone, string addressLine1,string customerType,string Category,string dsl)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@AddressLine1", addressLine1);
                command.Parameters.AddWithValue("@CustomerType", customerType);
                command.Parameters.AddWithValue("@Category", Category);
                command.Parameters.AddWithValue("@DSL", dsl);
                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateCustomerAsync(string customerId, string firstName, string lastName, string email, string phone, string addressLine1, DateTime entryDate, string customerType)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@AddressLine1", addressLine1);
                command.Parameters.AddWithValue("@Entry_Date", entryDate);
                command.Parameters.AddWithValue("@CustomerType", customerType);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteCustomerAsync(string customerId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@CustomerID", customerId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.Customer>> GetCustomersAsync()
        {
            List<BML.Customer> customers = new List<BML.Customer>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Read");

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.Customer customer = new BML.Customer
                        {
                            CustomerID = reader["CustomerID"].ToString(),
                            FullName =$"{reader["FirstName"].ToString()}",
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            AddressLine1 = reader["AddressLine1"].ToString(),
                            CustomerType = reader["CustomerType"].ToString(),
                            Category = reader["Category"].ToString(),
                            DSL= reader["DSL"].ToString()
                        };
                        customers.Add(customer);
                    }
                }
            }

            return customers;
        }
    }
}
