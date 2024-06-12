using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Area
    {
        private readonly DAL.Area _areaDAL;

        public Area(string connectionString)
        {
            _areaDAL = new DAL.Area(connectionString);
        }

        public async Task<int> CreateAreaAsync(string areaName, string areaDescription)
        {
            try
            {
                return await _areaDAL.CreateAreaAsync(areaName, areaDescription);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating area: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateAreaAsync(string areaId, string areaName, string areaDescription)
        {
            try
            {
                return await _areaDAL.UpdateAreaAsync(areaId, areaName, areaDescription);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating area: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteAreaAsync(string areaId)
        {
            try
            {
                return await _areaDAL.DeleteAreaAsync(areaId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting area: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Area>> GetAreasAsync()
        {
            try
            {
                return await _areaDAL.GetAreasAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting areas: {ex.Message}");
                return new List<BML.Area>();
            }
        }
    }

}
