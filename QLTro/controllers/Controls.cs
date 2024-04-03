using QLTro.database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public bool Login(string username, string password)
        {
            return db.Login(username, password);
        }
        public DataTable LoadDataTable(string strView)
        {
            return db.LoadDataTable(strView);
        }
        public void Delete(string tenbang, string ma)
        {
            db.Delete(tenbang, ma);
        }
        // Người Thuê
        public void NguoiThue(int MaNguoiThue, string HoTen, bool GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string Email, bool TrangThai, string LOAI)
        {
            db.NguoiThue( MaNguoiThue, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, Email, TrangThai, LOAI);
        }
        public DataTable Search(string ten, string key)
        {
            return db.Search(ten, key);
        }
        public void Account(int MaTK, string UserName, string Password, string Loai, string LOAI)
        {
            db.Account(MaTK, UserName, Password, Loai, LOAI);
        }

    }
}
