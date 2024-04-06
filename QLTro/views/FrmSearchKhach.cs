using QLTro.controllers;
using System;
using System.CodeDom;
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
    public partial class FrmSearchKhach : Form
    {
        
        Controls ctr = new controllers.Controls();
        public FrmSearchKhach()
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
            dgv_searchkhach.DataSource = ctr.LoadDataTable("vw_SearchKhach");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void dgv_searchkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgv_searchkhach.CurrentRow.Cells[0].Value.ToString();
            FrmDetailKhach f = new FrmDetailKhach(ma);
            f.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(txt_timkiem.Text))
            {
                Controls ctr = new controllers.Controls();
                dgv_searchkhach.DataSource = ctr.Search(txt_timkiem.Text, "TIMKIIEM_KHACH");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
