using System;
using System.Windows.Forms;
using PayrollSystem.Finance;

namespace PayrollSystem
{
    public partial class FormGeneratePayroll : Form, Income
    {
        public static BindingSource @BindingSource = new BindingSource();

        public FormGeneratePayroll()
        {
            InitializeComponent();

            dataGridViewEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmp.DataSource = BindingSource;
        }

        private void FormGeneratePayroll_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Singleton.FrmMainMenu.Show();
            Dispose();
        }

        private void dataGridViewEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewEmp.Rows[e.RowIndex];

                textBoxEmpID.Text = row.Cells[0].Value.ToString();
                textBoxFName.Text = row.Cells[6].Value.ToString();
                textBoxLName.Text = row.Cells[7].Value.ToString();
                textBoxDepartment.Text = row.Cells[1].Value.ToString();
                textBoxPosition.Text = row.Cells[2].Value.ToString();
                textBoxHoursWork.Text = row.Cells[3].Value.ToString();
                textBoxRatePerDay.Text = row.Cells[4].Value.ToString();
                textBoxGrossMonthlyIncome.Text = row.Cells[5].Value.ToString();

                buttonCalcNetIncome.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a valid row.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalcNetIncome_Click(object sender, EventArgs e)
        {
            if (textBoxTax.TextLength > 0 && textBoxSSS.TextLength > 0)
            {
                try
                {
                    ComputeNetMontlyIncome();
                    MessageBox.Show("Net income calculated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException exception)
                {
                    MessageBox.Show($"{exception.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please complete the fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ComputeGrossMonthlyIncome()
        {
            throw new NotImplementedException();
        }

        public void ComputeNetMontlyIncome()
        {
            decimal tax = Convert.ToDecimal(textBoxTax.Text);
            decimal sss = Convert.ToDecimal(textBoxSSS.Text);
            decimal deductions = tax + sss;

            int OTPay = 0;
            if (textBoxNumOTHours.TextLength > 0)
                OTPay = (Convert.ToInt32(textBoxRatePerDay.Text) / 8) * Convert.ToInt32(textBoxNumOTHours.Text);

            decimal netMIncome = (Convert.ToDecimal(textBoxGrossMonthlyIncome.Text) + OTPay) - deductions;

            if (netMIncome < 0)
                netMIncome = 0;

            labelNetIncome.Text = $"₱{netMIncome}";
        }
    }
}