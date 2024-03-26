using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class PhongTro
    {
        private string maphong;
        private string sophong;
        private string vitri;
        private decimal dientich;
        private decimal giathue;
        private Boolean tinhtrangthue;
        private Boolean trangthai;

        public PhongTro()
        {
         
        }

        public string Maphong { get => maphong; set => maphong = value; }
        public string Sophong { get => sophong; set => sophong = value; }
        public string Vitri { get => vitri; set => vitri = value; }
        public decimal Dientich { get => dientich; set => dientich = value; }
        public decimal Giathue { get => giathue; set => giathue = value; }
        public bool Tinhtrangthue { get => tinhtrangthue; set => tinhtrangthue = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
