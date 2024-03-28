using QLTro.controllers;
using QLTro.models;
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
    public partial class FrmGiaDienNuoc : Form
    {
        public FrmGiaDienNuoc()
        {
            InitializeComponent();
            LoadTextBoxes();
        }
        Controls ctr = new controllers.Controls();
        private bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        private void LoadTextBoxes()
        {
            DataTable dt = ctr.LoadDataTable("vw_GiaDienNuoc");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txt_giadiencu.Text = row["GiaDien"].ToString();
                txt_gianuoccu.Text = row["GiaNuoc"].ToString();
                if (DateTime.TryParse(row["NgayApDung"].ToString(), out DateTime ngayApDung))
                {
                    dt_ngayapdungcu.Value = ngayApDung;
                }
                else
                {
                    dt_ngayapdungcu.Value = DateTime.Today;
                }
            }
            else
            {
                txt_giadiencu.Text = "";
                txt_gianuoccu.Text = "";
                dt_ngayapdungcu.Value = DateTime.Today;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        GiaDienNuoc gdn;
        private void btn_confrim_Click(object sender, EventArgs e)
        {
            Controls ctr = new controllers.Controls();
            gdn = new GiaDienNuoc();
            if (IsEmpty(txt_giadienmoi.Text) || IsEmpty(txt_gianuocmoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int giaDien;
                if (int.TryParse(txt_giadienmoi.Text, out giaDien))
                {
                    gdn.Giadien = giaDien;
                }
                else
                {                    
                    MessageBox.Show("Giá điện mới không hợp lệ. Vui lòng nhập một số nguyên.");
                }
                int giaNuoc;
                if (int.TryParse(txt_gianuocmoi.Text, out giaNuoc))
                {
                    gdn.Gianuoc = giaNuoc;
                }
                else
                {
                    MessageBox.Show("Giá nước mới không hợp lệ. Vui lòng nhập một số nguyên.");
                }

                gdn.Ngayapdung = DateTime.Now;
                ctr.GiaDienNuoc(gdn.Giadien,gdn.Gianuoc,gdn.Ngayapdung ,gdn.Trangthai, "INSERT");
                ctr.Disconnect();
                MessageBox.Show("Thêm mới thành công !!");
                TextBox[] textBoxes = { txt_giadienmoi, txt_gianuocmoi };
                foreach (TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                }
                LoadTextBoxes();
            }
        }
    }
}
