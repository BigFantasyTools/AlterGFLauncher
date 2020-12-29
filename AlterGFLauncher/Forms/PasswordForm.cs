using System;
using System.Windows.Forms;

namespace AlterGFLauncher.Forms
{
    public partial class PasswordForm : Form
    {
        public string Password { get; set; }

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateForm();
            }
        }

        private void ValidateForm()
        {
            this.Password = passwordTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
