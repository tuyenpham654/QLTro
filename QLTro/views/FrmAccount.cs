using QLTro.controllers;
using QLTro.models;
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
        
        public FrmAccount()
        {
            InitializeComponent();
            LoadDGV();
        }
        Controls ctr = new controllers.Controls();
        private bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        private void LoadDGV()
        {
            dgv_account.DataSource = ctr.LoadDataTable("vw_Account");

            List<DataRow> accountList = ctr.LoadDataTable("vw_Account").AsEnumerable().ToList();


        }



        private void FmAccount_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        Account nt;
        private void btn_them_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            nt = new Account();
            if (IsEmpty(txt_matk.Text) || IsEmpty(txt_username.Text) || IsEmpty(txt_password.Text) || IsEmpty(txt_loai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nt.Matk = txt_matk.Text;
                nt.Username = txt_username.Text;
                nt.Password = txt_password.Text;
                
                nt.Loai = txt_loai.Text;
                
                ctr.Account(int.Parse(nt.Matk), nt.Username, nt.Password, nt.Loai, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm mới thành công !!");
                TextBox[] textBoxes = { txt_matk, txt_username, txt_password, txt_loai};
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            Account nt = new Account();
            if (txt_matk.Text != "")
            {
                DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                {
                    nt.Matk = txt_matk.Text;
                    ctr.Delete("Account", nt.Matk);
                    ctr.Disconnect();
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo");
                    TextBox[] textBoxes = { txt_matk,txt_username,txt_password,txt_loai };
                    foreach (TextBox textBox in textBoxes)
                    {
                        textBox.Text = "";
                    }
                    LoadDGV();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            nt = new Account();
            if (IsEmpty(txt_matk.Text) || IsEmpty(txt_username.Text) || IsEmpty(txt_password.Text) || IsEmpty(txt_loai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nt.Matk = txt_matk.Text;
                nt.Username = txt_username.Text;
                nt.Password = txt_password.Text;
                nt.Loai = txt_loai.Text;

                ctr.Account(int.Parse(nt.Matk), nt.Username, nt.Password, nt.Loai, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa thành công !!");
                TextBox[] textBoxes = { txt_matk, txt_username, txt_password, txt_loai };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void dgv_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_matk.Text = dgv_account.CurrentRow.Cells[0].Value.ToString();
            txt_username.Text = dgv_account.CurrentRow.Cells[1].Value.ToString();
            txt_password.Text = "";
            txt_loai.Text = dgv_account.CurrentRow.Cells[1].Value.ToString();
          
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
