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
    public partial class FrmPhongTro : Form
    {
        public FrmPhongTro()
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
            dgv_phongtro.DataSource = ctr.LoadDataTable("vw_PhongTro");
        }

        private void dgv_phongtro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphong.Text = dgv_phongtro.CurrentRow.Cells[0].Value?.ToString() ?? "";
            txt_sophong.Text = dgv_phongtro.CurrentRow.Cells[1].Value?.ToString() ?? "";
            txt_vitri.Text = dgv_phongtro.CurrentRow.Cells[2].Value?.ToString() ?? "";
            txt_dientich.Text = dgv_phongtro.CurrentRow.Cells[3].Value?.ToString() ?? "";
            txt_giathue.Text = dgv_phongtro.CurrentRow.Cells[4].Value?.ToString() ?? "";

            if (dgv_phongtro.CurrentRow.Cells[5].Value != null)
            {
                if (dgv_phongtro.CurrentRow.Cells[5].Value.ToString() == "Đang thuê")
                {
                    txt_tinhtrangthue.Text = "Đang thuê";
                }
                else
                {
                    txt_tinhtrangthue.Text = "Không cho thuê";
                }
            }
            else
            {
                txt_trangthai.Text = string.Empty;
            }

            if (dgv_phongtro.CurrentRow.Cells[6].Value != null)
            {
                if (dgv_phongtro.CurrentRow.Cells[6].Value.ToString() == "active")
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
            pn_info.Hide();
            TextBox[] textBoxes = { txt_maphong, txt_sophong, txt_vitri, txt_dientich, txt_giathue, txt_tinhtrangthue, txt_trangthai };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
            LoadDGV();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {
                Controls ctr = new controllers.Controls();
                dgv_phongtro.DataSource = ctr.Search(txt_timkiem.Text, "SOPHONG_PHONGTRO");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            PhongTro p = new PhongTro();
            if (txt_maphong.Text != "")
            {
                int maPhong = int.Parse(txt_maphong.Text);
                bool result;
                ctr.CheckPhongThue(maPhong, out result);

                if (result)
                {
                    MessageBox.Show("Không thể xóa phòng đang được thuê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa phòng?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (tb == DialogResult.OK)
                    {
                        p.Maphong = txt_maphong.Text;
                        ctr.Delete("PhongTro", p.Maphong);
                        ctr.Disconnect();
                        MessageBox.Show("Xóa phòng thành công", "Thông báo");
                        LoadDGV();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        PhongTro pt;
        private void btn_them_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            pt = new PhongTro();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            if (!pn_info.Visible)
            {
                pn_info.Visible = true;
                return;
            }
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
                }
                if (!decimal.TryParse(txt_giathue.Text, out GiaThue))
                {
                    MessageBox.Show("Giá trị diện tích không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pt.Dientich = DienTich;
                pt.Giathue = GiaThue;
                ctr.PhongTro(int.Parse(pt.Maphong), pt.Sophong, pt.Vitri, pt.Dientich, pt.Giathue, pt.Tinhtrangthue, pt.Trangthai, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm mới thành công !!");
                pn_info.Visible = false;
                TextBox[] textBoxes = { txt_maphong, txt_sophong, txt_vitri, txt_dientich, txt_giathue, txt_tinhtrangthue, txt_trangthai };
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
            pt = new PhongTro();
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            txt_maphong.ReadOnly = true;
            if (!pn_info.Visible)
            {
                pn_info.Visible = true;
                return;
            }
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
                }
                if (!decimal.TryParse(txt_giathue.Text, out GiaThue))
                {
                    MessageBox.Show("Giá trị diện tích không hợp lệ. Vui lòng nhập một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pt.Dientich = DienTich;
                pt.Giathue = GiaThue;
                ctr.PhongTro(int.Parse(pt.Maphong), pt.Sophong, pt.Vitri, pt.Dientich, pt.Giathue, pt.Tinhtrangthue, pt.Trangthai, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa thành công !!");
                pn_info.Visible = false;
                TextBox[] textBoxes = { txt_maphong, txt_sophong, txt_vitri, txt_dientich, txt_giathue, txt_tinhtrangthue, txt_trangthai };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();

            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            pn_info.Visible = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            txt_maphong.ReadOnly = false;
            TextBox[] textBoxes = { txt_maphong, txt_sophong, txt_vitri, txt_dientich, txt_giathue, txt_tinhtrangthue, txt_trangthai };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

    }
}
