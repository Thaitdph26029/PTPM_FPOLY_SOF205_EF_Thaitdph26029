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
    public partial class QLChiTietHoaDon : Form
    {
        private IQLHoaDonChiTietService _iQLHoaDonChiTietService = new QLHoaDonChiTietService();
        private IQLHoaDonService _iqLHoaDonService = new QLHoaDonService();
        private IQLSanPhamService _iqLSanPhamService = new QLSanPhamService();
        private HoaDonChiTietView _hdctv = new HoaDonChiTietView();
        public Guid IDhoadon { get; set; }
        public Guid IDChitiet { get; set; }
        public QLChiTietHoaDon()
        {
            _iQLHoaDonChiTietService = new QLHoaDonChiTietService();
            _iqLHoaDonService = new QLHoaDonService();
            _iqLSanPhamService = new QLSanPhamService();
            // IDhoadon = Guid.Parse("118e0d1b-3291-4ce2-8497-0f685502c7f1");
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            int i = 1;

            dtg_showhdct.ColumnCount = 8;
            dtg_showhdct.Columns[0].Name = "Stt";
            // dtg_showhdct.Columns[1].Name = "ID hoa don";
            dtg_showhdct.Columns[1].Name = "ID san pham";
            dtg_showhdct.Columns[1].Visible = false;
            //dtg_showhdct.Columns[1].Visible = false;
            //dtg_showhdct.Columns[2].Name = "Mã hóa đơn";
            dtg_showhdct.Columns[2].Name = "Tên sản phẩm";
            dtg_showhdct.Columns[3].Name = "Tên màu";
            dtg_showhdct.Columns[4].Name = "Tên dòng";
            dtg_showhdct.Columns[5].Name = "Tên nhà sản xuất";
            dtg_showhdct.Columns[6].Name = "Số lượng";
            dtg_showhdct.Columns[7].Name = "Đơn giá";
            dtg_showhdct.Rows.Clear();

            foreach (var x in _iQLHoaDonChiTietService.GetAllHoaDonChitiet(IDhoadon))
            {
                dtg_showhdct.Rows.Add(i++, x.IdChitietSP, x.TenSp, x.TenMau, x.TenDong, x.TenNsx, x.SoLuong, x.DonGia);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QLChiTietHoaDon_Load(object sender, EventArgs e)
        {
            foreach (var x in _iqLSanPhamService.GetAllChitietSp())
            {
                cbb_chitietsp.Items.Add(x.Tensp);
            }
            cbb_chitietsp.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var x in _iqLHoaDonService.GetAllHoadon())
            {
                cbb_hoadon.Items.Add(x.Ma);
            }
            cbb_hoadon.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbb_hoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///*IDhoadon = _iqLHoaDonService.GetAllHoadon().Where(x => x.Ma == Convert.ToString*/(cbb_hoadon.Text)).Select(x => x.Id).FirstOrDefault();
        }

        private void cbb_hoadon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_hoadon_SelectedValueChanged(object sender, EventArgs e)
        {
            IDhoadon = _iqLHoaDonService.GetAllHoadon().Where(x => x.Ma == Convert.ToString(cbb_hoadon.Text)).Select(x => x.Id).FirstOrDefault();
            loadData();
        }

        private void cbb_chitietsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IDChitiet = Guid.Parse(cbb_chitietsp.SelectedItem.ToString());
            IDChitiet = _iqLSanPhamService.GetAllChitietSp().Where(x => x.Tensp == Convert.ToString
            (cbb_chitietsp.Text)).Select(x => x.Id).FirstOrDefault();
            tb_tensp.Text = _iqLSanPhamService.GetAllChitietSp().Where(c => c.Id == IDChitiet).Select(c => c.Tensp).FirstOrDefault();
            tb_tenmau.Text = _iqLSanPhamService.GetAllChitietSp().Where(c => c.Id == IDChitiet).Select(c => c.TenMauSac).FirstOrDefault();
            tb_tennsx.Text = _iqLSanPhamService.GetAllChitietSp().Where(c => c.Id == IDChitiet).Select(c => c.TenNsx).FirstOrDefault();
            tb_dongsp.Text = _iqLSanPhamService.GetAllChitietSp().Where(c => c.Id == IDChitiet).Select(c => c.TenDongSp).FirstOrDefault();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            _hdctv = new HoaDonChiTietView()
            {
                IdChitietSP = _iqLSanPhamService.GetAllChitietSp().Where(x => x.Tensp == Convert.ToString
           (cbb_chitietsp.Text)).Select(x => x.Id).FirstOrDefault(),
                IdHoadon = _iqLHoaDonService.GetAllHoadon().Where(x => x.Ma == Convert.ToString(cbb_hoadon.Text)).Select(x => x.Id).FirstOrDefault(),
            SoLuong = Convert.ToInt32(tb_soluong.Text),
                DonGia = Convert.ToInt32(tb_dongia.Text),
            };
            MessageBox.Show(_iQLHoaDonChiTietService.AddHoaDonChitiet(_hdctv));
            loadData();
    }

        private void dtg_showhdct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_chitietsp.SelectedItem = dtg_showhdct.CurrentRow.Cells[2].Value.ToString();
            tb_soluong.Text = dtg_showhdct.CurrentRow.Cells[6].Value.ToString();
            tb_dongia.Text = dtg_showhdct.CurrentRow.Cells[7].Value.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            _hdctv = new HoaDonChiTietView()
            {
                IdChitietSP = _iqLSanPhamService.GetAllChitietSp().Where(x => x.Tensp == Convert.ToString
                (cbb_chitietsp.Text)).Select(x => x.Id).FirstOrDefault(),
                IdHoadon = _iqLHoaDonService.GetAllHoadon().Where(x => x.Ma == Convert.ToString(cbb_hoadon.Text)).Select(x => x.Id).FirstOrDefault(),
                SoLuong = Convert.ToInt32(tb_soluong.Text),
                DonGia = Convert.ToInt32(tb_dongia.Text),
            };
            MessageBox.Show(_iQLHoaDonChiTietService.UpdateHoaDonChitiet(_hdctv));
            loadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            _hdctv = new HoaDonChiTietView()
            {
                IdChitietSP = _iqLSanPhamService.GetAllChitietSp().Where(x => x.Tensp == Convert.ToString
                (cbb_chitietsp.Text)).Select(x => x.Id).FirstOrDefault(),
                IdHoadon = _iqLHoaDonService.GetAllHoadon().Where(x => x.Ma == Convert.ToString(cbb_hoadon.Text)).Select(x => x.Id).FirstOrDefault(),
                SoLuong = Convert.ToInt32(tb_soluong.Text),
                DonGia = Convert.ToInt32(tb_dongia.Text),
            };
            MessageBox.Show(_iQLHoaDonChiTietService.DeleteHoaDonChitiet(_hdctv));
            loadData();
        }
    }
}
