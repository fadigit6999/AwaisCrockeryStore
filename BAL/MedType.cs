using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class MedType
    {
        private readonly DAL.MedType _medTypeDAL;

        public MedType(string connectionString)
        {
            _medTypeDAL = new DAL.MedType(connectionString);
        }

        public async Task<int> CreateMedicineTypeAsync(string typeName)
        {
            try
            {
                return await _medTypeDAL.CreateMedicineTypeAsync(typeName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating medicine type: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateMedicineTypeAsync(string typeId, string typeName)
        {
            try
            {
                return await _medTypeDAL.UpdateMedicineTypeAsync(typeId, typeName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating medicine type: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteMedicineTypeAsync(string typeId)
        {
            try
            {
                return await _medTypeDAL.DeleteMedicineTypeAsync(typeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting medicine type: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.MedType>> GetMedicineTypesAsync()
        {
            try
            {
                return await _medTypeDAL.GetMedicineTypesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting medicine types: {ex.Message}");
                return new List<BML.MedType>();
            }
        }
    }
}
