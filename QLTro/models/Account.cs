using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class Account
    {
        private string MaTK;
        private string username;
        private string password;
        private string loai;

        public Account()
        {
        }

        public Account(string maTK, string username, string password, string loai)
        {
            MaTK = maTK;
            this.username = username;
            this.password = password;
            this.loai = loai;
        }

        public string MaTK1 { get => MaTK; set => MaTK = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
