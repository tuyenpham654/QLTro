using QLTro.controllers;
using QLTro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTro
{
    public partial class FrmAccount : Form
    {
        Controls ctr = new controllers.Controls();
        public FrmAccount(string tk)
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            dgv_account.DataSource = ctr.LoadDataTable("vw_account");
        }
        private bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        private void dgv_account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mataikhoan.Text = dgv_account.CurrentRow.Cells[0].Value.ToString();
            txt_username.Text = dgv_account.CurrentRow.Cells[1].Value.ToString();
            txt_loai.Text = dgv_account.CurrentRow.Cells[2].Value.ToString();
            txt_password.Text = "";            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();

            Account n = new Account();

            if (txt_mataikhoan.Text != "")
            {
                DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                {
                    n.MaTK1 = txt_mataikhoan.Text;
                    ctr.Delete("Account", n.MaTK1);
                    ctr.Disconnect();
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo");
                    TextBox[] textBoxes = { txt_mataikhoan, txt_username, txt_password, txt_loai };
                    foreach (TextBox textBox in textBoxes)
                    {
                        textBox.Text = "";
                    }
                    LoadDGV();

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        Account n;
        private void btn_them_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            n = new Account();
            if (IsEmpty(txt_mataikhoan.Text) || IsEmpty(txt_username.Text) || IsEmpty(txt_password.Text) || IsEmpty(txt_loai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                n.MaTK1 = txt_mataikhoan.Text;
                n.Username = txt_username.Text;
                n.Password = txt_password.Text;
                n.Loai= txt_loai.Text;        
                ctr.Account(int.Parse(n.MaTK1), n.Username, n.Password, n.Loai, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm mới thành công !!");
                TextBox[] textBoxes = { txt_mataikhoan, txt_username, txt_password, txt_loai };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            n = new Account();
            if (IsEmpty(txt_mataikhoan.Text) || IsEmpty(txt_username.Text) || IsEmpty(txt_password.Text) || IsEmpty(txt_loai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                n.MaTK1 = txt_mataikhoan.Text;
                n.Username = txt_username.Text;
                n.Password = txt_password.Text;
                n.Loai = txt_loai.Text;
                ctr.Account(int.Parse(n.MaTK1), n.Username, n.Password, n.Loai, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa thành công !!");
                TextBox[] textBoxes = { txt_mataikhoan, txt_username, txt_password, txt_loai };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }
    }
}
