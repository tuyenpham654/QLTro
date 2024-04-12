using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataTable LoadComboBoxKhach(string strView)
        {
            return pr.LoadComboBoxKhach(strView);
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
        // Phòng Trọ
        public void PhongTro(int MaPhong, string SoPhong, string ViTri, decimal DienTich, decimal GiaThue, bool TinhTrangThue, bool TrangThai, string LOAI)
        {
            pr.PhongTro("sp_PhongTro", MaPhong, SoPhong, ViTri, DienTich, GiaThue, TinhTrangThue, TrangThai, LOAI);
        }
        //Giá Điện Nước
        public void GiaDienNuoc( int GiaDien, int GiaNuoc, DateTime NgayApDung, bool TrangThai, string LOAI)
        {
            pr.GiaDienNuoc("sp_GiaDienNuoc", GiaDien, GiaNuoc, NgayApDung, TrangThai, LOAI);
        }
        public void Account(int MaTK, string UserName, string Password, string Loai, string LOAI)
        {
            pr.Account("sp_Account", MaTK, UserName, Password, Loai, LOAI);
        }
        //Check Phong Tro
        public void CheckPhongThue(int MaPhong, out bool Result)
        {
            pr.CheckPhongThue("sp_CheckPhongThue", MaPhong, out Result);
        }
        // Hop dong
        public void HopDongThue(int MaHopDong, DateTime NgayBatDau, DateTime NgayKetThuc, int SoLuongNguoi, float PhuThu, bool TrangThai, string LOAI)
        {
            pr.HopDongThue("sp_HopDong", MaHopDong, NgayBatDau, NgayKetThuc, SoLuongNguoi, PhuThu, TrangThai, LOAI);
        }
        // Chi tiet hop dong
        public void ChiTietHopDong(int MaHopDong, int MaNguoiThue, int MaPhong, string LOAI)
        {
            pr.ChiTietHopDong("sp_ChiTietHopDong", MaHopDong, MaNguoiThue, MaPhong, LOAI);
        }



    }
}
