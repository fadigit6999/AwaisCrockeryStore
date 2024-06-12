using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PharApp.WinHelper
{
    public class PasswordHashEncryption
    {
        public static async Task<string>  EncryptPasswordHash(string passwordHash)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] key;
                byte[] iv;

                var authDal = new BAL.AuthenticationKey(Helper.GetConnectionStringFromSettings());
                var keysAndIVs = await authDal.GetKeysAndIVsAsync();
                key = Convert.FromBase64String(keysAndIVs.Key);
                iv = Convert.FromBase64String(keysAndIVs.Iv);
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(passwordHash);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static async Task<string> DecryptPasswordHash(string encryptedPasswordHash)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedPasswordHash);

            using (Aes aesAlg = Aes.Create())
            {
                byte[] key;
                byte[] iv;

                var authDal = new BAL.AuthenticationKey(Helper.GetConnectionStringFromSettings());
                var keysAndIVs = await authDal.GetKeysAndIVsAsync();
                key = Convert.FromBase64String(keysAndIVs.Key);
                iv = Convert.FromBase64String(keysAndIVs.Iv);
                aesAlg.Key = key;
                aesAlg.IV = iv;


                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static byte[] GenerateKey()
        {
            using (var aes = Aes.Create())
            {
                aes.GenerateKey();
                return aes.Key;
            }
        }

        public static byte[] GenerateIV()
        {
            using (var aes = Aes.Create())
            {
                aes.GenerateIV();
                return aes.IV;
            }
        }
    }
}
