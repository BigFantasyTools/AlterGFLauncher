using System;
using System.Windows.Forms;

namespace AlterGFLauncher.Forms
{
    public partial class AddAccountForm : Form
    {
        public string Id { get; set; }

        public string Password { get; set; }

        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Id = idTextBox.Text;
            Password = passwordTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
