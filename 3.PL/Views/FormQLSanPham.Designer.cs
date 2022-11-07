namespace _3.PL.Views
{
    partial class FormQLSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_showsanpham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_showhoadonct = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tienthua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_tienkhachdua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nhanvien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ngtao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mahd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.dtg_showhoadon = new System.Windows.Forms.DataGridView();
            this.btn_taohoadon = new System.Windows.Forms.Button();
            this.rd_chothanhtoan = new System.Windows.Forms.RadioButton();
            this.rd_tatca = new System.Windows.Forms.RadioButton();
            this.rd_dathanhtoan = new System.Windows.Forms.RadioButton();
            this.rd_dahuy = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsanpham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showhoadonct)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_showsanpham);
            this.groupBox1.Location = new System.Drawing.Point(101, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // dtg_showsanpham
            // 
            this.dtg_showsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showsanpham.Location = new System.Drawing.Point(35, 33);
            this.dtg_showsanpham.Name = "dtg_showsanpham";
            this.dtg_showsanpham.RowHeadersWidth = 51;
            this.dtg_showsanpham.RowTemplate.Height = 29;
            this.dtg_showsanpham.Size = new System.Drawing.Size(579, 126);
            this.dtg_showsanpham.TabIndex = 0;
            this.dtg_showsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showsanpham_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_showhoadonct);
            this.groupBox2.Location = new System.Drawing.Point(101, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // dtg_showhoadonct
            // 
            this.dtg_showhoadonct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showhoadonct.Location = new System.Drawing.Point(35, 39);
            this.dtg_showhoadonct.Name = "dtg_showhoadonct";
            this.dtg_showhoadonct.RowHeadersWidth = 51;
            this.dtg_showhoadonct.RowTemplate.Height = 29;
            this.dtg_showhoadonct.Size = new System.Drawing.Size(579, 126);
            this.dtg_showhoadonct.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_tienthua);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tb_tienkhachdua);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_tongtien);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_nhanvien);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_ngtao);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_mahd);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_thanhtoan);
            this.groupBox3.Location = new System.Drawing.Point(919, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 473);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tiền khách đưa";
            // 
            // tb_tienthua
            // 
            this.tb_tienthua.Location = new System.Drawing.Point(137, 343);
            this.tb_tienthua.Name = "tb_tienthua";
            this.tb_tienthua.Size = new System.Drawing.Size(234, 27);
            this.tb_tienthua.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tiền thừa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "label9";
            // 
            // tb_tienkhachdua
            // 
            this.tb_tienkhachdua.Location = new System.Drawing.Point(137, 281);
            this.tb_tienkhachdua.Name = "tb_tienkhachdua";
            this.tb_tienkhachdua.Size = new System.Drawing.Size(234, 27);
            this.tb_tienkhachdua.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên NV";
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Location = new System.Drawing.Point(137, 224);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.Size = new System.Drawing.Size(234, 27);
            this.tb_tongtien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // tb_nhanvien
            // 
            this.tb_nhanvien.Location = new System.Drawing.Point(137, 162);
            this.tb_nhanvien.Name = "tb_nhanvien";
            this.tb_nhanvien.Size = new System.Drawing.Size(234, 27);
            this.tb_nhanvien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày tạo";
            // 
            // tb_ngtao
            // 
            this.tb_ngtao.Location = new System.Drawing.Point(137, 111);
            this.tb_ngtao.Name = "tb_ngtao";
            this.tb_ngtao.Size = new System.Drawing.Size(234, 27);
            this.tb_ngtao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // tb_mahd
            // 
            this.tb_mahd.Location = new System.Drawing.Point(137, 49);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.Size = new System.Drawing.Size(234, 27);
            this.tb_mahd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã HD";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(137, 402);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(113, 29);
            this.btn_thanhtoan.TabIndex = 0;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // dtg_showhoadon
            // 
            this.dtg_showhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showhoadon.Location = new System.Drawing.Point(302, 78);
            this.dtg_showhoadon.Name = "dtg_showhoadon";
            this.dtg_showhoadon.RowHeadersWidth = 51;
            this.dtg_showhoadon.RowTemplate.Height = 29;
            this.dtg_showhoadon.Size = new System.Drawing.Size(565, 126);
            this.dtg_showhoadon.TabIndex = 2;
            // 
            // btn_taohoadon
            // 
            this.btn_taohoadon.Location = new System.Drawing.Point(53, 85);
            this.btn_taohoadon.Name = "btn_taohoadon";
            this.btn_taohoadon.Size = new System.Drawing.Size(147, 50);
            this.btn_taohoadon.TabIndex = 3;
            this.btn_taohoadon.Text = "Tạo hóa đơn";
            this.btn_taohoadon.UseVisualStyleBackColor = true;
            // 
            // rd_chothanhtoan
            // 
            this.rd_chothanhtoan.AutoSize = true;
            this.rd_chothanhtoan.Location = new System.Drawing.Point(302, 24);
            this.rd_chothanhtoan.Name = "rd_chothanhtoan";
            this.rd_chothanhtoan.Size = new System.Drawing.Size(131, 24);
            this.rd_chothanhtoan.TabIndex = 4;
            this.rd_chothanhtoan.TabStop = true;
            this.rd_chothanhtoan.Text = "Chờ thanh toán";
            this.rd_chothanhtoan.UseVisualStyleBackColor = true;
            // 
            // rd_tatca
            // 
            this.rd_tatca.AutoSize = true;
            this.rd_tatca.Location = new System.Drawing.Point(454, 24);
            this.rd_tatca.Name = "rd_tatca";
            this.rd_tatca.Size = new System.Drawing.Size(70, 24);
            this.rd_tatca.TabIndex = 5;
            this.rd_tatca.TabStop = true;
            this.rd_tatca.Text = "Tất cả";
            this.rd_tatca.UseVisualStyleBackColor = true;
            // 
            // rd_dathanhtoan
            // 
            this.rd_dathanhtoan.AutoSize = true;
            this.rd_dathanhtoan.Location = new System.Drawing.Point(750, 24);
            this.rd_dathanhtoan.Name = "rd_dathanhtoan";
            this.rd_dathanhtoan.Size = new System.Drawing.Size(124, 24);
            this.rd_dathanhtoan.TabIndex = 7;
            this.rd_dathanhtoan.TabStop = true;
            this.rd_dathanhtoan.Text = "Đã thanh toán";
            this.rd_dathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rd_dahuy
            // 
            this.rd_dahuy.AutoSize = true;
            this.rd_dahuy.Location = new System.Drawing.Point(598, 24);
            this.rd_dahuy.Name = "rd_dahuy";
            this.rd_dahuy.Size = new System.Drawing.Size(76, 24);
            this.rd_dahuy.TabIndex = 6;
            this.rd_dahuy.TabStop = true;
            this.rd_dahuy.Text = "Đã hủy";
            this.rd_dahuy.UseVisualStyleBackColor = true;
            // 
            // FormQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 660);
            this.Controls.Add(this.rd_dathanhtoan);
            this.Controls.Add(this.rd_dahuy);
            this.Controls.Add(this.rd_tatca);
            this.Controls.Add(this.rd_chothanhtoan);
            this.Controls.Add(this.btn_taohoadon);
            this.Controls.Add(this.dtg_showhoadon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLSanPham";
            this.Text = "FormQLSanPham";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsanpham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showhoadonct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_showsanpham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_showhoadonct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ngtao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mahd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.DataGridView dtg_showhoadon;
        private System.Windows.Forms.Button btn_taohoadon;
        private System.Windows.Forms.RadioButton rd_chothanhtoan;
        private System.Windows.Forms.RadioButton rd_tatca;
        private System.Windows.Forms.RadioButton rd_dathanhtoan;
        private System.Windows.Forms.RadioButton rd_dahuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tienthua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_tienkhachdua;
    }
}