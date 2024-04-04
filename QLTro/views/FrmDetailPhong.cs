using QLTro.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTro.views
{
    public partial class FrmDetailPhong : Form
    {
        Controls ctr = new controllers.Controls();
        public FrmDetailPhong(string ma)
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            DataTable dt = LoadDataTable("");

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
