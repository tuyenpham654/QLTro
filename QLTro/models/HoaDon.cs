using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    internal class HoaDon
    {
        private string mahoadon;
        private string mahopdong;
        private int sodien;
        private int sonuoc;
        private DateTime ngaylap;

        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Mahopdong { get => mahopdong; set => mahopdong = value; }
        public int Sodien { get => sodien; set => sodien = value; }
        public int Sonuoc { get => sonuoc; set => sonuoc = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
    }
}
