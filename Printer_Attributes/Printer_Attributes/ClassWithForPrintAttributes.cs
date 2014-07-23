using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_Attributes
{
    class ClassWithForPrintAttributes
    {
        private string _login;

        [ForPrint(ConsoleColor.DarkYellow)]
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public ClassWithForPrintAttributes(string login, string password)
        {
            this._login = login;
            this._password = password;
        }
    }
}
