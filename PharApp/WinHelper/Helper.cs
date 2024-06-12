using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PharApp.WinHelper
{
    public class Helper
    {
        public static bool ValidatePassword(string password)
        {
            // Ensure the password has at least 8 characters
            if (password.Length < 8)
                return false;

            // Ensure the password contains at least one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
                return false;

            // Ensure the password contains at least one lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
                return false;

            // Ensure the password contains at least one digit
            if (!Regex.IsMatch(password, "[0-9]"))
                return false;

            // Ensure the password contains at least one special character
            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
                return false;

            return true;
        }

        public static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{}|;:,.<>?";

            var random = new Random();
            var chars = new char[length];

            // Ensure at least one uppercase letter, one lowercase letter, one digit, and one special character
            chars[0] = validChars[random.Next(26)]; // At least one uppercase letter
            chars[1] = validChars[random.Next(26, 52)]; // At least one lowercase letter
            chars[2] = validChars[random.Next(52, 62)]; // At least one digit
            chars[3] = validChars[random.Next(62, validChars.Length)]; // At least one special character

            // Fill the remaining characters randomly
            for (int i = 4; i < length; i++)
            {
                chars[i] = validChars[random.Next(validChars.Length)];
            }

            // Shuffle the characters array to ensure randomness
            for (int i = length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            return new string(chars);
        }

        public static bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            if (Regex.IsMatch(email, pattern))
            {
                return true; // Valid email
            }
            else
            {
                return false; // Invalid email
            }
        }

        public static string GetConnectionStringFromSettings()
        {
            // Retrieve the connection string from application settings
            string server = Properties.Settings.Default.Server;
            string database = Properties.Settings.Default.Database;
            bool useWindowsAuth = Properties.Settings.Default.UseWindowsAuth == "true";
            string username = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;

            if (useWindowsAuth)
            {
                // If Windows authentication is used
                return $"Data Source={server};Initial Catalog={database};Integrated Security=True;";
            }
            else
            {
                // If SQL Server authentication is used
                return $"Data Source={server};Initial Catalog={database};User ID={username};Password={password};";
            }
        }

        public static string FormatGuid(string guidWithoutDashes)
        {
            if (string.IsNullOrEmpty(guidWithoutDashes) || guidWithoutDashes.Length != 32)
            {
                throw new ArgumentException("The input string must be a valid GUID string without dashes and exactly 32 characters long.");
            }

            return $"{guidWithoutDashes.Substring(0, 8)}-{guidWithoutDashes.Substring(8, 4)}-{guidWithoutDashes.Substring(12, 4)}-{guidWithoutDashes.Substring(16, 4)}-{guidWithoutDashes.Substring(20, 12)}";
        }

        public static async void Log(string log)
        {
            var auditlogBal = new BAL.AuditLog(Helper.GetConnectionStringFromSettings());
            await auditlogBal.CreateAuditLodAsync(log);
        }

        public static string ProcessString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            string lowerCaseString = input.ToLower();

            string result = lowerCaseString.Replace(" ", "");

            return result;
        }
    }
}
