using AlterGFLauncher.Forms;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace AlterGFLauncher.Utils
{
    public static class JsonHelper
    {
        private readonly static string CRYPTED_MARK = "==why==";
        private readonly static string DECRYPTED_MARK = "==nhy==";

        public static T Deserialize<T>(string filename)
        {
            if (!File.Exists(filename))
                throw new ArgumentException("Fichier " + filename + "introuvable");

            string fileContent = File.ReadAllText(filename);

            if (IsEncrypted(fileContent))
            {
                fileContent = TryToDecrypt(fileContent);
            }

            JsonTextReader reader = new JsonTextReader(new StringReader(fileContent));
            JsonSerializer serializer = new JsonSerializer();
            return serializer.Deserialize<T>(reader);
        }

        public static void Serialize<T>(T obj, string filename)
        {
            string fileContent = JsonConvert.SerializeObject(obj, Formatting.Indented);
            if (Settings.Encrypted)
                fileContent = CRYPTED_MARK + AES.EncryptString(Settings.EncryptionPass, DECRYPTED_MARK + fileContent);

            File.WriteAllText(filename, fileContent);
        }

        public static T DeserializeFromString<T>(string data)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(data));
            JsonSerializer serializer = new JsonSerializer();
            return serializer.Deserialize<T>(reader);
        }

        public static string SerializeToString<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        private static bool IsEncrypted(string fileContent)
        {
            return fileContent.StartsWith(CRYPTED_MARK);
        }

        private static bool IsDecrypted(string fileContent)
        {
            return fileContent.StartsWith(DECRYPTED_MARK);
        }

        private static string TryToDecrypt(string fileContent)
        {
            if (string.IsNullOrEmpty(Settings.EncryptionPass))
            {
                Settings.Encrypted = true;
                do
                {
                    if (AskForPassword() == DialogResult.OK)
                    {
                        try
                        {
                            fileContent = AES.DecryptString(Settings.EncryptionPass, fileContent.Substring(CRYPTED_MARK.Length));
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                } while (!IsDecrypted(fileContent));

            }
            else
            {
                fileContent = AES.DecryptString(Settings.EncryptionPass, fileContent.Substring(CRYPTED_MARK.Length));
            }

            return fileContent.Substring(DECRYPTED_MARK.Length);
        }

        private static DialogResult AskForPassword()
        {
            PasswordForm passwordForm = new PasswordForm();
            var result = passwordForm.ShowDialog();
            Settings.EncryptionPass = passwordForm.Password;
            return result;
        }
    }
}
