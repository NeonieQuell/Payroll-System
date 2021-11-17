using System;
using System.Windows.Forms;
using PayrollSystem.People;

namespace PayrollSystem
{
    public partial class FormAdminInfo : Form
    {
        public FormAdminInfo()
        {
            InitializeComponent();
            textBoxUsername.Text = Admin.Username;
            textBoxPassword.Text = Admin.Password;
        }

        private void FormAdminInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credentials updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Admin.Username = textBoxUsername.Text;
            Admin.Password = textBoxPassword.Text;
            Singleton.FrmLogIn.Show();
            Dispose();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Singleton.FrmMainMenu.Show();
            Dispose();
        }
    }
}