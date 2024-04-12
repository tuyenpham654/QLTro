using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class ChiTietHopDong
    {
        private int mahopdong;
        private int manguoithue;
        private int maphong;

        public ChiTietHopDong()
        {

        }

        public int Mahopdong { get => mahopdong; set => mahopdong = value; }
        public int Manguoithue { get => manguoithue; set => manguoithue = value; }
        public int Maphong { get => maphong; set => maphong = value; }
    }
}
