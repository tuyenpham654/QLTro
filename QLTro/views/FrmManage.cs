using QLTro.controllers;
using QLTro.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTro
{
    public partial class FrmManage : Form
    {
        Controls ctr = new controllers.Controls();
        public FrmManage(string tk)
        {
            InitializeComponent();
            label1.Text = "Xin chào " + tk;
            loadDGV();
        }
        public void loadDGV()
        {
            dgv_quahan.DataSource = ctr.LoadDataTable("vw_QuaHan");   
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sửaĐổiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.Show();
            this.Close();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAccount f = new FrmAccount();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNguoiThue f = new FrmNguoiThue();
            f.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongTro f = new FrmPhongTro();
            f.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout f = new FrmAbout();
            f.Show();
        }

        private void giáĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiaDienNuoc f = new FrmGiaDienNuoc();
            f.Show();
        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSearchPhongTro f = new FrmSearchPhongTro();
            f.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchKhach f = new FrmSearchKhach();
            f.Show();
        }
    }
}
