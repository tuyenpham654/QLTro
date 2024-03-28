using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class GiaDienNuoc
    {
        private int giadien;
        private int gianuoc;
        private DateTime ngayapdung;
        private Boolean trangthai;

        public GiaDienNuoc()
        {
            
        }

        public int Giadien { get => giadien; set => giadien = value; }
        public int Gianuoc { get => gianuoc; set => gianuoc = value; }
        public DateTime Ngayapdung { get => ngayapdung; set => ngayapdung = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
