using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class Account
    {
        private string matk;
        private string username;
        private string password;
        private string loai;

        public Account()
        {
           
        }

        public string Matk { get => matk; set => matk = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
