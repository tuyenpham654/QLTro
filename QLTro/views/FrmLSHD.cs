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
    public partial class FrmLSHD : Form
    {
        Controls ctr = new controllers.Controls();
        public FrmLSHD()
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
            dgv_lshd.DataSource = ctr.LoadDataTable("vw_HoaDonLog");

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {

                dgv_lshd.DataSource = ctr.Search(txt_timkiem.Text, "TIMKIEM_LSHOADON");
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
    }
}
