using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonGeneratePay_Click(object sender, System.EventArgs e)
        {
            new FormGeneratePayroll().Show();
            Hide();
        }

        private void buttonAddEmp_Click(object sender, System.EventArgs e)
        {
            new FormNewEmployee().Show();
            Hide();
        }

        private void buttonAdminInfo_Click(object sender, System.EventArgs e)
        {
            new FormAdminInfo().Show();
            Hide();
        }

        private void buttonLogOut_Click(object sender, System.EventArgs e)
        {
            Singleton.FrmLogIn.Show();
            Hide();
        }
    }
}