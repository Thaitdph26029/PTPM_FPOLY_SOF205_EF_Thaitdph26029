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
    public partial class QLChitietSp : Form
    {
        private IQLSanPhamService _iqLChitietSPService = new QLSanPhamService();
        private IQLNsxService _iqNsxService = new QLNsxService();
        private IQLDongSpService _iqLDongSpService = new QLDongSPService();
        private IQLMauSacService _iqLMauSacService = new QLMauSacService();
        private IQLSPService _iqLSanPhamService = new QLSpService();
        private SanPhamView _spv;
        public Guid SelectID { get; set; }
        public QLChitietSp()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            int i = 1;

            dtg_showchitiet.ColumnCount = 11;
            dtg_showchitiet.Columns[0].Name = "Stt";
            dtg_showchitiet.Columns[1].Name = "ID";
            dtg_showchitiet.Columns[1].Visible = false;
            dtg_showchitiet.Columns[2].Name = "Sản phẩm";
            dtg_showchitiet.Columns[3].Name = "Nsx";
            dtg_showchitiet.Columns[4].Name = "Màu sắc";
            dtg_showchitiet.Columns[5].Name = "Dòng Sp";
            dtg_showchitiet.Columns[6].Name = "Năm bảo hành";
            dtg_showchitiet.Columns[7].Name = "Mô tả";
            dtg_showchitiet.Columns[8].Name = "Số lượng tồn";
            dtg_showchitiet.Columns[9].Name = "Giá nhập";
            dtg_showchitiet.Columns[10].Name = "Giá bán";
            dtg_showchitiet.Rows.Clear();
            foreach (var x in _iqLChitietSPService.GetAllChitietSp())
            {
                dtg_showchitiet.Rows.Add(i++,x.Id, x.Tensp, x.TenNsx, x.TenMauSac, x.TenDongSp, x.NamBh, x.MoTa, x.SoLuongTon, x.GiaNhap, x.GiaBan);
            }
        }
        private void QLChitietSp_Load(object sender, EventArgs e)
        {
            foreach (var x in _iqLDongSpService.GetAllDongSp())
            {
                cbb_dongsp.Items.Add(x.Ten);
            }
            foreach (var x in _iqLMauSacService.GetAllMauSac())
            {
                cbb_mausac.Items.Add(x.Ten);
            }
            foreach (var x in _iqLSanPhamService.GetAllSanPham())
            {
                cbb_sanpham.Items.Add(x.Ten);
            }
            foreach (var x in _iqNsxService.GetAllNsx())
            {
                cbb_nsx.Items.Add(x.Ten);
            }
            cbb_dongsp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_mausac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_sanpham.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_nsx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bt_themct_Click(object sender, EventArgs e)
        {
            
            _spv = new SanPhamView()
            {
                Id = Guid.NewGuid(),
                IdSp = _iqLSanPhamService.GetAllSanPham().Where(c => c.Ten == Convert.ToString(cbb_sanpham.Text)).Select(c => c.Id).FirstOrDefault(),
                IdNsx = _iqNsxService.GetAllNsx().Where(c => c.Ten == Convert.ToString(cbb_nsx.Text)).Select(c => c.Id).FirstOrDefault(),
                IdMauSac = _iqLMauSacService.GetAllMauSac().Where(c => c.Ten == Convert.ToString(cbb_mausac.Text)).Select(c => c.Id).FirstOrDefault(),
                IdDongSp = _iqLDongSpService.GetAllDongSp().Where(c => c.Ten == Convert.ToString(cbb_dongsp.Text)).Select(c => c.Id).FirstOrDefault(),
                NamBh = Convert.ToInt32(tb_nambaohanh.Text),
                MoTa = tb_mota.Text,
                SoLuongTon = Convert.ToInt32(tb_soluong.Text),
                GiaBan = Convert.ToInt32(tb_giaban.Text),
                GiaNhap = Convert.ToInt32(tb_gianhap.Text),
            };
            MessageBox.Show(_iqLChitietSPService.AddChitietSp(_spv));
            LoadData();
        }

        private void dtg_showchitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_sanpham.SelectedItem = dtg_showchitiet.CurrentRow.Cells[2].Value.ToString();
            cbb_nsx.SelectedItem = dtg_showchitiet.CurrentRow.Cells[3].Value.ToString();
            cbb_mausac.SelectedItem = dtg_showchitiet.CurrentRow.Cells[4].Value.ToString();
            cbb_dongsp.SelectedItem = dtg_showchitiet.CurrentRow.Cells[5].Value.ToString();
            tb_nambaohanh.Text = dtg_showchitiet.CurrentRow.Cells[6].Value.ToString();
            tb_mota.Text = dtg_showchitiet.CurrentRow.Cells[7].Value.ToString();
            tb_soluong.Text = dtg_showchitiet.CurrentRow.Cells[8].Value.ToString();
            tb_gianhap.Text = dtg_showchitiet.CurrentRow.Cells[9].Value.ToString();
            tb_giaban.Text = dtg_showchitiet.CurrentRow.Cells[10].Value.ToString();
            SelectID = Guid.Parse(dtg_showchitiet.CurrentRow.Cells[1].Value.ToString());
        }

        private void bt_suact_Click(object sender, EventArgs e)
        {
            
            _spv = new SanPhamView()
            {
                Id = SelectID,
                IdSp = _iqLSanPhamService.GetAllSanPham().Where(c => c.Ten == Convert.ToString(cbb_sanpham.Text)).Select(c => c.Id).FirstOrDefault(),
                IdNsx = _iqNsxService.GetAllNsx().Where(c => c.Ten == Convert.ToString(cbb_nsx.Text)).Select(c => c.Id).FirstOrDefault(),
                IdMauSac = _iqLMauSacService.GetAllMauSac().Where(c => c.Ten == Convert.ToString(cbb_mausac.Text)).Select(c => c.Id).FirstOrDefault(),
                IdDongSp = _iqLDongSpService.GetAllDongSp().Where(c => c.Ten == Convert.ToString(cbb_dongsp.Text)).Select(c => c.Id).FirstOrDefault(),
                NamBh = Convert.ToInt32(tb_nambaohanh.Text),
                MoTa = tb_mota.Text,
                SoLuongTon = Convert.ToInt32(tb_soluong.Text),
                GiaBan = Convert.ToInt32(tb_giaban.Text),
                GiaNhap = Convert.ToInt32(tb_gianhap.Text),
            };
            MessageBox.Show(_iqLChitietSPService.UpdateChitietSp(_spv));
            LoadData();
        }

        private void bt_xoact_Click(object sender, EventArgs e)
        {
            //_spv = new SanPhamView();
            _spv = new SanPhamView()
            {
                Id =SelectID              
            };
            MessageBox.Show(_iqLChitietSPService.DeleteChitietSp(_spv));
            LoadData();
        }
    }
}
