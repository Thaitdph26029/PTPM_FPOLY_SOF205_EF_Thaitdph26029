using _1.DAL.Repositories.Models;
using _2.BUS.IService;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QLKhachhang : Form
    {
        public IQLKhachhangService _iqLKhachhangService = new QLKhachhangService();
        public KhachHang khachHang;
        public KhachhangView KhachhangView= new KhachhangView();
        public Guid SelectID { get; set; }
        public QLKhachhang()
        {
            khachHang = new KhachHang();    
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            int i = 1;
            dtg_showkh.ColumnCount = 12;
            dtg_showkh.Columns[0].Name = "Số thứ tự";
            dtg_showkh.Columns[1].Name = "Id";
            dtg_showkh.Columns[1].Visible = false;
            dtg_showkh.Columns[2].Name = "Mã";
            dtg_showkh.Columns[3].Name = "Tên ";
            dtg_showkh.Columns[4].Name = "Tên đệm";
            dtg_showkh.Columns[5].Name = "Họ";
            dtg_showkh.Columns[6].Name = "Ngày sinh";
            dtg_showkh.Columns[7].Name = "Số điện thoại";
            dtg_showkh.Columns[8].Name = "Địa chỉ";
            dtg_showkh.Columns[9].Name = "Thành phố";
            dtg_showkh.Columns[10].Name = "Quốc gia";
            dtg_showkh.Columns[11].Name = "Mật khẩu";
            dtg_showkh.Rows.Clear();
            var lstkhachhang = _iqLKhachhangService.GetAllKhachHang();
            if (tb_timkiem.Text != "")
            {
                lstkhachhang = lstkhachhang.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())
                || x.TenDem.ToLower().Contains(tb_timkiem.Text.ToLower())
                || x.Ho.ToLower().Contains(tb_timkiem.Text.ToLower())
                || x.Sdt.ToLower().Contains(tb_timkiem.Text.ToLower())
                || x.DiaChi.ToLower().Contains(tb_timkiem.Text.ToLower())
                || x.ThanhPho.ToLower().Contains(tb_timkiem.Text.ToLower())
                || x.QuocGia.ToLower().Contains(tb_timkiem.Text.ToLower())
                || x.MatKhau.ToLower().Contains(tb_timkiem.Text.ToLower())                
                ).ToList();
            }
            //  var lstChucVu = _QLChucVuService.GetAllChucVu();
            foreach (var x in lstkhachhang)
            {
                dtg_showkh.Rows.Add(i++, x.Id, x.Ma, x.Ten,x.TenDem,x.Ho,x.NgaySinh,x.Sdt,x.DiaChi,x.ThanhPho,x.QuocGia,x.MatKhau);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_themkh_Click(object sender, EventArgs e)
        {
            if (tb_makh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng");
            }
            else if (_iqLKhachhangService.GetAllKhachHang().Any(x => x.Ma == tb_makh.Text))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }
            else
            {
                KhachhangView = new KhachhangView();
                KhachhangView.Id = new Guid();
                KhachhangView.Ma = tb_makh.Text;
                KhachhangView.Ten = tb_tenkh.Text;
                KhachhangView.TenDem = tb_tendemkh.Text;
                KhachhangView.Ho = tb_hokh.Text;
                KhachhangView.NgaySinh = Convert.ToDateTime(dtp_ngaysinh.Text);
                KhachhangView.Sdt = /*Convert.ToInt32*/(tb_sdtkh.Text);
                KhachhangView.DiaChi = tb_diachi.Text;
                KhachhangView.ThanhPho = tb_thanhpho.Text;
                KhachhangView.QuocGia = tb_quocgia.Text;
                KhachhangView.MatKhau = tb_matkhau.Text;                            
                MessageBox.Show(_iqLKhachhangService.addKhachHang(KhachhangView));
                loadData();             
            }
        }

        private void bt_suakh_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn Update khách hàng không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                KhachhangView = new KhachhangView();
                KhachhangView.Id = SelectID;
                KhachhangView.Ma = tb_makh.Text;
                KhachhangView.Ten = tb_tenkh.Text;
                KhachhangView.TenDem = tb_tendemkh.Text;
                KhachhangView.Ho = tb_hokh.Text;
                KhachhangView.NgaySinh = Convert.ToDateTime(dtp_ngaysinh.Text);
                KhachhangView.Sdt = /*Convert.ToInt32*/(tb_sdtkh.Text);
                KhachhangView.DiaChi = tb_diachi.Text;
                KhachhangView.ThanhPho = tb_thanhpho.Text;
                KhachhangView.QuocGia = tb_quocgia.Text;
                KhachhangView.MatKhau = tb_matkhau.Text;
                MessageBox.Show(_iqLKhachhangService.updateKhachHang(KhachhangView));
                loadData();
            }
        }

        private void dtg_showkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_makh.Text = dtg_showkh.CurrentRow.Cells[2].Value.ToString();
            tb_tenkh.Text = dtg_showkh.CurrentRow.Cells[3].Value.ToString();
            tb_tendemkh.Text = dtg_showkh.CurrentRow.Cells[4].Value.ToString();
            tb_hokh.Text = dtg_showkh.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaysinh.Text = dtg_showkh.CurrentRow.Cells[6].Value.ToString();
            tb_sdtkh.Text = dtg_showkh.CurrentRow.Cells[7].Value.ToString();
            tb_diachi.Text = dtg_showkh.CurrentRow.Cells[8].Value.ToString();
            tb_thanhpho.Text = dtg_showkh.CurrentRow.Cells[9].Value.ToString();
            tb_quocgia.Text = dtg_showkh.CurrentRow.Cells[10].Value.ToString();
            tb_matkhau.Text = dtg_showkh.CurrentRow.Cells[11].Value.ToString();
            SelectID = Guid.Parse(Convert.ToString(dtg_showkh.CurrentRow.Cells[1].Value));
        }

        private void bt_xoakh_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                KhachhangView = new KhachhangView();
                KhachhangView.Id = SelectID;
                
                MessageBox.Show(_iqLKhachhangService.deleteKhachHang(KhachhangView));
                loadData();
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtg_showkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
