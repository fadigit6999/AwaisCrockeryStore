using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PaymentType
    {
        private readonly DAL.PaymentType _paymentTypeDAL;

        public PaymentType(string connectionString)
        {
            _paymentTypeDAL = new DAL.PaymentType(connectionString);
        }

        public async Task<int> CreatePaymentTypeAsync(string typeName)
        {
            try
            {
                return await _paymentTypeDAL.CreatePaymentTypeAsync(typeName);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error in CreatePaymentTypeAsync: {ex.Message}");
                return -1; // Or throw the exception
            }
        }

        public async Task<int> UpdatePaymentTypeAsync(string paymentTypeId, string typeName)
        {
            try
            {
                return await _paymentTypeDAL.UpdatePaymentTypeAsync(paymentTypeId, typeName);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error in UpdatePaymentTypeAsync: {ex.Message}");
                return -1; // Or throw the exception
            }
        }

        public async Task<int> DeletePaymentTypeAsync(string paymentTypeId)
        {
            try
            {
                return await _paymentTypeDAL.DeletePaymentTypeAsync(paymentTypeId);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error in DeletePaymentTypeAsync: {ex.Message}");
                return -1; // Or throw the exception
            }
        }

        public async Task<List<BML.PaymentType>> GetPaymentTypesAsync()
        {
            try
            {
                return await _paymentTypeDAL.GetPaymentTypesAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error in GetPaymentTypesAsync: {ex.Message}");
                return null; // Or throw the exception
            }
        }
    }
}
