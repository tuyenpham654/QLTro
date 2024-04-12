using QLTro.controllers;
using QLTro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dgv_hopdong.DataSource = ctr.LoadDataTable("vw_HopDong");
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
                Controls ctr = new controllers.Controls();
                dgv_hopdong.DataSource = ctr.Search(txt_timkiem.Text, "");
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


        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

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

            int manguoithue;
            if (!int.TryParse(cb_nguoithue.Text, out manguoithue))
            {
                MessageBox.Show("Mã phòng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ct_hd.Manguoithue = manguoithue;

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

            int maphong;

            if (!int.TryParse(cb_phong.SelectedValue.ToString(), out maphong))
            {
                MessageBox.Show("Giá trị không hợp lệ: " + cb_phong.SelectedValue.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Giá trị của maphong: " + maphong);
            }
            Console.WriteLine("Giá trị của maphong: " + maphong);

            ct_hd.Maphong = maphong;


            DateTime ngayBatDau = dt_start.Value;
            DateTime ngayKetThuc = dt_end.Value;

            if (ngayBatDau >= ngayKetThuc || ngayKetThuc <= ngayBatDau.AddDays(14))
            {
                MessageBox.Show("Ngày kết thúc phải sau ít nhất 14 ngày so với ngày bắt đầu và phải lớn hơn ngày bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

    }
}
