using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AlterGFLauncher.Utils
{
    public class AES
    {
        private static byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private static int BlockSize = 128;

        public static string EncryptString(string key, string plainText)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(plainText);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(key));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] bytes = Convert.FromBase64String(cipherText);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(key));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    return Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }
    }
}