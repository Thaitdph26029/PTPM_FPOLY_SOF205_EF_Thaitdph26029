using _1.DAL.IRepositories;
using _1.DAL.Repositories;
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
    public partial class QLHoaDon : Form
    {
        private IQLHoaDonService _iqLHoaDonService = new QLHoaDonService();
        private IQLNhanvienService _iqLNhanvienService = new QLNhanvienService();
        private IQLKhachhangService _iqKhachhangService = new QLKhachhangService();
        private HoaDonView _hoaDonView;
        public Guid SelectID { get; set; }
        public QLHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            int i = 1;

            dtg_showhoadon.ColumnCount = 13;
            dtg_showhoadon.Columns[0].Name = "Stt";
            dtg_showhoadon.Columns[1].Name = "ID";
            dtg_showhoadon.Columns[1].Visible = false;
            dtg_showhoadon.Columns[2].Name = "Khách hàng";
            dtg_showhoadon.Columns[3].Name = "Nhân viên";
            dtg_showhoadon.Columns[4].Name = "Mã hóa đơn";
            dtg_showhoadon.Columns[5].Name = "Ngày tạo";
            dtg_showhoadon.Columns[6].Name = "Ngày thanh toán";
            dtg_showhoadon.Columns[7].Name = "Ngày ship";
            dtg_showhoadon.Columns[8].Name = "Ngày nhận";
            dtg_showhoadon.Columns[9].Name = "Tình trạng";
            dtg_showhoadon.Columns[10].Name = "Tên người nhận";
            dtg_showhoadon.Columns[11].Name = "Địa chỉ";
            dtg_showhoadon.Columns[12].Name = "Số điện thoại";
            dtg_showhoadon.Rows.Clear();
            foreach (var x in _iqLHoaDonService.GetAllHoadon())
            {
                dtg_showhoadon.Rows.Add(i++, x.Id, x.TenKh, x.TenNv, x.Ma, x.NgayTao, x.NgayThanhToan, x.NgayShip, x.NgayNhan, x.TinhTrang, x.TenNguoiNhan, x.DiaChi, x.Sdt);
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            foreach (var x in _iqKhachhangService.GetAllKhachHang())
            {
                cbb_makh.Items.Add(x.Ten);
            }
            foreach (var x in _iqLNhanvienService.GetAllNhanvien())
            {
                cbb_manv.Items.Add(x.Ten);
            }
            cbb_makh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_manv.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int a;
            if (rd_dagiao.Checked == true)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
            _hoaDonView = new HoaDonView()            
            {
                Id = Guid.NewGuid(),
                IdKh = _iqKhachhangService.GetAllKhachHang().Where(c => c.Ten == Convert.ToString(cbb_makh.Text)).Select(c => c.Id).FirstOrDefault(),
                IdNv = _iqLNhanvienService.GetAllNhanvien().Where(c => c.Ten == Convert.ToString(cbb_manv.Text)).Select(c => c.Id).FirstOrDefault(),
                Ma = tb_mahd.Text,
                NgayTao = Convert.ToDateTime(dtp_ngaytao.Text),
                NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Text),
                NgayShip = Convert.ToDateTime(dtp_ngayship.Text),
                NgayNhan = Convert.ToDateTime(stp_ngaynhan.Text),
                TinhTrang = a,
                TenNguoiNhan = tb_tennguoinhan.Text,
                DiaChi = tb_diachi.Text,
                Sdt = tb_sodienthoai.Text,
            };
            MessageBox.Show(_iqLHoaDonService.AddHoadon(_hoaDonView));
            LoadData();
        }

        private void dtg_showhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_makh.SelectedItem = dtg_showhoadon.CurrentRow.Cells[2].Value.ToString();
            cbb_manv.SelectedItem = dtg_showhoadon.CurrentRow.Cells[3].Value.ToString();
            tb_mahd.Text = dtg_showhoadon.CurrentRow.Cells[4].Value.ToString();
            dtp_ngaytao.Value = Convert.ToDateTime(dtg_showhoadon.CurrentRow.Cells[5].Value.ToString());
            dtp_ngaythanhtoan.Value = Convert.ToDateTime(dtg_showhoadon.CurrentRow.Cells[6].Value.ToString());
            dtp_ngayship.Value = Convert.ToDateTime(dtg_showhoadon.CurrentRow.Cells[7].Value.ToString());
            stp_ngaynhan.Value = Convert.ToDateTime(dtg_showhoadon.CurrentRow.Cells[8].Value.ToString());
            if (Convert.ToInt32(dtg_showhoadon.CurrentRow.Cells[9].Value.ToString()) == 1) 
            {
                rd_dagiao.Checked = true;
            }
            else
            {
                rd_chuagiao.Checked = true;
            }    
            tb_tennguoinhan.Text = dtg_showhoadon.CurrentRow.Cells[10].Value.ToString();
            tb_diachi.Text = dtg_showhoadon.CurrentRow.Cells[11].Value.ToString();
            tb_sodienthoai.Text = dtg_showhoadon.CurrentRow.Cells[12].Value.ToString();
            SelectID = Guid.Parse(dtg_showhoadon.CurrentRow.Cells[1].Value.ToString());
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            int a;
            if (rd_dagiao.Checked == true)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
            _hoaDonView = new HoaDonView()           
            {
                Id = SelectID,
                IdKh = _iqKhachhangService.GetAllKhachHang().Where(c => c.Ten == Convert.ToString(cbb_makh.Text)).Select(c => c.Id).FirstOrDefault(),
                IdNv = _iqLNhanvienService.GetAllNhanvien().Where(c => c.Ten == Convert.ToString(cbb_manv.Text)).Select(c => c.Id).FirstOrDefault(),
                Ma = tb_mahd.Text,
                NgayTao = Convert.ToDateTime(dtp_ngaytao.Text),
                NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Text),
                NgayShip = Convert.ToDateTime(dtp_ngayship.Text),
                NgayNhan = Convert.ToDateTime(stp_ngaynhan.Text),
                TinhTrang = a,
                TenNguoiNhan = tb_tennguoinhan.Text,
                DiaChi = tb_diachi.Text,
                Sdt = tb_sodienthoai.Text,
            };
            MessageBox.Show(_iqLHoaDonService.UpdateHoadon(_hoaDonView));
            LoadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            
            _hoaDonView = new HoaDonView()          
            {
                Id = SelectID             
            };
            MessageBox.Show(_iqLHoaDonService.DeleteHoadon(_hoaDonView));
            LoadData();
        }
    }
}
