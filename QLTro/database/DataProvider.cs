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
        public bool Login(string strStore, string username, string password) //strStore = tên store Procedu truyền vào
        {

            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            return dt.Rows.Count > 0;
        }
        // Người Thuê
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
        public void Delete(string strStore, string tenbang, string ID)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tenbang", SqlDbType.NVarChar).Value = tenbang;
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;
            cmd.ExecuteNonQuery();
        }
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
            }
            dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

    }
}
