namespace _3.PL.Views
{
    partial class QLMauSac
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
            this.dtg_showmau = new System.Windows.Forms.DataGridView();
            this.bt_themmau = new System.Windows.Forms.Button();
            this.bt_suamau = new System.Windows.Forms.Button();
            this.bt_xoamau = new System.Windows.Forms.Button();
            this.tb_mamau = new System.Windows.Forms.TextBox();
            this.tb_tenmau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showmau)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_showmau
            // 
            this.dtg_showmau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showmau.Location = new System.Drawing.Point(44, 268);
            this.dtg_showmau.Name = "dtg_showmau";
            this.dtg_showmau.RowHeadersWidth = 51;
            this.dtg_showmau.RowTemplate.Height = 29;
            this.dtg_showmau.Size = new System.Drawing.Size(371, 159);
            this.dtg_showmau.TabIndex = 0;
            this.dtg_showmau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showmau_CellClick);
            // 
            // bt_themmau
            // 
            this.bt_themmau.Location = new System.Drawing.Point(54, 12);
            this.bt_themmau.Name = "bt_themmau";
            this.bt_themmau.Size = new System.Drawing.Size(165, 44);
            this.bt_themmau.TabIndex = 1;
            this.bt_themmau.Text = "Thêm màu";
            this.bt_themmau.UseVisualStyleBackColor = true;
            this.bt_themmau.Click += new System.EventHandler(this.bt_themmau_Click);
            // 
            // bt_suamau
            // 
            this.bt_suamau.Location = new System.Drawing.Point(54, 89);
            this.bt_suamau.Name = "bt_suamau";
            this.bt_suamau.Size = new System.Drawing.Size(165, 44);
            this.bt_suamau.TabIndex = 2;
            this.bt_suamau.Text = "Sửa màu";
            this.bt_suamau.UseVisualStyleBackColor = true;
            this.bt_suamau.Click += new System.EventHandler(this.bt_suamau_Click);
            // 
            // bt_xoamau
            // 
            this.bt_xoamau.Location = new System.Drawing.Point(54, 169);
            this.bt_xoamau.Name = "bt_xoamau";
            this.bt_xoamau.Size = new System.Drawing.Size(165, 44);
            this.bt_xoamau.TabIndex = 3;
            this.bt_xoamau.Text = "Xóa màu";
            this.bt_xoamau.UseVisualStyleBackColor = true;
            this.bt_xoamau.Click += new System.EventHandler(this.bt_xoamau_Click);
            // 
            // tb_mamau
            // 
            this.tb_mamau.Location = new System.Drawing.Point(336, 29);
            this.tb_mamau.Name = "tb_mamau";
            this.tb_mamau.Size = new System.Drawing.Size(234, 27);
            this.tb_mamau.TabIndex = 4;
            // 
            // tb_tenmau
            // 
            this.tb_tenmau.Location = new System.Drawing.Point(335, 87);
            this.tb_tenmau.Name = "tb_tenmau";
            this.tb_tenmau.Size = new System.Drawing.Size(234, 27);
            this.tb_tenmau.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã màu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên màu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(401, 186);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(234, 27);
            this.tb_timkiem.TabIndex = 8;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // QLMauSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tenmau);
            this.Controls.Add(this.tb_mamau);
            this.Controls.Add(this.bt_xoamau);
            this.Controls.Add(this.bt_suamau);
            this.Controls.Add(this.bt_themmau);
            this.Controls.Add(this.dtg_showmau);
            this.Name = "QLMauSac";
            this.Text = "QLMauSac";
            this.Load += new System.EventHandler(this.QLMauSac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showmau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_showmau;
        private System.Windows.Forms.Button bt_themmau;
        private System.Windows.Forms.Button bt_suamau;
        private System.Windows.Forms.Button bt_xoamau;
        private System.Windows.Forms.TextBox tb_mamau;
        private System.Windows.Forms.TextBox tb_tenmau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_timkiem;
    }
}