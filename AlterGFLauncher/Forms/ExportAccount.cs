using System;
using System.Windows.Forms;

namespace AlterGFLauncher.Forms
{
    public partial class ExportAccountForm : Form
    {
        private Account Account;
        public ExportAccountForm(Account account)
        {
            InitializeComponent();
            Account = account;
        }

        private void ExportAccount_Load(object sender, EventArgs e)
        {
            exportedStringRichTextBox.Text = Account.GetImportedString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
