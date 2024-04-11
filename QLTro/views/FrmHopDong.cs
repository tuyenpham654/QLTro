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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTro.views
{
    public partial class FrmHopDong : Form
    {
        Controls ctr = new controllers.Controls();
        public FrmHopDong()
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
            dgv_hopdong.DataSource = ctr.LoadDataTableHOP("vw_HopDong");
            LoadCBO();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {
                
                dgv_hopdong.DataSource = ctr.Search(txt_timkiem.Text, "TIMKIEM_HOPDONG");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
        private void LoadCBO()
        {
            
            cb_nguoithue.DisplayMember = "HoTen";
            cb_nguoithue.ValueMember = "MaNguoiThue";
            cb_phong.DisplayMember = "SoPhong";
            cb_phong.ValueMember = "MaPhong";
            cb_nguoithue.DataSource = ctr.LoadDataTable("NguoiThue");
            cb_phong.DataSource = ctr.LoadDataTable("PhongTro");
        }

        HopDongThue hd;
        private void btn_xoa_Click(object sender, EventArgs e)
        {

             hd = new HopDongThue();
            if (txt_mahopdong.Text != "")
            {
                DialogResult tb = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                {
                    hd.Mahopdong = txt_mahopdong.Text;
                    ctr.Delete("HopDong", hd.Mahopdong);
                    ctr.Disconnect();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    System.Windows.Forms.TextBox[] textBoxes = { txt_mahopdong, txt_phuthu,txt_soluongnguoi, txt_timkiem };
                    foreach (System.Windows.Forms.TextBox textBox in textBoxes)
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

            hd = new HopDongThue();
            if (IsEmpty(txt_mahopdong.Text) || IsEmpty(txt_phuthu.Text) || IsEmpty(txt_soluongnguoi.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hd.Mahopdong= txt_mahopdong.Text;
                hd.Phuthu = double.Parse(txt_phuthu.Text);
                hd.Soluongnguoi = int.Parse(txt_soluongnguoi.Text);
                hd.Ngaybatdau = dt_ngaybatdau.Value;
                hd.Ngayketthuc = dt_ngayketthuc.Value;
                hd.Maphong = int.Parse(cb_phong.SelectedValue.ToString());
                hd.Manguoithue = int.Parse(cb_nguoithue.SelectedValue.ToString());
               
                ctr.HopDong(int.Parse(hd.Mahopdong), hd.Manguoithue, hd.Maphong, hd.Ngaybatdau,hd.Ngayketthuc,hd.Soluongnguoi,hd.Phuthu, "UPDATE");
                ctr.Disconnect();
                MessageBox.Show("Sửa thành công !!");
                System.Windows.Forms.TextBox[] textBoxes = { txt_mahopdong, txt_phuthu, txt_soluongnguoi, txt_timkiem };
                foreach (System.Windows.Forms.TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            hd = new HopDongThue();
            if (IsEmpty(txt_mahopdong.Text) || IsEmpty(txt_phuthu.Text) || IsEmpty(txt_soluongnguoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hd.Mahopdong = txt_mahopdong.Text;
                hd.Phuthu = double.Parse(txt_phuthu.Text);
                hd.Soluongnguoi = int.Parse(txt_soluongnguoi.Text);
                hd.Ngaybatdau = dt_ngaybatdau.Value;
                hd.Ngayketthuc = dt_ngayketthuc.Value;
                hd.Maphong = int.Parse(cb_phong.SelectedValue.ToString());
                hd.Manguoithue = int.Parse(cb_nguoithue.SelectedValue.ToString());

                ctr.HopDong(int.Parse(hd.Mahopdong), hd.Manguoithue, hd.Maphong, hd.Ngaybatdau, hd.Ngayketthuc, hd.Soluongnguoi, hd.Phuthu, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm mới thành công !!");
                System.Windows.Forms.TextBox[] textBoxes = { txt_mahopdong, txt_phuthu, txt_soluongnguoi, txt_timkiem };
                foreach (System.Windows.Forms.TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadDGV();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_hopdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            txt_mahopdong.Text = dgv_hopdong.CurrentRow.Cells[0].Value.ToString();
            txt_phuthu.Text = dgv_hopdong.CurrentRow.Cells[7].Value.ToString();
            txt_soluongnguoi.Text = dgv_hopdong.CurrentRow.Cells[4].Value.ToString();
            cb_nguoithue.DisplayMember = dgv_hopdong.CurrentRow.Cells[2].Value.ToString();
            cb_phong.DisplayMember = dgv_hopdong.CurrentRow.Cells[3].Value.ToString();
            dt_ngaybatdau.Value = DateTime.Parse( dgv_hopdong.CurrentRow.Cells[5].Value.ToString());
            dt_ngayketthuc.Value = DateTime.Parse(dgv_hopdong.CurrentRow.Cells[6].Value.ToString());
        }
    }
}
