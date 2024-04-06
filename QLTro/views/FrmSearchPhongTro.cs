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
    public partial class FrmSearchPhongTro : Form
    {
        public FrmSearchPhongTro()
        {
            InitializeComponent();
            LoadDGV();
        }
        Controls ctr = new controllers.Controls();
        private void LoadDGV()
        {
            dgv_searchphong.DataSource = ctr.LoadDataTable("vw_SearchPhong");
        }
        private bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {
                Controls ctr = new controllers.Controls();
                dgv_searchphong.DataSource = ctr.Search(txt_timkiem.Text, "TIMKIIEM_PHONGTRO");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        private void dgv_searchphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgv_searchphong.CurrentRow.Cells[0].Value.ToString();
            FrmDetailPhong f = new FrmDetailPhong(ma);
            f.ShowDialog();
        }

        private void dgv_searchphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgv_searchphong.CurrentRow.Cells[0].Value.ToString();
            FrmDetailPhong f = new FrmDetailPhong(ma);
            f.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
