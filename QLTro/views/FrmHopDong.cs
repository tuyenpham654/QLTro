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
            dgv_hopdong.DataSource = ctr.LoadDataTable("vw_HopDong");
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

        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
