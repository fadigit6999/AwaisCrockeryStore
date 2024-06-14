using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Medicine
    {
        private readonly DAL.Medicine _medicineDAL;

        public Medicine(string connectionString)
        {
            _medicineDAL = new DAL.Medicine(connectionString);
        }

        public async Task<int> CreateMedicineAsync(string barcode, string name, string strength, string genericName, string boxSize, string unit, string medicineShelf, string details, string medicineTypeId, string image, string categoryId, decimal sellPrice, string manufacturerId, decimal manufacturerPrice,string nameUrdu)
        {
            try
            {
                return await _medicineDAL.CreateMedicineAsync(barcode, name, strength, genericName, boxSize, unit, medicineShelf, details, medicineTypeId, image, categoryId, sellPrice, manufacturerId, manufacturerPrice,nameUrdu);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating medicine: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateMedicineAsync(string medicineId, string barcode, string name, string strength, string genericName, string boxSize, string unit, string medicineShelf, string details, string medicineTypeId, string image, string categoryId, decimal sellPrice, string manufacturerId, decimal manufacturerPrice,string nameUrdu)
        {
            try
            {
                return await _medicineDAL.UpdateMedicineAsync(medicineId, barcode, name, strength, genericName, boxSize, unit, medicineShelf, details, medicineTypeId, image, categoryId, sellPrice, manufacturerId, manufacturerPrice,nameUrdu);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating medicine: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteMedicineAsync(string medicineId)
        {
            try
            {
                return await _medicineDAL.DeleteMedicineAsync(medicineId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting medicine: {ex.Message}");
                return 0;
            }
        }

        public async Task<BML.Medicine> GetMedicinesAsync(string guid)
        {
            try
            {
                return await _medicineDAL.GetMedicinesAsync(guid);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting medicines: {ex.Message}");
                return new BML.Medicine();
            }
        }

        public async Task<List<BML.Medicine>> GetMedicinesGroupAsync()
        {
            try
            {
                return await _medicineDAL.GetMedicinesGroupAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting medicines: {ex.Message}");
                return new List<BML.Medicine>();
            }
        }

        public async Task<List<BML.Medicine>> GetMedicinesDropdownGroupAsync()
        {
            try
            {
                return await _medicineDAL.GetDropdownAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting medicines: {ex.Message}");
                return new List<BML.Medicine>();
            }
        }

        public async Task<List<BML.Medicine>> GetMedicinesDropdownStockBasedGroupAsync()
        {
            try
            {
                return await _medicineDAL.GetDropdownSaleDropdownAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting medicines: {ex.Message}");
                return new List<BML.Medicine>();
            }
        }
    }
}
