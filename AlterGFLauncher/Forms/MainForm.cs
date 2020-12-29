using System;
using System.Windows.Forms;

namespace AlterGFLauncher.Forms
{
    public partial class MainForm : Form
    {
        private AccountUserControlManager AccountUserControlManager;

        private AccountManager AccountManager;

        public static MainForm MainFormInstance;

        public MainForm()
        {
            InitializeComponent();
            MainFormInstance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Settings.LoadSettings();
            }
            catch (Exception)
            {
                if (DialogResult.Yes == MessageBox.Show(Strings.ERROR_INVALIDE_SETTINGS_FILE, "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    Settings.SaveSettings();
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            try
            {
                AccountManager = new AccountManager();
                AccountManager.LoadAccounts();
            }
            catch (Exception)
            {
                if (DialogResult.Yes == MessageBox.Show(Strings.ERROR_INVALIDE_ACCOUNTS_FILE, "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    AccountManager = new AccountManager();
                    AccountManager.SaveAccounts();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            AccountUserControlManager = new AccountUserControlManager(AccountManager.Accounts, this);
            RefreshAccountPanel();
        }

        public void RefreshAccountPanel()
        {
            AccountUserControlManager.UpdateAccountUserControl(AccountManager.Accounts);
            accountControlFlowLayoutPanel.Controls.Clear();
            accountControlFlowLayoutPanel.Controls.AddRange(AccountUserControlManager.AccountUserControls.ToArray());
        }

        #region UI events
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            if (optionsForm.ShowDialog() == DialogResult.OK)
            {
                Settings.SaveSettings();
                AccountManager.SaveAccounts();
                MessageBox.Show(Strings.SUCCESS_SAVED_SETTINGS);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountFormForm = new AddAccountForm();
            DialogResult result = addAccountFormForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                AccountManager.AddAccount(addAccountFormForm.Id, addAccountFormForm.Password);
                RefreshAccountPanel();
                MessageBox.Show(Strings.SUCCES_ADDED_ACCOUNT);
            }
        }

        private void importerUnCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportAccountForm importAccountForm = new ImportAccountForm();
            if (importAccountForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AccountManager.ImportAccount(importAccountForm.ImportedString);
                    RefreshAccountPanel();
                    MessageBox.Show(Strings.SUCCES_ADDED_ACCOUNT);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion UI events
    }
}
