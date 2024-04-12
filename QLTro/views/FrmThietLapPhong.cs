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
    public partial class FrmThietLapPhong : Form
    {
        public FrmThietLapPhong()
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
            dgv_phongtropassive.DataSource = ctr.LoadDataTable("vw_ThietLapPhong");
        }

        private void dgv_phongtropassive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphong.Text = dgv_phongtropassive.CurrentRow.Cells[0].Value?.ToString() ?? "";
            txt_sophong.Text = dgv_phongtropassive.CurrentRow.Cells[1].Value?.ToString() ?? "";
            txt_vitri.Text = dgv_phongtropassive.CurrentRow.Cells[2].Value?.ToString() ?? "";
            txt_dientich.Text = dgv_phongtropassive.CurrentRow.Cells[3].Value?.ToString() ?? "";
            txt_giathue.Text = dgv_phongtropassive.CurrentRow.Cells[4].Value?.ToString() ?? "";

            if (dgv_phongtropassive.CurrentRow.Cells[5].Value != null)
            {
                if (dgv_phongtropassive.CurrentRow.Cells[5].Value.ToString() == "active")
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txt_maphong, txt_sophong, txt_vitri, txt_dientich, txt_giathue, txt_trangthai };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
            LoadDGV();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {
                Controls ctr = new controllers.Controls();
                dgv_phongtropassive.DataSource = ctr.Search(txt_timkiem.Text, "SOPHONG_PHONGTRO_THIETLAPPHONG");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        PhongTro pt;
        private void btn_reacctive_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            pt = new PhongTro();
            if (IsEmpty(txt_maphong.Text) || IsEmpty(txt_sophong.Text) || IsEmpty(txt_vitri.Text) || IsEmpty(txt_dientich.Text) || IsEmpty(txt_giathue.Text) || IsEmpty(txt_vitri.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pt.Maphong = txt_maphong.Text;
                pt.Sophong = txt_sophong.Text;
                pt.Vitri = txt_vitri.Text;

                decimal DienTich;
                decimal GiaThue;

                if (!decimal.TryParse(txt_dientich.Text, out DienTich))
                {
                    MessageBox.Show("Giá trị diện tích không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txt_giathue.Text, out GiaThue))
                {
                    MessageBox.Show("Giá trị giá thuê không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pt.Dientich = DienTich;
                pt.Giathue = GiaThue;

                ctr.PhongTro(int.Parse(pt.Maphong), pt.Sophong, pt.Vitri, pt.Dientich, pt.Giathue, pt.Tinhtrangthue, true, "REACTIVATE");
                ctr.Disconnect();
                MessageBox.Show("Tái kích hoạt thành công !!");
                TextBox[] textBoxes = { txt_maphong, txt_sophong, txt_vitri, txt_dientich, txt_giathue, txt_trangthai };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }
    }
}
