using PayrollSystem.Finance;

namespace PayrollSystem.People
{
    class Employee : User, Income
    {
        protected long vEmpID;
        protected string vDept, vPos;
        protected int vWorkDays;
        protected decimal vRatePerDay, vGrossMonthlyIncome;

        public long EmployeeID
        {
            get { return vEmpID; }
            set { vEmpID = value; }
        }

        public string Department
        {
            get { return vDept; }
            set { vDept = value; }
        }

        public string Position
        {
            get { return vPos; }
            set { vPos = value; }
        }

        public int WorkDays
        {
            get { return vWorkDays; }
            set { vWorkDays = value; }
        }

        public decimal RatePerDay
        {
            get { return vRatePerDay; }
            set { vRatePerDay = value; }
        }

        public decimal GrossMonthlyIncome
        {
            get { return vGrossMonthlyIncome; }
            set { vGrossMonthlyIncome = value; }
        }

        public Employee()
        {
            vEmpID = 0L;
            vFirstName = "No firstname";
            vLastName = "No lastname";
            vDept = "No department";
            vPos = "No position";
            vWorkDays = 0;
            vRatePerDay = 0M;
            vGrossMonthlyIncome = 0M;
        }

        public Employee(long empID, string fname, string lname, string dept, string pos, int workDays, decimal ratePerDay)
        {
            vEmpID = empID;
            vFirstName = fname;
            vLastName = lname;
            vDept = dept;
            vPos = pos;
            vWorkDays = workDays;
            vRatePerDay = ratePerDay;
            ComputeGrossMonthlyIncome();
        }

        public void ComputeGrossMonthlyIncome()
        {
            vGrossMonthlyIncome = vWorkDays * vRatePerDay;
        }

        public void ComputeNetMontlyIncome()
        {
            throw new System.NotImplementedException();
        }
    }
}