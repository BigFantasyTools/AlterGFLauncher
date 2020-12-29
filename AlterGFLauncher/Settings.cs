using AlterGFLauncher.Utils;
using System;
using System.IO;

namespace AlterGFLauncher
{
    public class Settings
    {
        #region Constantes
        private const string SETTINGS_FILE_FILENAME = "settings.json";

        public const string ENCRYPT_PASSWORD_KEY = "setakey";
        #endregion Constantes

        public static string EncryptionPass;

        public static bool Encrypted = false;

        public static string IdClient = "";

        public static int TimeoutBeforeCode = 4000;

        public static string GrandFantasiaExecutablePath = "";

        public static string GrandFantasiaWorkingPath => string.IsNullOrWhiteSpace(GrandFantasiaExecutablePath) ? "" : Path.GetDirectoryName(GrandFantasiaExecutablePath);

        public static string GrandFantasiaExecutable => string.IsNullOrWhiteSpace(GrandFantasiaExecutablePath) ? "" : Path.GetFileName(GrandFantasiaExecutablePath);

        public static void LoadSettings()
        {
            if (IsSettingsFileExist())
            {
                try
                {
                    ImportedSettings settings = JsonHelper.Deserialize<ImportedSettings>(SETTINGS_FILE_FILENAME);
                    IdClient = settings.IdClient;
                    TimeoutBeforeCode = settings.TimeoutBeforeCode;
                    GrandFantasiaExecutablePath = settings.GrandFantasiaExecutablePath;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public static void SaveSettings()
        {
            ImportedSettings setting = new ImportedSettings()
            {
                IdClient = Settings.IdClient,
                GrandFantasiaExecutablePath = Settings.GrandFantasiaExecutablePath,
                TimeoutBeforeCode = Settings.TimeoutBeforeCode
            };

            JsonHelper.Serialize(setting, SETTINGS_FILE_FILENAME);
        }

        private static bool IsSettingsFileExist()
        {
            bool fileExists = File.Exists(SETTINGS_FILE_FILENAME);
            if (!fileExists)
            {
                SaveSettings();
            }
            return fileExists;
        }
    }

    public class ImportedSettings
    {
        public string IdClient;

        public string GrandFantasiaExecutablePath;

        public int TimeoutBeforeCode;
    }
}
