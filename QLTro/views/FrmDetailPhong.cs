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
            //Loadtxtbox();
        }
        private void LoadDGV(string mp)
        {

            dgv_detail.DataSource = ctr.Search(mp, "DT_PHONGTRO");
            if (dgv_detail.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_detail.Rows[0];

                txt_maphong.Text = selectedRow.Cells[0].Value.ToString();
                txt_sophong.Text = selectedRow.Cells[1].Value.ToString();
                txt_vitri.Text = selectedRow.Cells[2].Value.ToString();
                if (selectedRow.Cells[3].Value != null)
                {
                    if (selectedRow.Cells[3].Value.ToString() == "active")
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
                if (selectedRow.Cells[4].Value != null)
                {
                    if (selectedRow.Cells[4].Value.ToString() == "active")
                    {
                        txt_tinhtrangthue.Text = "active";
                    }
                    else
                    {
                        txt_tinhtrangthue.Text = "passive";
                    }
                }
                else
                {
                    txt_tinhtrangthue.Text = string.Empty;
                }
                txt_hoten.Text = selectedRow.Cells[5].Value.ToString();
                txt_mahopdong.Text = selectedRow.Cells[6].Value.ToString();

                string dateString = selectedRow.Cells[7].Value.ToString();
                DateTime dateValue = DateTime.Parse(dateString);
                string ngayBatDau = dateValue.ToShortDateString();
                txt_ngaybatdau.Text = ngayBatDau;

                string dateString1 = selectedRow.Cells[8].Value.ToString();
                DateTime dateValue1 = DateTime.Parse(dateString);
                string ngayBatDau1 = dateValue.ToShortDateString();
                txt_ngayketthuc.Text = ngayBatDau1;
                txt_dientich.Text = selectedRow.Cells[9].Value.ToString();
                txt_giathue.Text = selectedRow.Cells[10].Value.ToString();

            }
        }
        private void Loadtxtbox()
        {

            txt_maphong.Text = dgv_detail.CurrentRow.Cells[0].Value.ToString();
            txt_sophong.Text = dgv_detail.CurrentRow.Cells[1].Value.ToString();
            txt_vitri.Text = dgv_detail.CurrentRow.Cells[2].Value.ToString();
            if (dgv_detail.CurrentRow.Cells[3].Value != null)
            {
                if (dgv_detail.CurrentRow.Cells[3].Value.ToString() == "active")
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
            if (dgv_detail.CurrentRow.Cells[4].Value != null)
            {
                if (dgv_detail.CurrentRow.Cells[4].Value.ToString() == "active")
                {
                    txt_tinhtrangthue.Text = "active";
                }
                else
                {
                    txt_tinhtrangthue.Text = "passive";
                }
            }
            else
            {
                txt_tinhtrangthue.Text = string.Empty;
            }
            txt_hoten.Text = dgv_detail.CurrentRow.Cells[5].Value.ToString();
            txt_mahopdong.Text = dgv_detail.CurrentRow.Cells[6].Value.ToString();
            txt_ngaybatdau.Text = dgv_detail.CurrentRow.Cells[7].Value.ToString();
            txt_ngayketthuc.Text = dgv_detail.CurrentRow.Cells[8].Value.ToString();


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
