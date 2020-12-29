using AlterGFLauncher.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace AlterGFLauncher
{
    public class AccountManager
    {
        private const string ACCOUNTS_FILE_FILENAME = "accounts.json";

        public List<Account> Accounts { get; private set; }

        public AccountManager()
        {
            Accounts = new List<Account>();
            LoadAccounts();
        }

        public void LoadAccounts()
        {
            try
            {
                if (IsAccountsFileExist())
                {
                    Accounts = JsonHelper.Deserialize<List<Account>>(ACCOUNTS_FILE_FILENAME);
                    Accounts.ForEach(x => x.RemoveAccount = RemoveAccount);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SaveAccounts()
        {
            JsonHelper.Serialize(Accounts, ACCOUNTS_FILE_FILENAME);
        }

        public void AddAccount(string id, string password)
        {
            Accounts.Add(new Account()
            {
                Id = id,
                Password = AES.EncryptString(Settings.ENCRYPT_PASSWORD_KEY, password),
                RemoveAccount = RemoveAccount
            });
            SaveAccounts();
        }

        public void ImportAccount(string dataAccount)
        {
            try
            {
                string data = System.Text.Encoding.Default.GetString(Convert.FromBase64String(dataAccount));
                Account account = JsonHelper.DeserializeFromString<Account>(data);
                account.RemoveAccount = RemoveAccount;

                Accounts.Add(account);
                SaveAccounts();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
            SaveAccounts();
        }

        public void EditAccount(Account account, string id, string password)
        {
            account.Id = id;
            account.Password = AES.EncryptString(Settings.ENCRYPT_PASSWORD_KEY, password);
            SaveAccounts();
        }

        private bool IsAccountsFileExist()
        {
            bool fileExists = File.Exists(ACCOUNTS_FILE_FILENAME);
            if (!fileExists)
            {
                SaveAccounts();
            }
            return fileExists;
        }
    }
}
