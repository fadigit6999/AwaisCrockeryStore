using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class DashBoard
    {
        private readonly DAL.Dashboard _dashboardDAL;

        public DashBoard(string connectionString)
        {
            _dashboardDAL = new DAL.Dashboard(connectionString);
        }

        public async Task<BML.Dashboard> DashboardMetricsAsync()
        {
            try
            {
                return await _dashboardDAL.GetDashboardMetricsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating unit: {ex.Message}");
                return null;
            }
        }

        public async Task<List<BML.MedicineStockExpiry>> DashboardExpiryMedicsAsync()
        {
            try
            {
                return await _dashboardDAL.GetExpiryMedicinesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating unit: {ex.Message}");
                return null;
            }
        }

    }
}
