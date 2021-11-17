namespace PayrollSystem.People
{
    class User
    {
        protected string vFirstName, vLastName;

        public string FirstName
        {
            get { return vFirstName; }
            set { vFirstName = value; }
        }

        public string LastName
        {
            get { return vLastName; }
            set { vLastName = value; }
        }
    }
}