namespace _3.PL.Views
{
    partial class QLSanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.bt_xoasp = new System.Windows.Forms.Button();
            this.bt_suasp = new System.Windows.Forms.Button();
            this.bt_themsp = new System.Windows.Forms.Button();
            this.dtg_showsp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsp)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(462, 192);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(234, 27);
            this.tb_timkiem.TabIndex = 18;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã sản phẩm";
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(416, 89);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(234, 27);
            this.tb_tensp.TabIndex = 15;
            // 
            // tb_masp
            // 
            this.tb_masp.Location = new System.Drawing.Point(416, 35);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Size = new System.Drawing.Size(234, 27);
            this.tb_masp.TabIndex = 14;
            // 
            // bt_xoasp
            // 
            this.bt_xoasp.Location = new System.Drawing.Point(115, 175);
            this.bt_xoasp.Name = "bt_xoasp";
            this.bt_xoasp.Size = new System.Drawing.Size(165, 44);
            this.bt_xoasp.TabIndex = 13;
            this.bt_xoasp.Text = "Xóa sản phẩm";
            this.bt_xoasp.UseVisualStyleBackColor = true;
            this.bt_xoasp.Click += new System.EventHandler(this.bt_xoasp_Click);
            // 
            // bt_suasp
            // 
            this.bt_suasp.Location = new System.Drawing.Point(115, 95);
            this.bt_suasp.Name = "bt_suasp";
            this.bt_suasp.Size = new System.Drawing.Size(165, 44);
            this.bt_suasp.TabIndex = 12;
            this.bt_suasp.Text = "Sửa sản phẩm";
            this.bt_suasp.UseVisualStyleBackColor = true;
            this.bt_suasp.Click += new System.EventHandler(this.bt_suasp_Click);
            // 
            // bt_themsp
            // 
            this.bt_themsp.Location = new System.Drawing.Point(115, 18);
            this.bt_themsp.Name = "bt_themsp";
            this.bt_themsp.Size = new System.Drawing.Size(165, 44);
            this.bt_themsp.TabIndex = 11;
            this.bt_themsp.Text = "Thêm sản phẩm";
            this.bt_themsp.UseVisualStyleBackColor = true;
            this.bt_themsp.Click += new System.EventHandler(this.bt_themsp_Click);
            // 
            // dtg_showsp
            // 
            this.dtg_showsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showsp.Location = new System.Drawing.Point(105, 274);
            this.dtg_showsp.Name = "dtg_showsp";
            this.dtg_showsp.RowHeadersWidth = 51;
            this.dtg_showsp.RowTemplate.Height = 29;
            this.dtg_showsp.Size = new System.Drawing.Size(371, 159);
            this.dtg_showsp.TabIndex = 10;
            this.dtg_showsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showsp_CellClick);
            // 
            // QLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tensp);
            this.Controls.Add(this.tb_masp);
            this.Controls.Add(this.bt_xoasp);
            this.Controls.Add(this.bt_suasp);
            this.Controls.Add(this.bt_themsp);
            this.Controls.Add(this.dtg_showsp);
            this.Name = "QLSanPham";
            this.Text = "QLSanPham";
            this.Load += new System.EventHandler(this.QLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tensp;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Button bt_xoasp;
        private System.Windows.Forms.Button bt_suasp;
        private System.Windows.Forms.Button bt_themsp;
        private System.Windows.Forms.DataGridView dtg_showsp;
    }
}