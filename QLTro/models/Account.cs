using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class Account
    {
        private int MaTK;
        private string username;
        private string password;

        public Account(int maTK, string username, string password)
        {
            MaTK = maTK;
            this.username = username;
            this.password = password;
        }

        public int MaTK1 { get => MaTK; set => MaTK = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
