namespace QLTro.views
{
    partial class FrmPhong
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
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_nguoithue = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_manguoithue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoithue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(1293, 32);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(140, 40);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1476, 373);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach Phong";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(355, 36);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(300, 27);
            this.txt_timkiem.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_nguoithue);
            this.panel1.Location = new System.Drawing.Point(6, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 280);
            this.panel1.TabIndex = 3;
            // 
            // dgv_nguoithue
            // 
            this.dgv_nguoithue.AllowUserToAddRows = false;
            this.dgv_nguoithue.AllowUserToDeleteRows = false;
            this.dgv_nguoithue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nguoithue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoithue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nguoithue.Location = new System.Drawing.Point(0, 0);
            this.dgv_nguoithue.Name = "dgv_nguoithue";
            this.dgv_nguoithue.ReadOnly = true;
            this.dgv_nguoithue.RowHeadersVisible = false;
            this.dgv_nguoithue.RowHeadersWidth = 51;
            this.dgv_nguoithue.RowTemplate.Height = 24;
            this.dgv_nguoithue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nguoithue.Size = new System.Drawing.Size(1464, 280);
            this.dgv_nguoithue.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.AutoSize = true;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(806, 33);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(87, 30);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(687, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 30);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm ";
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dc.Location = new System.Drawing.Point(934, 92);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(496, 27);
            this.txt_dc.TabIndex = 1;
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trangthai.Location = new System.Drawing.Point(934, 158);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.ReadOnly = true;
            this.txt_trangthai.Size = new System.Drawing.Size(168, 27);
            this.txt_trangthai.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(794, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái:";
            // 
            // txt_manguoithue
            // 
            this.txt_manguoithue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manguoithue.Location = new System.Drawing.Point(201, 92);
            this.txt_manguoithue.Name = "txt_manguoithue";
            this.txt_manguoithue.Size = new System.Drawing.Size(168, 27);
            this.txt_manguoithue.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Phòng:";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(201, 158);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(496, 27);
            this.txt_hoten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diện Tích:";
            // 
            // btn_them
            // 
            this.btn_them.AutoSize = true;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(365, 32);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(140, 40);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(48, 32);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(140, 40);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 749);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1476, 101);
            this.panel3.TabIndex = 3;
            // 
            // btn_sua
            // 
            this.btn_sua.AutoSize = true;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(204, 32);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(140, 40);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(794, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Thuê (VNĐ):";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_dc);
            this.panel4.Controls.Add(this.txt_trangthai);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_manguoithue);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txt_hoten);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(6, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1473, 346);
            this.panel4.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1482, 853);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quan ly Phong";
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phong";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoithue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_nguoithue;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_manguoithue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}