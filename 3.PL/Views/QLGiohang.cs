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
    public partial class QLGiohang : Form
    {
        private IQLGiohangService _iqLGiohangService = new QLGiohangService();
        private IQLNhanvienService _iqNhanvienService = new QLNhanvienService();
        private IQLKhachhangService _iqLKhachhangService = new QLKhachhangService();
        private GiohangView _ghv = new GiohangView();
        public Guid SelectID { get; set; }
        public QLGiohang()
        {

            InitializeComponent();
            _iqLGiohangService = new QLGiohangService();
            _iqNhanvienService = new QLNhanvienService();
            _iqLKhachhangService = new QLKhachhangService();
            _ghv = new GiohangView();
            loadData();
        }
        public void loadData()
        {
            int i = 1;
            dtg_showgiohang.ColumnCount = 11;
            dtg_showgiohang.Columns[0].Name = "Stt";
            dtg_showgiohang.Columns[1].Name = "ID Giỏ hàng";
            dtg_showgiohang.Columns[1].Visible = false;
            dtg_showgiohang.Columns[2].Name = "Tên khách hàng";
            dtg_showgiohang.Columns[3].Name = "Tên nhân viên ";
            dtg_showgiohang.Columns[4].Name = "Mã giỏ hàng";
            dtg_showgiohang.Columns[5].Name = "Ngày tạo";
            dtg_showgiohang.Columns[6].Name = "Ngày thanh toán";
            dtg_showgiohang.Columns[7].Name = "Tên người nhận";
            dtg_showgiohang.Columns[8].Name = "Địa chỉ";
            dtg_showgiohang.Columns[9].Name = "Sdt";
            dtg_showgiohang.Columns[10].Name = "Tình trạng";
            dtg_showgiohang.Rows.Clear();
            foreach (var x in _iqLGiohangService.Getallgiohang())
            {
                dtg_showgiohang.Rows.Add(i++, x.Id, x.TenKh, x.TenNv, x.Ma, x.NgayTao, x.NgayThanhToan, x.TenNguoiNhan, x.DiaChi, x.Sdt, x.TinhTrang == 1 ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }

        private void QLGiohang_Load(object sender, EventArgs e)
        {
            foreach (var x in _iqLKhachhangService.GetAllKhachHang())
            {
                cbb_makh.Items.Add(x.Ten);
            }
            foreach (var x in _iqNhanvienService.GetAllNhanvien())
            {
                cbb_manv.Items.Add(x.Ten);
            }
            cbb_makh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_manv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_makh.SelectedIndex = 0;
            cbb_manv.SelectedIndex = 0;
            rd_chuagiao.Checked = true;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            int a;
            if (rd_chuagiao.Checked == true)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
            if (_iqLGiohangService.Getallgiohang().Where(x => x.Ma == tb_magh.Text).ToList().Count == 0)
            {
                _ghv = new GiohangView()
                {
                    Id = Guid.NewGuid(),
                    IdNv = _iqNhanvienService.GetAllNhanvien().Where(x => x.Ten == Convert.ToString(cbb_manv.Text)).Select(x => x.Id).FirstOrDefault(),
                    IdKh = _iqLKhachhangService.GetAllKhachHang().Where(x => x.Ten == Convert.ToString(cbb_makh.Text)).Select(x => x.Id).FirstOrDefault(),
                    Ma = tb_magh.Text,
                    NgayTao = Convert.ToDateTime(dtp_ngaytao.Value),
                    NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Value),
                    TenNguoiNhan = tb_tennguoinhan.Text,
                    DiaChi = tb_diachi.Text,
                    TinhTrang = a,
                    Sdt = tb_sodienthoai.Text,
                };
                MessageBox.Show(_iqLGiohangService.addGiohang(_ghv));
                loadData();
            }
            else
            {
                MessageBox.Show("Mã giỏ hàng đã tồn tại");
            }
        }

        private void dtg_showgiohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_makh.SelectedItem = dtg_showgiohang.CurrentRow.Cells[2].Value.ToString();
            cbb_manv.SelectedItem = dtg_showgiohang.CurrentRow.Cells[3].Value.ToString();
            tb_magh.Text = dtg_showgiohang.CurrentRow.Cells[4].Value.ToString();
            dtp_ngaytao.Value = Convert.ToDateTime(dtg_showgiohang.CurrentRow.Cells[5].Value.ToString());
            dtp_ngaythanhtoan.Value = Convert.ToDateTime(dtg_showgiohang.CurrentRow.Cells[6].Value.ToString());
            SelectID = Guid.Parse(dtg_showgiohang.CurrentRow.Cells[1].Value.ToString());
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            int a;
            if (rd_chuagiao.Checked == true)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
            _ghv = new GiohangView()
            {
                Id = SelectID,
             //   IdNv = _iqNhanvienService.GetAllNhanvien().Where(x => x.Ma == Convert.ToString(cbb_manv.Text)).Select(x => x.Id).FirstOrDefault(),
             //   IdKh = _iqLKhachhangService.GetAllKhachHang().Where(x => x.Ma == Convert.ToString(cbb_makh.Text)).Select(x => x.Id).FirstOrDefault(),
              //  Ma = tb_magh.Text,
                NgayTao = Convert.ToDateTime(dtp_ngaytao.Value),
                NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Value),
                TenNguoiNhan = tb_tennguoinhan.Text,
                DiaChi = tb_diachi.Text,
                TinhTrang = a,
                Sdt = tb_sodienthoai.Text,
            };
            MessageBox.Show(_iqLGiohangService.updateGiohang(_ghv));
            loadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            _ghv = new GiohangView()
            {
                Id = SelectID,
                   IdNv = _iqNhanvienService.GetAllNhanvien().Where(x => x.Ma == Convert.ToString(cbb_manv.Text)).Select(x => x.Id).FirstOrDefault(),
                   IdKh = _iqLKhachhangService.GetAllKhachHang().Where(x => x.Ma == Convert.ToString(cbb_makh.Text)).Select(x => x.Id).FirstOrDefault(),               
            };
            MessageBox.Show(_iqLGiohangService.deleteGiohang(_ghv));
            loadData();
        }
    }
}
