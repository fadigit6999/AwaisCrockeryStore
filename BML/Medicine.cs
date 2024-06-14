using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Medicine
    {
        public string? MedicineId { get; set; }
        public string? Barcode { get; set; }
        public string? Name { get; set; }
        public string? Name_Urdu { get; set; }
        public string? Strength { get; set; }
        public string? GenericName { get; set; }
        public string? BoxSize { get; set; }
        public string? Unit { get; set; }
        public string? MedicineShelf { get; set; }
        public string? Details { get; set; }
        public string? MedicineTypeId { get; set; }
        public string? Image { get; set; }
        public string? CategoryId { get; set; }
        public decimal? SellPrice { get; set; }
        public string? ManufacturerId { get; set; }
        public decimal? ManufacturerPrice { get; set; }
    }
}
