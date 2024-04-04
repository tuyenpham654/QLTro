namespace QLTro.views
{
    partial class FrmSearchPhongTro
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
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_searchphong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchphong)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(476, 93);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(300, 27);
            this.txt_timkiem.TabIndex = 4;
            // 
            // btn_refresh
            // 
            this.btn_refresh.AutoSize = true;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(927, 90);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(87, 30);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(808, 91);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 30);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm ";
            // 
            // dgv_searchphong
            // 
            this.dgv_searchphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_searchphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchphong.Location = new System.Drawing.Point(3, 155);
            this.dgv_searchphong.Name = "dgv_searchphong";
            this.dgv_searchphong.RowHeadersWidth = 51;
            this.dgv_searchphong.RowTemplate.Height = 24;
            this.dgv_searchphong.Size = new System.Drawing.Size(1500, 500);
            this.dgv_searchphong.TabIndex = 7;
            this.dgv_searchphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_searchphong_CellContentClick);
            this.dgv_searchphong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_searchphong_CellContentClick);
            // 
            // FrmSearchPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.dgv_searchphong);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Name = "FrmSearchPhongTro";
            this.Text = "FrmSearchPhongTro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_searchphong;
    }
}