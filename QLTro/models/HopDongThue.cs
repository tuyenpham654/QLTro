using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    internal class HopDongThue
    {
        private string mahopdong;
        private int manguoithue;
        private int maphong;
        private DateTime ngaybatdau;
        private DateTime ngayketthuc;
        private int soluongnguoi;
        private double phuthu;

        public string Mahopdong { get => mahopdong; set => mahopdong = value; }
        public int Manguoithue { get => manguoithue; set => manguoithue = value; }
        public int Maphong { get => maphong; set => maphong = value; }
        public DateTime Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
        public int Soluongnguoi { get => soluongnguoi; set => soluongnguoi = value; }
        public double Phuthu { get => phuthu; set => phuthu = value; }
    }
}
