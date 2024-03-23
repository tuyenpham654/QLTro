using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.database
{
    class Database
    {
        DataProvider pr = new DataProvider();

        public Database()
        {
            pr.Connect();

        }
        public void Disconnect()
        {
            pr.Disconnect();
        }
    }
}
