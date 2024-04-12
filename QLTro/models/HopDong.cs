using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class HopDong
    {
        private int mahopdong;
        private DateTime ngaybatdau;
        private DateTime ngaykethuc;
        private int slnguoi;
        private float phuthu;
        private Boolean trangthai;

        public HopDong() { 
        
        }

        public int Mahopdong { get => mahopdong; set => mahopdong = value; }
        public DateTime Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime Ngaykethuc { get => ngaykethuc; set => ngaykethuc = value; }
        public int Slnguoi { get => slnguoi; set => slnguoi = value; }
        public float Phuthu { get => phuthu; set => phuthu = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
