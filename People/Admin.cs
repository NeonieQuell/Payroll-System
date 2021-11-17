namespace PayrollSystem.People
{
    sealed class Admin
    {
        private static string s_username, s_password;

        public static string Username
        {
            get { return s_username; }
            set { s_username = value; }
        }

        public static string Password
        {
            get { return s_password; }
            set { s_password = value; }
        }

        public static bool VerifyLogIn(string username, string password)
        {
            if (s_username.Equals(username) && s_password.Equals(password))
                return true;
            else
                return false;
        }
    }
}