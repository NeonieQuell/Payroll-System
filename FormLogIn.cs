using System;
using System.Windows.Forms;
using PayrollSystem.People;

namespace PayrollSystem
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
            Admin.Username = "admin";
            Admin.Password = "admin";
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.TextLength > 0 && textBoxPassword.TextLength > 0)
            {

                if (Admin.VerifyLogIn(textBoxUsername.Text, textBoxPassword.Text))
                {
                    Singleton.FrmMainMenu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect credentials.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your credentials.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}