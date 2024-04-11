using System;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTro.database
{
    class DataProvider
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        string connectionString = ConfigurationManager.ConnectionStrings["MKN"].ConnectionString;

        public DataProvider()
        {
            con = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                con.Open();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }

        public void Disconnect()
        {
            con.Close();
        }

        // Common
        public bool Login(string strStore, string username, string password) //strStore = tên store Procedu truyền vào
        {

            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public DataTable LoadDataTable(string strView)
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * FROM " + strView;
            using (SqlCommand cmd = new SqlCommand(strQuery, con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                {
                    dap.Fill(dt);
                }
            }
            return dt;
        }
        public DataTable LoadDataTableHOP(string strView)
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT [Mã Hợp Đồng], [Họ Tên], [Số Phòng], SĐT,[Số Lượng Người], [Ngày Bắt Đầu], [Ngày Kết Thúc], [Phụ Thu], [Trạng Thái] FROM " + strView;
            using (SqlCommand cmd = new SqlCommand(strQuery, con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                {
                    dap.Fill(dt);
                }
            }
            return dt;
        }
        // hóa đơn
        public DataTable LoadDataTableHD(string strView)
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT [Mã Hóa Đơn], [Mã Hợp Đồng],[Số Điện],[Số Nước], [Số Phòng],[Họ Tên],SĐT,Email,[Tổng Tiền], [Ngày Lập] FROM " + strView;
            using (SqlCommand cmd = new SqlCommand(strQuery, con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                {
                    dap.Fill(dt);
                }
            }
            return dt;
        }

        public void Delete(string strStore, string tenbang, string ID)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = tenbang;
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;
            cmd.ExecuteNonQuery();
        }

        public DataTable Search(string strStore, string ten, string key)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (key)
            {
                case "HOTEN_NGUOITHUE":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "HOTEN_NGUOITHUE";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "SOPHONG_PHONGTRO":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "SOPHONG_PHONGTRO";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TIMKIIEM_PHONGTRO":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "TIMKIIEM_PHONGTRO";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "DT_PHONGTRO":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "DT_PHONGTRO";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TIMKIIEM_KHACH":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "TIMKIIEM_KHACH";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "DT_KHACH":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "DT_KHACH";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TIMKIEM_HOADON":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "TIMKIEM_HOADON";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TIMKIEM_HOPDONG":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "TIMKIEM_HOPDONG";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TIMKIEM_LSHOADON":
                    cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = "TIMKIEM_LSHOADON";
                    cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
                    break;


            }
            dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
       

        // Người Thuê
        public void NguoiThue(string strStore, int MaNguoiThue, string HoTen, bool GioiTinh, DateTime NgaySinh, string DiaChi, string DienThoai, string Email, bool TrangThai, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("@Store", "INSERT");
                    cmd.Parameters.AddWithValue("@MaNguoiThue", MaNguoiThue);
                    cmd.Parameters.AddWithValue("@HoTen", HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                    cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("@Store", "UPDATE");
                    cmd.Parameters.AddWithValue("@MaNguoiThue", MaNguoiThue);
                    cmd.Parameters.AddWithValue("@HoTen", HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                    cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        public void HopDong(string strStore, int MaHopDong, int MaNguoiThue, int MaPhong, DateTime NgayBatDau, DateTime NgayKetThuc, int SoLuongNguoi, double PhuThu, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("@Store", "INSERT");
                    cmd.Parameters.AddWithValue("@mahopdong", MaHopDong);
                    cmd.Parameters.AddWithValue("@manguoithue", MaNguoiThue);
                    cmd.Parameters.AddWithValue("@maphong", MaPhong);
                    cmd.Parameters.AddWithValue("@ngaybatdau", NgayBatDau);
                    cmd.Parameters.AddWithValue("@ngayketthuc", NgayKetThuc);
                    cmd.Parameters.AddWithValue("@soluongnguoi", SoLuongNguoi);
                    cmd.Parameters.AddWithValue("@phuthu", PhuThu);
                  
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("@Store", "UPDATE");
                    cmd.Parameters.AddWithValue("@mahopdong", MaHopDong);
                    cmd.Parameters.AddWithValue("@manguoithue", MaNguoiThue);
                    cmd.Parameters.AddWithValue("@maphong", MaPhong);
                    cmd.Parameters.AddWithValue("@ngaybatdau", NgayBatDau);
                    cmd.Parameters.AddWithValue("@ngayketthuc", NgayKetThuc);
                    cmd.Parameters.AddWithValue("@soluongnguoi", SoLuongNguoi);
                    cmd.Parameters.AddWithValue("@phuthu", PhuThu);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        public void HoaDon(string strStore, int MaHoaDon, int MaHopDong, int SoDien, int SoNuoc, DateTime NgayLap, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("@Store", "INSERT");
                    cmd.Parameters.AddWithValue("@mahoadon", MaHoaDon);
                    cmd.Parameters.AddWithValue("@mahopdong", MaHopDong);
                    cmd.Parameters.AddWithValue("@sodien", SoDien);
                    cmd.Parameters.AddWithValue("@sonuoc", SoNuoc);

                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("@Store", "UPDATE");
                    cmd.Parameters.AddWithValue("@mahoadon", MaHoaDon);
                    cmd.Parameters.AddWithValue("@mahopdong", MaHopDong);
                    cmd.Parameters.AddWithValue("@sodien", SoDien);
                    cmd.Parameters.AddWithValue("@sonuoc", SoNuoc);

                    break;
            }
            cmd.ExecuteNonQuery();
        }

        // Phòng Trọ
        public void PhongTro(string strStore, int MaPhong, string SoPhong, string ViTri, decimal DienTich, decimal GiaThue, bool TinhTrangThue, bool TrangThai, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("@Store", "INSERT");
                    cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
                    cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                    cmd.Parameters.AddWithValue("@ViTri", ViTri);
                    cmd.Parameters.AddWithValue("@DienTich", DienTich);
                    cmd.Parameters.AddWithValue("@GiaThue", GiaThue);
                    cmd.Parameters.AddWithValue("@TinhTrangThue", TinhTrangThue);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("@Store", "UPDATE");
                    cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
                    cmd.Parameters.AddWithValue("@SoPhong", SoPhong);
                    cmd.Parameters.AddWithValue("@ViTri", ViTri);
                    cmd.Parameters.AddWithValue("@DienTich", DienTich);
                    cmd.Parameters.AddWithValue("@GiaThue", GiaThue);
                    cmd.Parameters.AddWithValue("@TinhTrangThue", TinhTrangThue);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                    break;
            }
            cmd.ExecuteNonQuery();
        }

        // Giá Điện Nước
        public void GiaDienNuoc(string strStore, int GiaDien, int GiaNuoc, DateTime NgayApDung, bool TrangThai, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("@Store", "INSERT");
                    cmd.Parameters.AddWithValue("@GiaDien", GiaDien);
                    cmd.Parameters.AddWithValue("@GiaNuoc", GiaNuoc);
                    cmd.Parameters.AddWithValue("@NgayApDung", NgayApDung);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //Account
        public void Account(string strStore, int MaTK, string Username, string Password,string Loai, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("@Store", "INSERT");
                    cmd.Parameters.AddWithValue("@matk", MaTK);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@loai", Loai);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("@Store", "UPDATE");
                    cmd.Parameters.AddWithValue("@matk", MaTK);
                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@loai", Loai);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
    }
}
