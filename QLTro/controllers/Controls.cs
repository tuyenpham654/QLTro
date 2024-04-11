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
        public DataTable LoadDataTableHOP(string strView)
        {
            return db.LoadDataTableHOP(strView);
        }
        // loaddata Hóa đơn
        public DataTable LoadDataTableHD(string strView)
        {
            return db.LoadDataTableHD(strView);
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
        public void NguoiThue(int MaNguoiThue, string HoTen, bool GioiTinh, DateTime NgaySinh, string Email, string DienThoai, string DiaChi, bool TrangThai, string LOAI)
        {
            db.NguoiThue( MaNguoiThue, HoTen, GioiTinh, NgaySinh, Email, DienThoai, DiaChi, TrangThai, LOAI);
        }
        // Hợp đồng
        public void HopDong(int MaHopDong, int MaNguoiThue,int MaPhong, DateTime NgayBatDau, DateTime NgayKetThuc,int SoLuongNguoi, double PhuThu, string LOAI)
        {
            db.HopDong(MaHopDong, MaNguoiThue, MaPhong, NgayBatDau, NgayKetThuc, SoLuongNguoi, PhuThu, LOAI);
        }
        // Hóa đơn
        public void HoaDon(int MaHoaDon, int MaHopDong, int SoDien, int SoNuoc, DateTime NgayLap, string LOAI)
        {
            db.HoaDon(MaHoaDon, MaHopDong, SoDien, SoNuoc, NgayLap, LOAI);
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
