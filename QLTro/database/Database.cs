using System;
using QLTro.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        //đăng nhập
        public bool Login(string username, string password)
        {
            return pr.Login("sp_login", username, password);
        }
        public DataTable LoadDataTable(string strView)
        {
            return pr.LoadDataTable(strView);
        }
        // Xoá
        public void Delete(string tenbang, string ID)
        {
            pr.Delete("sp_Delete", tenbang, ID);
        }
        // Tìm kiếm
        public DataTable Search(string ten, string key)
        {
            return pr.Search("sp_search", ten, key);
        }
        // Người Thuê
        public void NguoiThue(int MaNguoiThue, string HoTen, bool GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string Email, bool TrangThai, string LOAI)
        {
            pr.NguoiThue("sp_NguoiThue", MaNguoiThue, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, Email,TrangThai, LOAI);
        }
        public void Account(int MaTK, string UserName,string Password, string Loai,string LOAI)
        {
            pr.Account("sp_Account", MaTK,UserName,Password,Loai,LOAI);
        }

    }
}
