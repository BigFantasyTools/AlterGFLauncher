using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AlterGFLauncher.Forms
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            timeoutBeforeCodeLabelNumeric.Value = Settings.TimeoutBeforeCode;
            ExeGFTextBox.Text = Settings.GrandFantasiaExecutablePath;
            idClientTextBox.Text = Settings.IdClient;
            encryptionCheckBox.Checked = Settings.Encrypted;
            encryptionPasswordTextBox.Text = Settings.EncryptionPass;
            encryptionPasswordTextBox.Enabled = Settings.Encrypted;
        }

        private void saveOptionsButton_Click(object sender, EventArgs e)
        {
            string invalidOptions = CheckOptions();
            if (!string.IsNullOrEmpty(invalidOptions))
            {
                MessageBox.Show(invalidOptions, "Paramètre(s) invalide(s)");
                return;
            }

            Settings.TimeoutBeforeCode = (int)timeoutBeforeCodeLabelNumeric.Value;
            Settings.GrandFantasiaExecutablePath = ExeGFTextBox.Text;
            Settings.IdClient = idClientTextBox.Text;
            Settings.Encrypted = encryptionCheckBox.Checked;
            Settings.EncryptionPass = encryptionPasswordTextBox.Text;
            Settings.Encrypted = encryptionPasswordTextBox.Enabled;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void browseExeGFButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Directory.Exists(Settings.GrandFantasiaWorkingPath) ? Settings.GrandFantasiaWorkingPath : "";
            openFileDialog.FileName = File.Exists(Settings.GrandFantasiaExecutablePath) ? Settings.GrandFantasiaExecutablePath : "";
            openFileDialog.Filter = "Exécutable (*.exe)|*.exe";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ExeGFTextBox.Text = openFileDialog.FileName;
            }
        }

        private void encryptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            encryptionPasswordTextBox.Enabled = encryptionCheckBox.Checked;
        }

        private string CheckOptions()
        {
            string invalidOptions = string.Empty;
            if (string.IsNullOrEmpty(ExeGFTextBox.Text))
                invalidOptions += Strings.STRING_EXEGF_INVALID_OPTIONS + "\n";

            if (string.IsNullOrEmpty(idClientTextBox.Text))
                invalidOptions += Strings.STRING_IDCLIENT_INVALID_OPTIONS + "\n";

            if (timeoutBeforeCodeLabelNumeric.Value < 1000)
                invalidOptions += Strings.STRING_TIMEOUTBEFORECODE_INVALID_OPTIONS + "\n";

            if (encryptionCheckBox.Checked && string.IsNullOrEmpty(idClientTextBox.Text))
                invalidOptions += Strings.STRING_PASSWORD_INVALID_OPTIONS + "\n";

            return invalidOptions;
        }

        private void gitLinkLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(gitLinkLinkLabel.Text);
        }
    }
}
