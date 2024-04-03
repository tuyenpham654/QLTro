using QLTro.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTro
{
    public partial class FrmManage : Form
    {
        public FrmManage()
        {
            InitializeComponent();

        }
        public string tk;
        public FrmManage(string tentk)
        {
           
                
                tk = tentk;
                InitializeComponent();
                label1.Text = "Xin chào " + tentk ;
           

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
            
            FrmAccount f = new FrmAccount(tk);
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNguoiThue f = new FrmNguoiThue();
            f.Show();
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNguoiThue f = new FrmNguoiThue();
            f.Show();
        }
    }
}
