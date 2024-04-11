namespace QLTro
{
    partial class FrmManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kinhDoanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáĐiệnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_quahan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lịchSửHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quahan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.kinhDoanhToolStripMenuItem,
            this.traCứuToolStripMenuItem,
            this.tùyChỉnhToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống ";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.phòngToolStripMenuItem.Text = "Phòng Trọ";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Thuê";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // kinhDoanhToolStripMenuItem
            // 
            this.kinhDoanhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hợpĐồngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.kinhDoanhToolStripMenuItem.Name = "kinhDoanhToolStripMenuItem";
            this.kinhDoanhToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.kinhDoanhToolStripMenuItem.Text = "Kinh Doanh";
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp Đồng";
            this.hợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngToolStripMenuItem1,
            this.kháchToolStripMenuItem,
            this.lịchSửHóaĐơnToolStripMenuItem});
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.traCứuToolStripMenuItem.Text = "Tra cứu";
            // 
            // phòngToolStripMenuItem1
            // 
            this.phòngToolStripMenuItem1.Name = "phòngToolStripMenuItem1";
            this.phòngToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.phòngToolStripMenuItem1.Text = "Phòng";
            this.phòngToolStripMenuItem1.Click += new System.EventHandler(this.phòngToolStripMenuItem1_Click);
            // 
            // kháchToolStripMenuItem
            // 
            this.kháchToolStripMenuItem.Name = "kháchToolStripMenuItem";
            this.kháchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchToolStripMenuItem.Text = "Khách";
            this.kháchToolStripMenuItem.Click += new System.EventHandler(this.kháchToolStripMenuItem_Click);
            // 
            // tùyChỉnhToolStripMenuItem
            // 
            this.tùyChỉnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giáĐiệnNướcToolStripMenuItem});
            this.tùyChỉnhToolStripMenuItem.Name = "tùyChỉnhToolStripMenuItem";
            this.tùyChỉnhToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.tùyChỉnhToolStripMenuItem.Text = "Tùy Chỉnh ";
            // 
            // giáĐiệnNướcToolStripMenuItem
            // 
            this.giáĐiệnNướcToolStripMenuItem.Name = "giáĐiệnNướcToolStripMenuItem";
            this.giáĐiệnNướcToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.giáĐiệnNướcToolStripMenuItem.Text = "Giá Điện/Nước";
            this.giáĐiệnNướcToolStripMenuItem.Click += new System.EventHandler(this.giáĐiệnNướcToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giớiThiệuToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.giớiThiệuToolStripMenuItem.Text = "Giới Thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào";
            // 
            // dgv_quahan
            // 
            this.dgv_quahan.AllowUserToAddRows = false;
            this.dgv_quahan.AllowUserToDeleteRows = false;
            this.dgv_quahan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_quahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quahan.Location = new System.Drawing.Point(6, 21);
            this.dgv_quahan.Name = "dgv_quahan";
            this.dgv_quahan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_quahan.RowHeadersWidth = 51;
            this.dgv_quahan.RowTemplate.Height = 24;
            this.dgv_quahan.Size = new System.Drawing.Size(240, 516);
            this.dgv_quahan.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgv_quahan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(252, 546);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Sách Quá Hạn";
            // 
            // lịchSửHóaĐơnToolStripMenuItem
            // 
            this.lịchSửHóaĐơnToolStripMenuItem.Name = "lịchSửHóaĐơnToolStripMenuItem";
            this.lịchSửHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lịchSửHóaĐơnToolStripMenuItem.Text = "Lịch Sử Hóa Đơn";
            this.lịchSửHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.lịchSửHóaĐơnToolStripMenuItem_Click);
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmQuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quahan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kinhDoanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáĐiệnNướcToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_quahan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem lịchSửHóaĐơnToolStripMenuItem;
    }
}