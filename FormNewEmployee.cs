using System;
using System.Windows.Forms;
using PayrollSystem.People;

namespace PayrollSystem
{
    public partial class FormNewEmployee : Form
    {
        private Employee _emp;

        public FormNewEmployee()
        {
            InitializeComponent();

            string[] dept = { "Strategy", "Marketing", "Finance", "HR", "IT", "Operations" };
            comboBoxDepartment.Items.AddRange(dept);
        }

        private void FormSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool checkFormContent = textBoxEmpID.TextLength > 0 &&
                                    textBoxFName.TextLength > 0 &&
                                    textBoxLName.TextLength > 0 &&
                                    comboBoxDepartment.SelectedIndex >= 0 &&
                                    textBoxPosition.TextLength > 0 &&
                                    textBoxWorkDays.TextLength > 0 &&
                                    textBoxRatePerDay.TextLength > 0;

            try
            {
                if (checkFormContent)
                {
                    _emp = new Employee(Convert.ToInt64(textBoxEmpID.Text),
                                        textBoxFName.Text,
                                        textBoxLName.Text,
                                        comboBoxDepartment.SelectedItem.ToString(),
                                        textBoxPosition.Text,
                                        Convert.ToInt32(textBoxWorkDays.Text),
                                        Convert.ToDecimal(textBoxRatePerDay.Text));

                    MessageBox.Show("Employee added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _emp = new Employee();

                    if (textBoxEmpID.TextLength > 0)
                        _emp.EmployeeID = Convert.ToInt64(textBoxEmpID.Text);

                    if (textBoxFName.TextLength > 0)
                        _emp.FirstName = textBoxFName.Text;

                    if (textBoxLName.TextLength > 0)
                        _emp.LastName = textBoxLName.Text;

                    if (comboBoxDepartment.SelectedIndex >= 0)
                        _emp.Department = comboBoxDepartment.SelectedItem.ToString();

                    if (textBoxPosition.TextLength > 0)
                        _emp.Position = textBoxPosition.Text;

                    if (textBoxWorkDays.TextLength > 0)
                        _emp.WorkDays = Convert.ToInt32(textBoxWorkDays.Text);

                    if (textBoxRatePerDay.TextLength > 0)
                        _emp.RatePerDay = Convert.ToDecimal(textBoxRatePerDay.Text);

                    _emp.GrossMonthlyIncome = _emp.WorkDays * _emp.RatePerDay;

                    MessageBox.Show("Employee added with some information missing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                FormGeneratePayroll.BindingSource.Add(_emp);
                Singleton.FrmMainMenu.Show();
                Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Singleton.FrmMainMenu.Show();
            Dispose();
        }
    }
}