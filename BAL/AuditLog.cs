using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class AuditLog
    {
        private readonly DAL.AuditLog _auditDAL;

        public AuditLog(string connectionString)
        {
            _auditDAL = new DAL.AuditLog(connectionString);
        }

        public async Task CreateAuditLodAsync(string log)
        {
            try
            {
                await _auditDAL.CreateLogAsync(log);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating unit: {ex.Message}");
            }
        }

        public async Task<List<BML.AuditLog>> GetLogsAsync(DateTime? logDate = null)
        {
            try
            {
                return await _auditDAL.GetAuditLogsAsync(logDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting units: {ex.Message}");
                return new List<BML.AuditLog>();
            }
        }
    }
}
