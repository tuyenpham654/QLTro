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

namespace QLTro.views
{
    public partial class FrmNguoiThue : Form
    {
        public FrmNguoiThue()
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
            dgv_nguoithue.DataSource = ctr.LoadDataTable("vw_NguoiThue");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            NguoiThue n = new NguoiThue();
            if (txt_manguoithue.Text != "")
            {
                DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                {
                    n.MaNguoiThue1 = txt_manguoithue.Text;
                    ctr.Delete("NguoiThue", n.MaNguoiThue1);
                    ctr.Disconnect();
                    MessageBox.Show("Xóa sách thành công", "Thông báo");
                    TextBox[] textBoxes = { txt_manguoithue, txt_hoten, txt_dc, txt_sdt, txt_email };
                    foreach (TextBox textBox in textBoxes)
                    {
                        textBox.Text = "";
                    }
                    LoadDGV();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người thuê để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_nguoithue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manguoithue.Text = dgv_nguoithue.CurrentRow.Cells[0].Value.ToString();
            txt_hoten.Text = dgv_nguoithue.CurrentRow.Cells[1].Value.ToString();
            if (dgv_nguoithue.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rad_nam.Checked = true;
            }
            else
            {
                rad_nu.Checked = true;
            }
            dt_ngaysinh.Value = Convert.ToDateTime(dgv_nguoithue.CurrentRow.Cells[3].Value.ToString());
            txt_dc.Text = dgv_nguoithue.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = dgv_nguoithue.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = dgv_nguoithue.CurrentRow.Cells[6].Value.ToString();
            if (dgv_nguoithue.CurrentRow.Cells[7].Value != null)
            {
                if (dgv_nguoithue.CurrentRow.Cells[7].Value.ToString() == "active")
                {
                    txt_trangthai.Text = "active";
                }
                else
                {
                    txt_trangthai.Text = "passive";
                }
            }
            else
            {
                txt_trangthai.Text = string.Empty;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        NguoiThue n;
        private void btn_them_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            n = new NguoiThue();
            if (IsEmpty(txt_manguoithue.Text) || IsEmpty(txt_hoten.Text) || IsEmpty(txt_dc.Text) || IsEmpty(txt_sdt.Text) || IsEmpty(txt_email.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                n.MaNguoiThue1 = txt_manguoithue.Text;
                n.HoTen1 = txt_hoten.Text;
                n.GioiTinh1 = rad_nam.Checked ? true : false;
                n.NgaySinh1 = dt_ngaysinh.Value;
                n.DiaChi1 = txt_dc.Text;
                n.DienThoai1 = txt_sdt.Text;
                n.Email1 = txt_email.Text;
                ctr.NguoiThue(int.Parse(n.MaNguoiThue1), n.HoTen1, n.GioiTinh1, n.NgaySinh1, n.Email1, n.DienThoai1, n.DiaChi1,n.TrangThai1, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm mới thành công !!");
                TextBox[] textBoxes = { txt_manguoithue, txt_hoten, txt_dc, txt_sdt, txt_email };
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
            n = new NguoiThue();
            if (IsEmpty(txt_hoten.Text) || IsEmpty(txt_dc.Text) || IsEmpty(txt_sdt.Text) || IsEmpty(txt_email.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                n.MaNguoiThue1 = txt_manguoithue.Text;
                n.HoTen1 = txt_hoten.Text;
                n.GioiTinh1 = rad_nam.Checked ? true : false;
                n.NgaySinh1 = dt_ngaysinh.Value;
                n.DiaChi1 = txt_dc.Text;
                n.DienThoai1 = txt_sdt.Text;
                n.Email1 = txt_email.Text;
                ctr.NguoiThue(int.Parse(n.MaNguoiThue1), n.HoTen1, n.GioiTinh1, n.NgaySinh1, n.Email1, n.DienThoai1, n.DiaChi1, n.TrangThai1, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa thành công !!");
                TextBox[] textBoxes = { txt_manguoithue, txt_hoten, txt_dc, txt_sdt, txt_email };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {
                Controls ctr = new controllers.Controls();
                dgv_nguoithue.DataSource = ctr.Search(txt_timkiem.Text, "HOTEN_NGUOITHUE");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_nguoithue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
