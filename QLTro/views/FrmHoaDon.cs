using QLTro.controllers;
using QLTro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTro.views
{
    public partial class FrmHoaDon : Form
    {
        Controls ctr = new controllers.Controls();
        public FrmHoaDon()
        {
            InitializeComponent();
            LoadDGV();
        }
        private bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        private void LoadDGV()
        {
            dgv_hoadon.DataSource = ctr.LoadDataTableHD("vw_HoaDon");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {
                Controls ctr = new controllers.Controls();
                dgv_hoadon.DataSource = ctr.Search(txt_timkiem.Text, "TIMKIEM_HOADON");
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            if (txt_mahd.Text != "")
            {
                DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                {
                    hd.Mahoadon = txt_mahd.Text;
                    ctr.Delete("HoaDon", hd.Mahoadon);
                    ctr.Disconnect();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    TextBox[] textBoxes = { txt_mahd, txt_mahopdong, txt_sodien, txt_sonuoc };
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
            HoaDon hd = new HoaDon();

            if (IsEmpty(txt_mahd.Text) || IsEmpty(txt_mahopdong.Text) || IsEmpty(txt_sodien.Text) || IsEmpty(txt_sonuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hd.Mahoadon = txt_mahd.Text;
                hd.Mahopdong = txt_mahopdong.Text;
                hd.Sonuoc = int.Parse(txt_sonuoc.Text);
                hd.Sodien = int.Parse(txt_sodien.Text);
                hd.Ngaylap = DateTime.Now;
                ctr.HoaDon(int.Parse(hd.Mahoadon), int.Parse(hd.Mahopdong), hd.Sodien, hd.Sonuoc, hd.Ngaylap, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa thành công !!");
                TextBox[] textBoxes = { txt_mahd, txt_mahopdong, txt_sodien, txt_sonuoc };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            HoaDon hd = new HoaDon();
            if (IsEmpty(txt_mahd.Text) || IsEmpty(txt_mahopdong.Text) || IsEmpty(txt_sodien.Text) || IsEmpty(txt_sonuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hd.Mahoadon = txt_mahd.Text;
                hd.Mahopdong = txt_mahopdong.Text;
                hd.Sonuoc = int.Parse( txt_sonuoc.Text);
                hd.Sodien = int.Parse(txt_sodien.Text);
                hd.Ngaylap = DateTime.Now;
                
                ctr.HoaDon(int.Parse(hd.Mahoadon), int.Parse(hd.Mahopdong), hd.Sodien, hd.Sonuoc, hd.Ngaylap, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm mới thành công !!");
                TextBox[] textBoxes = { txt_mahd, txt_mahopdong, txt_sodien, txt_sonuoc };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = dgv_hoadon.CurrentRow.Cells[0].Value.ToString();
            txt_mahopdong.Text = dgv_hoadon.CurrentRow.Cells[1].Value.ToString();
            txt_sodien.Text = dgv_hoadon.CurrentRow.Cells[2].Value.ToString();
            txt_sonuoc.Text = dgv_hoadon.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
