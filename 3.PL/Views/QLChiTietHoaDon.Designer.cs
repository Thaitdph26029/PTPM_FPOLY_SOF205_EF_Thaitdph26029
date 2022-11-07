namespace _3.PL.Views
{
    partial class QLChiTietHoaDon
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
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_chitietsp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.dtg_showhdct = new System.Windows.Forms.DataGridView();
            this.cbb_hoadon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenmau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_dongsp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_tennsx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showhdct)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(59, 60);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(240, 48);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(59, 149);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(240, 48);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(59, 237);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(240, 48);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(433, 123);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(276, 27);
            this.tb_soluong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng";
            // 
            // cbb_chitietsp
            // 
            this.cbb_chitietsp.FormattingEnabled = true;
            this.cbb_chitietsp.Location = new System.Drawing.Point(431, 55);
            this.cbb_chitietsp.Name = "cbb_chitietsp";
            this.cbb_chitietsp.Size = new System.Drawing.Size(278, 28);
            this.cbb_chitietsp.TabIndex = 8;
            this.cbb_chitietsp.SelectedIndexChanged += new System.EventHandler(this.cbb_chitietsp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đơn giá";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(435, 200);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(276, 27);
            this.tb_dongia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(682, 373);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(276, 27);
            this.tb_timkiem.TabIndex = 11;
            // 
            // dtg_showhdct
            // 
            this.dtg_showhdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showhdct.Location = new System.Drawing.Point(46, 425);
            this.dtg_showhdct.Name = "dtg_showhdct";
            this.dtg_showhdct.RowHeadersWidth = 51;
            this.dtg_showhdct.RowTemplate.Height = 29;
            this.dtg_showhdct.Size = new System.Drawing.Size(932, 248);
            this.dtg_showhdct.TabIndex = 13;
            this.dtg_showhdct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showhdct_CellClick);
            // 
            // cbb_hoadon
            // 
            this.cbb_hoadon.FormattingEnabled = true;
            this.cbb_hoadon.Location = new System.Drawing.Point(194, 372);
            this.cbb_hoadon.Name = "cbb_hoadon";
            this.cbb_hoadon.Size = new System.Drawing.Size(278, 28);
            this.cbb_hoadon.TabIndex = 15;
            this.cbb_hoadon.SelectedIndexChanged += new System.EventHandler(this.cbb_hoadon_SelectedIndexChanged);
            this.cbb_hoadon.SelectedValueChanged += new System.EventHandler(this.cbb_hoadon_SelectedValueChanged);
            this.cbb_hoadon.TextChanged += new System.EventHandler(this.cbb_hoadon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hóa đơn ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tên màu";
            // 
            // tb_tenmau
            // 
            this.tb_tenmau.Location = new System.Drawing.Point(883, 140);
            this.tb_tenmau.Name = "tb_tenmau";
            this.tb_tenmau.Size = new System.Drawing.Size(276, 27);
            this.tb_tenmau.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên sản phẩm";
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(881, 63);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(276, 27);
            this.tb_tensp.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(765, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tên dòng SP";
            // 
            // tb_dongsp
            // 
            this.tb_dongsp.Location = new System.Drawing.Point(885, 294);
            this.tb_dongsp.Name = "tb_dongsp";
            this.tb_dongsp.Size = new System.Drawing.Size(276, 27);
            this.tb_dongsp.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(763, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên nhà sản xuất";
            // 
            // tb_tennsx
            // 
            this.tb_tennsx.Location = new System.Drawing.Point(883, 217);
            this.tb_tennsx.Name = "tb_tennsx";
            this.tb_tennsx.Size = new System.Drawing.Size(276, 27);
            this.tb_tennsx.TabIndex = 20;
            // 
            // QLChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 699);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_dongsp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_tennsx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_tenmau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_tensp);
            this.Controls.Add(this.cbb_hoadon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_showhdct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_dongia);
            this.Controls.Add(this.cbb_chitietsp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Name = "QLChiTietHoaDon";
            this.Text = "QLChiTietHoaDon";
            this.Load += new System.EventHandler(this.QLChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showhdct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_chitietsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridView dtg_showhdct;
        private System.Windows.Forms.ComboBox cbb_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenmau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tensp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_dongsp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_tennsx;
    }
}