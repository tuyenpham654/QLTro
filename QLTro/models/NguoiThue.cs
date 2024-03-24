using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class NguoiThue
    {
        private string MaNguoiThue;
        private string HoTen;
        private Boolean GioiTinh;
        private DateTime NgaySinh;
        private string DiaChi;
        private string Email;
        private string DienThoai;
        private Boolean TrangThai;

        public NguoiThue()
        {
            
        }

        public string MaNguoiThue1 { get => MaNguoiThue; set => MaNguoiThue = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public bool GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
        public bool TrangThai1 { get => TrangThai; set => TrangThai = value; }
    }
}
