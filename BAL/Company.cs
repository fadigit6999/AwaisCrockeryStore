using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Company
    {
        private readonly DAL.Company _companyDAL;

        public Company(string connectionString)
        {
            _companyDAL = new DAL.Company(connectionString);
        }

        public async Task<int> CreateCompanyAsync(string companyName = null, string address = null, string city = null, string state = null, string postalCode = null, string country = null, string phone = null, string fax = null, string email = null, string website = null, string contactPerson = null, string contactPhone = null, string contactEmail = null, string registrationNumber = null, string taxNumber = null, string notes = null)
        {
            try
            {
                return await _companyDAL.CreateCompanyAsync(companyName , address , city , state , postalCode , country , phone , fax ,email , website , contactPerson , contactPhone , contactEmail , registrationNumber , taxNumber , notes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating user: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Company>> ReadCompanyAsync()
        {
            try
            {
                return await _companyDAL.ReadCompanyAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating user: {ex.Message}");
                return new List<BML.Company>();
            }
        }

    }
}
