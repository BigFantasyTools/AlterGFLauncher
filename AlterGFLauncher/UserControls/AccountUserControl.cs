using AlterGFLauncher.Forms;
using System;
using System.Windows.Forms;

namespace AlterGFLauncher
{
    public partial class AccountUserControl : UserControl
    {
        private MainForm MainForm { get; set; }

        private GameInstanceManager GameInstanceLauncher { get; set; }

        public Account Account { get; set; }

        public AccountUserControl(Account account, MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            Account = account;

            ButtonDemarrerJeu.Text = Strings.STRING_STARTBUTTON_START;
            GameInstanceLauncher = new GameInstanceManager(Account, UpdateState);
        }

        public void RefreshControl()
        {
            nomDeCompte.Text = Account.Id;
        }

        private void CompteUserControl_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        public void UpdateState(StateGameInstanceEnumeration state, string errorMessage)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateState(state, errorMessage)));
                return;
            }

            switch (state)
            {
                case StateGameInstanceEnumeration.Started:
                    ButtonDemarrerJeu.Text = Strings.STRING_STARTBUTTON_RUNNING;
                    ButtonDemarrerJeu.Enabled = false;
                    break;
                case StateGameInstanceEnumeration.Starting:
                    ButtonDemarrerJeu.Text = Strings.STRING_STARTBUTTON_STARTING;
                    ButtonDemarrerJeu.Enabled = false;
                    break;
                case StateGameInstanceEnumeration.Error:
                    ButtonDemarrerJeu.Text = Strings.STRING_STARTBUTTON_START;
                    ButtonDemarrerJeu.Enabled = true;
                    MessageBox.Show(errorMessage, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case StateGameInstanceEnumeration.Stop:
                    ButtonDemarrerJeu.Text = Strings.STRING_STARTBUTTON_START;
                    ButtonDemarrerJeu.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private bool CanStartGame()
        {
            if (Settings.TimeoutBeforeCode < 4000 || string.IsNullOrWhiteSpace(Settings.GrandFantasiaExecutablePath) || string.IsNullOrWhiteSpace(Settings.IdClient))
            {
                MessageBox.Show("Impossible de lancer le jeu. Vérifiez les options.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #region UI events
        private void ButtonDemarrerJeu_Click(object sender, EventArgs e)
        {
            if (CanStartGame())
                GameInstanceLauncher.StartSession();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            RefreshControl();
            if (MessageBox.Show("Êtes-vous sûr de supprimer le compte " + Account.Id + " ?", "Suppression de compte", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Account.Remove();
                MainForm.RefreshAccountPanel();
                MessageBox.Show("Le compte a été supprimé");
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportAccountForm exportAccountForm = new ExportAccountForm(Account);
            exportAccountForm.ShowDialog();
        }
        #endregion UI events
    }
}
