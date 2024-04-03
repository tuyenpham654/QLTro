using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLTro
{
    public partial class FrmAccount : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=STEVE;Initial Catalog=Quan_Ly_Sinh_Vien;User ID=sa;Password=123456;Integrated Security=True");
        public FrmAccount(string tk)
        {
            InitializeComponent();
            label1.Text = "Xin chào " + tk;
            loaddata(tk);
        }
        public void loaddata(string t)
        {
            connect.Open();
            string sql = "select * from QTV where tenTK ='" + t + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FmAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
