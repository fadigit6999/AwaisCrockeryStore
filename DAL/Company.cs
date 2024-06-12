using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.AxHost;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Net;

namespace DAL
{
    public class Company
    {
        private readonly string _connectionString;

        public Company(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateCompanyAsync(string companyName = null, string address = null, string city = null, string state = null, string postalCode = null, string country = null, string phone = null, string fax = null, string email = null, string website = null, string contactPerson = null, string contactPhone = null, string contactEmail = null, string registrationNumber = null, string taxNumber = null, string notes = null)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_Company", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Insert");
                command.Parameters.AddWithValue("@CompanyName", companyName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Fax", fax);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Website", website);
                command.Parameters.AddWithValue("@ContactPerson", contactPerson);
                command.Parameters.AddWithValue("@ContactPhone", contactPhone);
                command.Parameters.AddWithValue("@ContactEmail", contactEmail);
                command.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);
                command.Parameters.AddWithValue("@TaxNumber", taxNumber);
                command.Parameters.AddWithValue("@Notes", notes);

                await connection.OpenAsync();

                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<List<BML.Company>> ReadCompanyAsync()
        {
            List<BML.Company> companyList = new List<BML.Company>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("Manage_Company", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Select");

                await connection.OpenAsync();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.Company company = new BML.Company
                        {
                            CompanyId = reader["CompanyId"].ToString(),
                            CompanyName = reader["CompanyName"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            PostalCode = reader["PostalCode"].ToString(),
                            Country = reader["Country"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Fax = reader["Fax"].ToString(),
                            Email = reader["Email"].ToString(),
                            Website = reader["Website"].ToString(),
                            ContactPerson = reader["ContactPerson"].ToString(),
                            ContactPhone = reader["ContactPhone"].ToString(),
                            ContactEmail = reader["ContactEmail"].ToString(),
                            RegistrationNumber = reader["RegistrationNumber"].ToString(),
                            TaxNumber = reader["TaxNumber"].ToString(),
                            Notes = reader["Notes"].ToString()
                        };
                        companyList.Add(company);
                    }
                }
            }

            return companyList;
        }

    }
}
