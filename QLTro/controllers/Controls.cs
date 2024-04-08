using QLTro.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        // Common
        public bool Login(string username, string password)
        {
            return db.Login(username, password);
        }
        public DataTable LoadDataTable(string strView)
        {
            return db.LoadDataTable(strView);
        }
        public DataTable LoadComboBoxKhach(string strView)
        {
            return db.LoadComboBoxKhach(strView);
        }
        public void Delete(string tenbang, string ma)
        {
            db.Delete(tenbang, ma);
        }
        public DataTable Search(string ten, string key)
        {
            return db.Search(ten, key);
        }
        
        // Người Thuê
        public void NguoiThue(int MaNguoiThue, string HoTen, bool GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string Email, bool TrangThai, string LOAI)
        {
            db.NguoiThue( MaNguoiThue, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, Email, TrangThai, LOAI);
        }
        
        //Phòng Trọ
        public void PhongTro(int MaPhong, string SoPhong, string ViTri, decimal DienTich, decimal GiaThue, bool TinhTrangThue, bool TrangThai, string LOAI)
        {
            db.PhongTro( MaPhong, SoPhong, ViTri, DienTich, GiaThue, TinhTrangThue, TrangThai, LOAI);
        }

        //Giá Điện Nước
        public void GiaDienNuoc(int GiaDien, int GiaNuoc, DateTime NgayApDung, bool TrangThai, string LOAI)
        {
            db.GiaDienNuoc( GiaDien, GiaNuoc, NgayApDung, TrangThai, LOAI);
        }
        //Account
        public void Account(int MaTK, string UserName, string Password,  string Loai, string LOAI)
        {
            db.Account(MaTK, UserName, Password, Loai, LOAI);
        }


    }
}
