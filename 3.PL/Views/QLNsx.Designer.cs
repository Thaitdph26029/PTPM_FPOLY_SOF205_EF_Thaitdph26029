namespace _3.PL.Views
{
    partial class QLNsx
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
            this.tb_tenNsx = new System.Windows.Forms.TextBox();
            this.tb_maNsx = new System.Windows.Forms.TextBox();
            this.bt_xoamau = new System.Windows.Forms.Button();
            this.bt_suamau = new System.Windows.Forms.Button();
            this.bt_themmau = new System.Windows.Forms.Button();
            this.dtg_showNsx = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showNsx)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(511, 212);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(234, 27);
            this.tb_timkiem.TabIndex = 18;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên Nsx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Nsx";
            // 
            // tb_tenNsx
            // 
            this.tb_tenNsx.Location = new System.Drawing.Point(445, 113);
            this.tb_tenNsx.Name = "tb_tenNsx";
            this.tb_tenNsx.Size = new System.Drawing.Size(234, 27);
            this.tb_tenNsx.TabIndex = 15;
            // 
            // tb_maNsx
            // 
            this.tb_maNsx.Location = new System.Drawing.Point(446, 55);
            this.tb_maNsx.Name = "tb_maNsx";
            this.tb_maNsx.Size = new System.Drawing.Size(234, 27);
            this.tb_maNsx.TabIndex = 14;
            // 
            // bt_xoamau
            // 
            this.bt_xoamau.Location = new System.Drawing.Point(164, 195);
            this.bt_xoamau.Name = "bt_xoamau";
            this.bt_xoamau.Size = new System.Drawing.Size(165, 44);
            this.bt_xoamau.TabIndex = 13;
            this.bt_xoamau.Text = "Xóa Nsx";
            this.bt_xoamau.UseVisualStyleBackColor = true;
            this.bt_xoamau.Click += new System.EventHandler(this.bt_xoamau_Click);
            // 
            // bt_suamau
            // 
            this.bt_suamau.Location = new System.Drawing.Point(164, 115);
            this.bt_suamau.Name = "bt_suamau";
            this.bt_suamau.Size = new System.Drawing.Size(165, 44);
            this.bt_suamau.TabIndex = 12;
            this.bt_suamau.Text = "Sửa Nsx";
            this.bt_suamau.UseVisualStyleBackColor = true;
            this.bt_suamau.Click += new System.EventHandler(this.bt_suamau_Click);
            // 
            // bt_themmau
            // 
            this.bt_themmau.Location = new System.Drawing.Point(164, 38);
            this.bt_themmau.Name = "bt_themmau";
            this.bt_themmau.Size = new System.Drawing.Size(165, 44);
            this.bt_themmau.TabIndex = 11;
            this.bt_themmau.Text = "Thêm Nsx";
            this.bt_themmau.UseVisualStyleBackColor = true;
            this.bt_themmau.Click += new System.EventHandler(this.bt_themmau_Click);
            // 
            // dtg_showNsx
            // 
            this.dtg_showNsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showNsx.Location = new System.Drawing.Point(154, 294);
            this.dtg_showNsx.Name = "dtg_showNsx";
            this.dtg_showNsx.RowHeadersWidth = 51;
            this.dtg_showNsx.RowTemplate.Height = 29;
            this.dtg_showNsx.Size = new System.Drawing.Size(371, 159);
            this.dtg_showNsx.TabIndex = 10;
            this.dtg_showNsx.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showNsx_CellClick);
            this.dtg_showNsx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showNsx_CellContentClick);
            // 
            // QLNsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tenNsx);
            this.Controls.Add(this.tb_maNsx);
            this.Controls.Add(this.bt_xoamau);
            this.Controls.Add(this.bt_suamau);
            this.Controls.Add(this.bt_themmau);
            this.Controls.Add(this.dtg_showNsx);
            this.Name = "QLNsx";
            this.Text = "QLNsx";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showNsx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tenNsx;
        private System.Windows.Forms.TextBox tb_maNsx;
        private System.Windows.Forms.Button bt_xoamau;
        private System.Windows.Forms.Button bt_suamau;
        private System.Windows.Forms.Button bt_themmau;
        private System.Windows.Forms.DataGridView dtg_showNsx;
    }
}