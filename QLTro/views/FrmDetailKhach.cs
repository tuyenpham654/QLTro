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

            dgv_khachdt.DataSource = ctr.Search(mp, "DT_KHACH");
            if (dgv_khachdt.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_khachdt.Rows[0];

                txt_makhach.Text = selectedRow.Cells[0].Value.ToString();
                txt_hoten.Text = selectedRow.Cells[1].Value.ToString();
                txt_gioitinh.Text = selectedRow.Cells[2].Value.ToString();
                /*if (selectedRow.Cells[2].Value != null)
                {
                    if (selectedRow.Cells[3].Value.ToString() == "active")
                    {
                        txt_gioitinh.Text = "Nam";
                    }
                    else
                    {
                        txt_gioitinh.Text = "Nữ";
                    }
                }
                else
                {
                    txt_gioitinh.Text = string.Empty;
                }*/
                txt_sophong.Text = selectedRow.Cells[3].Value.ToString();

                string dateStringbd = selectedRow.Cells[4].Value.ToString();
                DateTime dateValuebd = DateTime.Parse(dateStringbd);
                string ngaysinh = dateValuebd.ToShortDateString();
                txt_ngaysinh.Text = ngaysinh;

                txt_diachi.Text = selectedRow.Cells[5].Value.ToString();
                txt_sdt.Text = selectedRow.Cells[6].Value.ToString();
                txt_email.Text = selectedRow.Cells[7].Value.ToString();
               

                string dateString = selectedRow.Cells[9].Value.ToString();
                DateTime dateValue = DateTime.Parse(dateString);
                string ngayBatDau = dateValue.ToShortDateString();
                txt_ngaybatdau.Text = ngayBatDau;

                string dateString1 = selectedRow.Cells[10].Value.ToString();
                DateTime dateValue1 = DateTime.Parse(dateString);
                string ngayBatDau1 = dateValue.ToShortDateString();
                txt_ngayketthuc.Text = ngayBatDau1;


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
