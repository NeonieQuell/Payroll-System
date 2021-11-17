namespace PayrollSystem
{
    class Singleton
    {
        private static FormLogIn _frmLogIn;
        private static FormMainMenu _frmMainMenu;

        public static FormLogIn FrmLogIn
        {
            get
            {
                if (_frmLogIn == null)
                    _frmLogIn = new FormLogIn();
                return _frmLogIn;
            }
        }

        public static FormMainMenu FrmMainMenu
        {
            get
            {
                if (_frmMainMenu == null)
                    _frmMainMenu = new FormMainMenu();
                return _frmMainMenu;
            }
        }
    }
}