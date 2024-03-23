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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "UserName")
            {
                txtUserName.Text = "";

                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "UserName";

                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";

                txtPassword.ForeColor = Color.Black;
                
            }
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";

                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=STEVE;Initial Catalog=Quan_Ly_Sinh_Vien;User ID=sa;Password=123456;Integrated Security=True");
            try
            {
                connect.Open();
                string tenTK = txtUserName.Text;
                string pass = txtPassword.Text;
                string sql = "select * from QTV where tenTK ='" + tenTK + "' and MatKhau ='" + pass + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo!");

                    FmQuanLy f = new FmQuanLy(tenTK,pass);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông Báo!");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Lỗi kết nối", "Thông Báo!");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
