using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class CE_Acceso
    {
        private string _username;
        private string _password;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
