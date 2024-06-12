using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Category
    {
        private readonly DAL.Category _categoryDAL;

        public Category(string connectionString)
        {
            _categoryDAL = new DAL.Category(connectionString);
        }

        public async Task<int> CreateCategoryAsync(string categoryName)
        {
            try
            {
                return await _categoryDAL.CreateCategoryAsync(categoryName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating category: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> UpdateCategoryAsync(string categoryId, string categoryName)
        {
            try
            {
                return await _categoryDAL.UpdateCategoryAsync(categoryId, categoryName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating category: {ex.Message}");
                return 0;
            }
        }

        public async Task<int> DeleteCategoryAsync(string categoryId)
        {
            try
            {
                return await _categoryDAL.DeleteCategoryAsync(categoryId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting category: {ex.Message}");
                return 0;
            }
        }

        public async Task<List<BML.Category>> GetCategoriesAsync()
        {
            try
            {
                return await _categoryDAL.GetCategoriesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting categories: {ex.Message}");
                return new List<BML.Category>();
            }
        }
    }
}
