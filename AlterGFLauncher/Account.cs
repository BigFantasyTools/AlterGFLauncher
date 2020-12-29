using AlterGFLauncher.Utils;
using Newtonsoft.Json;
using System;
using System.Text;

namespace AlterGFLauncher
{
    public class Account
    {
        /// <summary>
        /// Account's id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Crypted account's password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Account password's
        /// </summary>
        [JsonIgnore]
        public string UncryptedPassword
        {
            get
            {
                return AES.DecryptString(Settings.ENCRYPT_PASSWORD_KEY, Password);
            }
        }

        [JsonIgnore]
        public Action<Account> RemoveAccount { get; set; }

        public Account() { }

        public string GetImportedString()
        {
            byte[] data = Encoding.ASCII.GetBytes(JsonHelper.SerializeToString(this));
            return Convert.ToBase64String(data);
        }

        public void Remove()
        {
            RemoveAccount(this);
        }
    }

}
