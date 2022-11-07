namespace _3.PL.Views
{
    partial class QLDongSp
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
            this.tb_tendong = new System.Windows.Forms.TextBox();
            this.tb_madong = new System.Windows.Forms.TextBox();
            this.bt_xoadong = new System.Windows.Forms.Button();
            this.bt_suadong = new System.Windows.Forms.Button();
            this.bt_themdong = new System.Windows.Forms.Button();
            this.dtg_showdongsp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showdongsp)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên dòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã dòng";
            // 
            // tb_tendong
            // 
            this.tb_tendong.Location = new System.Drawing.Point(396, 93);
            this.tb_tendong.Name = "tb_tendong";
            this.tb_tendong.Size = new System.Drawing.Size(234, 27);
            this.tb_tendong.TabIndex = 15;
            // 
            // tb_madong
            // 
            this.tb_madong.Location = new System.Drawing.Point(397, 35);
            this.tb_madong.Name = "tb_madong";
            this.tb_madong.Size = new System.Drawing.Size(234, 27);
            this.tb_madong.TabIndex = 14;
            // 
            // bt_xoadong
            // 
            this.bt_xoadong.Location = new System.Drawing.Point(115, 175);
            this.bt_xoadong.Name = "bt_xoadong";
            this.bt_xoadong.Size = new System.Drawing.Size(165, 44);
            this.bt_xoadong.TabIndex = 13;
            this.bt_xoadong.Text = "Xóa dòng sản phẩm";
            this.bt_xoadong.UseVisualStyleBackColor = true;
            this.bt_xoadong.Click += new System.EventHandler(this.bt_xoadong_Click);
            // 
            // bt_suadong
            // 
            this.bt_suadong.Location = new System.Drawing.Point(115, 95);
            this.bt_suadong.Name = "bt_suadong";
            this.bt_suadong.Size = new System.Drawing.Size(165, 44);
            this.bt_suadong.TabIndex = 12;
            this.bt_suadong.Text = "Sửa dòng sản phẩm";
            this.bt_suadong.UseVisualStyleBackColor = true;
            this.bt_suadong.Click += new System.EventHandler(this.bt_suadong_Click);
            // 
            // bt_themdong
            // 
            this.bt_themdong.Location = new System.Drawing.Point(115, 18);
            this.bt_themdong.Name = "bt_themdong";
            this.bt_themdong.Size = new System.Drawing.Size(165, 44);
            this.bt_themdong.TabIndex = 11;
            this.bt_themdong.Text = "Thêm dòng sản phẩm";
            this.bt_themdong.UseVisualStyleBackColor = true;
            this.bt_themdong.Click += new System.EventHandler(this.bt_themdong_Click);
            // 
            // dtg_showdongsp
            // 
            this.dtg_showdongsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showdongsp.Location = new System.Drawing.Point(105, 274);
            this.dtg_showdongsp.Name = "dtg_showdongsp";
            this.dtg_showdongsp.RowHeadersWidth = 51;
            this.dtg_showdongsp.RowTemplate.Height = 29;
            this.dtg_showdongsp.Size = new System.Drawing.Size(477, 159);
            this.dtg_showdongsp.TabIndex = 10;
            this.dtg_showdongsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showdongsp_CellClick);
            this.dtg_showdongsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showdongsp_CellContentClick);
            // 
            // QLDongSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tendong);
            this.Controls.Add(this.tb_madong);
            this.Controls.Add(this.bt_xoadong);
            this.Controls.Add(this.bt_suadong);
            this.Controls.Add(this.bt_themdong);
            this.Controls.Add(this.dtg_showdongsp);
            this.Name = "QLDongSp";
            this.Text = "QLDongSp";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showdongsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tendong;
        private System.Windows.Forms.TextBox tb_madong;
        private System.Windows.Forms.Button bt_xoadong;
        private System.Windows.Forms.Button bt_suadong;
        private System.Windows.Forms.Button bt_themdong;
        private System.Windows.Forms.DataGridView dtg_showdongsp;
    }
}