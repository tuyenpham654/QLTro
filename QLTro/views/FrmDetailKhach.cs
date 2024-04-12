using QLTro.controllers;
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
    public partial class FrmDetailKhach : Form
    {
        Controls ctr = new controllers.Controls();
        public FrmDetailKhach(string mk)
        {
            InitializeComponent();
            LoadDGV(mk);
        }
        private void LoadDGV(string mp)
        {
            DataTable dt = ctr.Search(mp, "DT_KHACH");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                txt_makhach.Text = row["Mã"].ToString();
                txt_hoten.Text = row["Họ và Tên"].ToString();
                txt_gioitinh.Text = row["Giới Tính"].ToString();

                object soPhongValue = row["Số Phòng"];
                if (soPhongValue != DBNull.Value)
                {
                    txt_sophong.Text = soPhongValue.ToString();
                }
                else
                {
                    txt_sophong.Text = "";
                }

                DateTime dateValuebd =DateTime.Parse( row["NgaySinh"].ToString());
                string ngaysinh = dateValuebd.ToShortDateString();
                txt_ngaysinh.Text = ngaysinh;

                txt_diachi.Text = row["DiaChi"].ToString();
                txt_sdt.Text = row["DienThoai"].ToString();
                txt_email.Text = row["Email"].ToString();


                


                DateTime? datebd = row["NgayBatDau"] as DateTime?;
                if (datebd != null)
                {
                    string ngayBatDau = datebd.Value.ToShortDateString();
                    txt_ngayketthuc.Text = ngayBatDau;
                }
                else
                {
                    txt_ngaybatdau.Text = "";
                }
                DateTime? datekt = row["NgayKetThuc"] as DateTime?;
                if (datekt != null)
                {
                    string ngayKetThuc = datekt.Value.ToShortDateString();
                    txt_ngayketthuc.Text = ngayKetThuc;
                }
                else
                {
                    txt_ngayketthuc.Text = "";
                }                                
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ngaybatdau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
