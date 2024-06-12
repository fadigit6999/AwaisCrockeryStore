using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Unit
    {
        private readonly DAL.Unit _unitDAL;

        public Unit(string connectionString)
        {
            _unitDAL = new DAL.Unit(connectionString);
        }

        public async Task<int> CreateUnitAsync(string unitName)
        {
            try
            {
                return await _unitDAL.CreateUnitAsync(unitName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating unit: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateUnitAsync(string unitId, string unitName)
        {
            try
            {
                return await _unitDAL.UpdateUnitAsync(unitId, unitName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating unit: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteUnitAsync(string unitId)
        {
            try
            {
                return await _unitDAL.DeleteUnitAsync(unitId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting unit: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Unit>> GetUnitsAsync()
        {
            try
            {
                return await _unitDAL.GetUnitsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting units: {ex.Message}");
                return new List<BML.Unit>();
            }
        }
    }
}
