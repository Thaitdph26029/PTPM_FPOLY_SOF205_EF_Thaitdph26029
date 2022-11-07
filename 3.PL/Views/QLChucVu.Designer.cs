namespace _3.PL.Views
{
    partial class QLChucVu
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
            this.lb = new System.Windows.Forms.Label();
            this.tb_tenchucvu = new System.Windows.Forms.TextBox();
            this.tb_machucvu = new System.Windows.Forms.TextBox();
            this.bt_xoachucvu = new System.Windows.Forms.Button();
            this.bt_suachucvu = new System.Windows.Forms.Button();
            this.bt_themchucvu = new System.Windows.Forms.Button();
            this.dtg_showmau = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showmau)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên màu";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(312, 35);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(84, 20);
            this.lb.TabIndex = 16;
            this.lb.Text = "Mã chức vụ";
            // 
            // tb_tenchucvu
            // 
            this.tb_tenchucvu.Location = new System.Drawing.Point(404, 93);
            this.tb_tenchucvu.Name = "tb_tenchucvu";
            this.tb_tenchucvu.Size = new System.Drawing.Size(234, 27);
            this.tb_tenchucvu.TabIndex = 15;
            // 
            // tb_machucvu
            // 
            this.tb_machucvu.Location = new System.Drawing.Point(404, 32);
            this.tb_machucvu.Name = "tb_machucvu";
            this.tb_machucvu.Size = new System.Drawing.Size(234, 27);
            this.tb_machucvu.TabIndex = 14;
            // 
            // bt_xoachucvu
            // 
            this.bt_xoachucvu.Location = new System.Drawing.Point(115, 175);
            this.bt_xoachucvu.Name = "bt_xoachucvu";
            this.bt_xoachucvu.Size = new System.Drawing.Size(165, 44);
            this.bt_xoachucvu.TabIndex = 13;
            this.bt_xoachucvu.Text = "Xóa chức vụ";
            this.bt_xoachucvu.UseVisualStyleBackColor = true;
            this.bt_xoachucvu.Click += new System.EventHandler(this.bt_xoachucvu_Click);
            // 
            // bt_suachucvu
            // 
            this.bt_suachucvu.Location = new System.Drawing.Point(115, 95);
            this.bt_suachucvu.Name = "bt_suachucvu";
            this.bt_suachucvu.Size = new System.Drawing.Size(165, 44);
            this.bt_suachucvu.TabIndex = 12;
            this.bt_suachucvu.Text = "Sửa chức vụ";
            this.bt_suachucvu.UseVisualStyleBackColor = true;
            this.bt_suachucvu.Click += new System.EventHandler(this.bt_suachucvu_Click);
            // 
            // bt_themchucvu
            // 
            this.bt_themchucvu.Location = new System.Drawing.Point(115, 18);
            this.bt_themchucvu.Name = "bt_themchucvu";
            this.bt_themchucvu.Size = new System.Drawing.Size(165, 44);
            this.bt_themchucvu.TabIndex = 11;
            this.bt_themchucvu.Text = "Thêm chức vụ";
            this.bt_themchucvu.UseVisualStyleBackColor = true;
            this.bt_themchucvu.Click += new System.EventHandler(this.bt_themchucvu_Click);
            // 
            // dtg_showmau
            // 
            this.dtg_showmau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showmau.Location = new System.Drawing.Point(105, 274);
            this.dtg_showmau.Name = "dtg_showmau";
            this.dtg_showmau.RowHeadersWidth = 51;
            this.dtg_showmau.RowTemplate.Height = 29;
            this.dtg_showmau.Size = new System.Drawing.Size(371, 159);
            this.dtg_showmau.TabIndex = 10;
            this.dtg_showmau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showmau_CellClick);
            this.dtg_showmau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showmau_CellContentClick);
            // 
            // QLChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tb_tenchucvu);
            this.Controls.Add(this.tb_machucvu);
            this.Controls.Add(this.bt_xoachucvu);
            this.Controls.Add(this.bt_suachucvu);
            this.Controls.Add(this.bt_themchucvu);
            this.Controls.Add(this.dtg_showmau);
            this.Name = "QLChucVu";
            this.Text = "QLChucVu";
            this.Load += new System.EventHandler(this.QLChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showmau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tb_tenchucvu;
        private System.Windows.Forms.TextBox tb_machucvu;
        private System.Windows.Forms.Button bt_xoachucvu;
        private System.Windows.Forms.Button bt_suachucvu;
        private System.Windows.Forms.Button bt_themchucvu;
        private System.Windows.Forms.DataGridView dtg_showmau;
    }
}