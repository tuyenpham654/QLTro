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
            LoadComboBox();
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

        private void LoadComboBox()
        {
            cb_nguoithue.DisplayMember = "Họ Tên";
            cb_nguoithue.ValueMember = "Mã Người Thuê";
            cb_nguoithue.DataSource = ctr.LoadDataTable("vw_NguoiThueMoi");

            cb_phong.DisplayMember = "SoPhong";
            cb_phong.ValueMember = "MaPhong";
            cb_phong.DataSource = ctr.LoadDataTable("vw_PhongConTrong");
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
            TextBox[] textBoxes = { txt_mahopdong, txt_phuthu, txt_slnguoi, txt_timkiem };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }
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
            Controls ctr = new controllers.Controls();
            HopDong hd = new HopDong();
            ChiTietHopDong ct_hd = new ChiTietHopDong();

            if (IsEmpty(txt_slnguoi.Text) || IsEmpty(txt_mahopdong.Text) || IsEmpty(txt_phuthu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHopDong;
            if (!int.TryParse(txt_mahopdong.Text, out maHopDong))
            {
                MessageBox.Show("Giá trị không hợp lệ cho Mã hợp đồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hd == null)
            {
                hd = new HopDong();
            }

            if (ct_hd == null)
            {
                ct_hd = new ChiTietHopDong();
            }

            hd.Mahopdong = maHopDong;
            ct_hd.Mahopdong = maHopDong;
            ct_hd.Manguoithue = int.Parse(cb_nguoithue.SelectedValue.ToString());


            int slnguoi;
            if (!int.TryParse(txt_slnguoi.Text, out slnguoi))
            {
                MessageBox.Show("Số lượng người không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hd.Slnguoi = slnguoi;

            float phuthu;
            if (!float.TryParse(txt_phuthu.Text, out phuthu))
            {
                MessageBox.Show("Phụ thu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hd.Phuthu = phuthu;


            ct_hd.Maphong = int.Parse(cb_phong.SelectedValue.ToString());




            DateTime ngayBatDau = dt_start.Value;
            DateTime ngayKetThuc = dt_end.Value;
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

            if (ngayBatDau >= ngayKetThuc || ngayKetThuc <= ngayBatDau.AddDays(14))
            {
                MessageBox.Show("Ngày kết thúc phải sau ít nhất 14 ngày so với ngày bắt đầu và phải lớn hơn ngày bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

            hd.Ngaybatdau = ngayBatDau;
            hd.Ngaykethuc = ngayKetThuc;

            

            ctr.HopDongThue(hd.Mahopdong, hd.Ngaybatdau, hd.Ngaykethuc, hd.Slnguoi, hd.Phuthu, hd.Trangthai, "INSERT");
            ctr.ChiTietHopDong(ct_hd.Mahopdong, ct_hd.Manguoithue, ct_hd.Maphong, "INSERT");

            MessageBox.Show("Thêm mới thành công !!");
            TextBox[] textBoxes = { txt_mahopdong, txt_slnguoi, txt_phuthu };
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

        private void dgv_hopdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            int ma;
            if (!int.TryParse(cb_phong.SelectedValue.ToString(), out ma))
            {
                MessageBox.Show("Vui lòng chọn một mã phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string maPhongDetals = ma.ToString();
            FrmDetailPhong f = new FrmDetailPhong(maPhongDetals);
            f.ShowDialog();

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
