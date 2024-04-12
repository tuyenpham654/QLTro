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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTro.views
{
    public partial class FrmDetailPhong : Form
    {
        Controls ctr = new controllers.Controls();

        public FrmDetailPhong(string ma)
        {
            InitializeComponent();
            LoadDGV(ma);

        }
        private void LoadDGV(string mp)
        {
            DataTable dt = ctr.Search(mp, "DT_PHONGTRO");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
               
                txt_maphong.Text = row["Ma Phong"].ToString();
                txt_sophong.Text = row["Số Phòng"].ToString();
                txt_vitri.Text = row["Vị trí phòng"].ToString();
                
                txt_trangthai.Text = row["Trạng thái phòng"].ToString();
                txt_tinhtrangthue.Text = row["tình trạng thuê"].ToString();   

                txt_hoten.Text = row["Họ tên người thuê"].ToString();
                txt_mahopdong.Text = row["Mã hợp đồng"].ToString();

                DateTime? dateValue = row["Ngày bắt đầu"] as DateTime?;
                if (dateValue != null)
                {
                    string ngayBatDau = dateValue.Value.ToShortDateString();
                    txt_ngaybatdau.Text = ngayBatDau;
                }
                else
                {
                    txt_ngaybatdau.Text = "";
                }

                DateTime? datekt = row["Ngày kết thúc"] as DateTime?;
                if(datekt != null)
                {
                    string ngayBatDau1 = datekt.Value.ToShortDateString();
                    txt_ngayketthuc.Text = ngayBatDau1;
                }
                else
                {
                    txt_ngaybatdau.Text = "";
                }

                txt_dientich.Text = row["DienTich"].ToString();
                txt_giathue.Text = row["GiaThue"].ToString();
            }

        }
        
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
