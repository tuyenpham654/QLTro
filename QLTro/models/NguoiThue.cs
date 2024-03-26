using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.models
{
    class NguoiThue
    {
        private string manguoithue;
        private string hoten;
        private Boolean gioitinh;
        private DateTime ngaysinh;
        private string diachi;
        private string email;
        private string dienthoai;
        private Boolean trangthai;

        public NguoiThue()
        {
            
        }

        public string Manguoithue { get => manguoithue; set => manguoithue = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Dienthoai { get => dienthoai; set => dienthoai = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
    }
}
