using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Medicine
    {
        private readonly string _connectionString;

        public Medicine(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> CreateMedicineAsync(string barcode, string name, string strength, string genericName, string boxSize, string unit, string medicineShelf, string details, string medicineTypeId, string image, string categoryId, decimal sellPrice, string manufacturerId, decimal manufacturerPrice,string nameUrdu)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageMedicine", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Create");
                command.Parameters.AddWithValue("@Barcode", barcode);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Strength", strength);
                command.Parameters.AddWithValue("@GenericName", genericName);
                command.Parameters.AddWithValue("@BoxSize", boxSize);
                command.Parameters.AddWithValue("@Unit", unit);
                command.Parameters.AddWithValue("@MedicineShelf", medicineShelf);
                command.Parameters.AddWithValue("@Details", details);
                command.Parameters.AddWithValue("@MedicineTypeId", medicineTypeId);
                command.Parameters.AddWithValue("@Image", image);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@SellPrice", sellPrice);
                command.Parameters.AddWithValue("@ManufacturerId", manufacturerId);
                command.Parameters.AddWithValue("@ManufacturerPrice", manufacturerPrice);
                command.Parameters.AddWithValue("@Name_Urdu", nameUrdu);


                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> UpdateMedicineAsync(string medicineId, string barcode, string name, string strength, string genericName, string boxSize, string unit, string medicineShelf, string details, string medicineTypeId, string image, string categoryId, decimal sellPrice, string manufacturerId, decimal manufacturerPrice)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageMedicine", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Update");
                command.Parameters.AddWithValue("@MedicineId", medicineId);
                command.Parameters.AddWithValue("@Barcode", barcode);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Strength", strength);
                command.Parameters.AddWithValue("@GenericName", genericName);
                command.Parameters.AddWithValue("@BoxSize", boxSize);
                command.Parameters.AddWithValue("@Unit", unit);
                command.Parameters.AddWithValue("@MedicineShelf", medicineShelf);
                command.Parameters.AddWithValue("@Details", details);
                command.Parameters.AddWithValue("@MedicineTypeId", medicineTypeId);
                command.Parameters.AddWithValue("@Image", image);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@SellPrice", sellPrice);
                command.Parameters.AddWithValue("@ManufacturerId", manufacturerId);
                command.Parameters.AddWithValue("@ManufacturerPrice", manufacturerPrice);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<int> DeleteMedicineAsync(string medicineId)
        {
            int result = 0;

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageMedicine", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "Delete");
                command.Parameters.AddWithValue("@MedicineId", medicineId);

                await connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }

            return result;
        }

        public async Task<BML.Medicine> GetMedicinesAsync(string guid)
        {
            BML.Medicine medicines = new BML.Medicine();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("ManageMedicine", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Operation", "ReadUpdate");
                command.Parameters.AddWithValue("@MedicineId",guid);

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        BML.Medicine medicine = new BML.Medicine
                        {
                            MedicineId = reader["MedicineId"].ToString(),
                            Barcode = reader["Barcode"].ToString(),
                            Name = reader["Name"].ToString(),
                            Strength = reader["Strength"].ToString(),
                            GenericName = reader["GenericName"].ToString(),
                            BoxSize = reader["BoxSizes"].ToString(),
                            Unit = reader["Unit"].ToString(),
                            MedicineShelf = reader["MedicineShelf"].ToString(),
                            Details = reader["Details"].ToString(),
                            MedicineTypeId = reader["MedicineTypeId"].ToString(),
                            Image = reader["Image"].ToString(),
                            CategoryId = reader["CategoryId"].ToString(),
                            SellPrice = Convert.ToDecimal(reader["SellPrice"]),
                            ManufacturerId = reader["ManufacturerId"].ToString(),
                            ManufacturerPrice = Convert.ToDecimal(reader["ManufacturerPrice"])
                        };
                        medicines = medicine;
                    }
                }
            }

            return medicines;
        }

        public async Task<List<BML.Medicine>> GetMedicinesGroupAsync()
        {
            List<BML.Medicine> medicines = new List<BML.Medicine>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("ManageMedicine", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Operation", SqlDbType.VarChar).Value = "Read";

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            BML.Medicine medicine = new BML.Medicine
                            {
                                MedicineId = reader["MedicineId"].ToString(),
                                Barcode = reader["Barcode"].ToString(),
                                Name = reader["Name"].ToString(),
                                Strength = reader["Strength"].ToString(),
                                GenericName = reader["GenericName"].ToString(),
                                BoxSize = reader["BoxSizes"].ToString(),
                                Unit = reader["UnitName"].ToString(),
                                MedicineShelf = reader["MedicineShelf"].ToString(),
                                Details = reader["Details"].ToString(),
                                MedicineTypeId = reader["TypeName"].ToString(),
                                Image = reader["Image"].ToString(),
                                CategoryId = reader["CategoryName"].ToString(),
                                SellPrice = Convert.ToDecimal(reader["SellPrice"]),
                                ManufacturerId = reader["ManufacturerName"].ToString(),
                                ManufacturerPrice = Convert.ToDecimal(reader["ManufacturerPrice"])
                            };
                            medicines.Add(medicine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return medicines;
        }
        public async Task<List<BML.Medicine>> GetDropdownAsync()
        {
            List<BML.Medicine> medicines = new List<BML.Medicine>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("ManageMedicine", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Operation", SqlDbType.VarChar).Value = "ReadDropdown";

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            BML.Medicine medicine = new BML.Medicine
                            {
                                MedicineId = reader["MedicineId"].ToString(),
                                Barcode = reader["Barcode"].ToString(),
                                Name = reader["Name"].ToString(),
                                Strength = reader["Strength"].ToString(),
                                GenericName = reader["GenericName"].ToString(),
                                BoxSize = reader["BoxSizes"].ToString(),
                                Unit = reader["UnitName"].ToString(),
                                MedicineShelf = reader["MedicineShelf"].ToString(),
                                Details = reader["Details"].ToString(),
                                MedicineTypeId = reader["TypeName"].ToString(),
                                Image = reader["Image"].ToString(),
                                CategoryId = reader["CategoryName"].ToString(),
                                SellPrice = Convert.ToDecimal(reader["SellPrice"]),
                                ManufacturerId = reader["ManufacturerId"].ToString(),
                                ManufacturerPrice = Convert.ToDecimal(reader["ManufacturerPrice"])
                            };
                            medicines.Add(medicine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return medicines;
        }
        public async Task<List<BML.Medicine>> GetDropdownSaleDropdownAsync()
        {
            List<BML.Medicine> medicines = new List<BML.Medicine>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("ManageMedicine", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Operation", SqlDbType.VarChar).Value = "ReadDropdownSale";

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            BML.Medicine medicine = new BML.Medicine
                            {
                                MedicineId = reader["MedicineId"].ToString(),
                                Barcode = reader["Barcode"].ToString(),
                                Name = reader["Name"].ToString(),
                                Strength = reader["Strength"].ToString(),
                                GenericName = reader["GenericName"].ToString(),
                                BoxSize = reader["BoxSizes"].ToString(),
                                Unit = reader["UnitName"].ToString(),
                                MedicineShelf = reader["MedicineShelf"].ToString(),
                                Details = reader["Details"].ToString(),
                                MedicineTypeId = reader["TypeName"].ToString(),
                                Image = reader["Image"].ToString(),
                                CategoryId = reader["CategoryName"].ToString(),
                                SellPrice = Convert.ToDecimal(reader["SellPrice"]),
                                ManufacturerId = reader["ManufacturerId"].ToString(),
                                ManufacturerPrice = Convert.ToDecimal(reader["ManufacturerPrice"])
                            };
                            medicines.Add(medicine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return medicines;
        }
    }
}
