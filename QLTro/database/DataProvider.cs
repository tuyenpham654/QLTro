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
    }
}
