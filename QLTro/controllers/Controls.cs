using QLTro.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.controllers
{
    class Controls
    {
        Database db;
        public Controls()
        {
            db = new Database();
        }
        public void Disconnect()
        {
            db.Disconnect();
        }
    }
}
