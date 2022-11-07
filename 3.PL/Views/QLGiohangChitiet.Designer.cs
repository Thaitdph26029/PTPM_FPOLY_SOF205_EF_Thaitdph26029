namespace _3.PL.Views
{
    partial class QLGiohangChitiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_sanpham = new System.Windows.Forms.ComboBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtg_showghct = new System.Windows.Forms.DataGridView();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.cbb_idgh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dongiakhigiam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showghct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // cbb_sanpham
            // 
            this.cbb_sanpham.FormattingEnabled = true;
            this.cbb_sanpham.Location = new System.Drawing.Point(547, 62);
            this.cbb_sanpham.Name = "cbb_sanpham";
            this.cbb_sanpham.Size = new System.Drawing.Size(275, 28);
            this.cbb_sanpham.TabIndex = 1;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(547, 124);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(275, 27);
            this.tb_soluong.TabIndex = 2;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(51, 62);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(282, 60);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dtg_showghct
            // 
            this.dtg_showghct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showghct.Location = new System.Drawing.Point(25, 404);
            this.dtg_showghct.Name = "dtg_showghct";
            this.dtg_showghct.RowHeadersWidth = 51;
            this.dtg_showghct.RowTemplate.Height = 29;
            this.dtg_showghct.Size = new System.Drawing.Size(976, 271);
            this.dtg_showghct.TabIndex = 4;
            this.dtg_showghct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showghct_CellClick);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(51, 138);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(282, 60);
            this.bt_sua.TabIndex = 5;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(51, 218);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(282, 60);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // cbb_idgh
            // 
            this.cbb_idgh.FormattingEnabled = true;
            this.cbb_idgh.Location = new System.Drawing.Point(169, 359);
            this.cbb_idgh.Name = "cbb_idgh";
            this.cbb_idgh.Size = new System.Drawing.Size(227, 28);
            this.cbb_idgh.TabIndex = 8;
            this.cbb_idgh.SelectedIndexChanged += new System.EventHandler(this.cbb_idgh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giỏ hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đơn giá";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(547, 193);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(275, 27);
            this.tb_dongia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đơn giá khi giảm";
            // 
            // tb_dongiakhigiam
            // 
            this.tb_dongiakhigiam.Location = new System.Drawing.Point(547, 268);
            this.tb_dongiakhigiam.Name = "tb_dongiakhigiam";
            this.tb_dongiakhigiam.Size = new System.Drawing.Size(275, 27);
            this.tb_dongiakhigiam.TabIndex = 12;
            // 
            // QLGiohangChitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 687);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_dongiakhigiam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_dongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_idgh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.dtg_showghct);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.cbb_sanpham);
            this.Controls.Add(this.label1);
            this.Name = "QLGiohangChitiet";
            this.Text = "QLGiohangChitiet";
            this.Load += new System.EventHandler(this.QLGiohangChitiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showghct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_sanpham;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtg_showghct;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.ComboBox cbb_idgh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dongiakhigiam;
    }
}