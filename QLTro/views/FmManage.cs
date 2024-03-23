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
    public partial class FmManage : Form
    {
        public FmManage()
        {
            InitializeComponent();
        }
        private string tk;
        public FmManage(String tentk,String pass)
        {
            string tk = tentk;
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
            
            FmAccount f = new FmAccount(tk);
            f.Show();
        }
    }
}
