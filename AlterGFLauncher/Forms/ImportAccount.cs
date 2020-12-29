using System;
using System.Windows.Forms;

namespace AlterGFLauncher.Forms
{
    public partial class ImportAccountForm : Form
    {

        public string ImportedString { get; set; }

        public ImportAccountForm()
        {
            InitializeComponent();
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void exportedStringRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ImportedString = importedStringRichTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ImportAccount_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
