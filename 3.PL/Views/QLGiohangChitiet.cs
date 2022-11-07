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
    public partial class QLGiohangChitiet : Form
    {
        private IQLGiohangChitietService _iqLGiohangChitietService = new QLGIohangChitietService();
        private IQLGiohangService _iqLGiohangService = new QLGiohangService();
        private IQLSanPhamService _iqSanPhamchitietService = new QLSanPhamService();
        private IQLSPService _iqLSPService = new QLSpService();
        private GiohangChitietView _ghct = new GiohangChitietView();
        public Guid IDGH { get; set; }
        public QLGiohangChitiet()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            int i = 1;
            dtg_showghct.ColumnCount = 6;
            dtg_showghct.Columns[0].Name = "stt";
            dtg_showghct.Columns[1].Name = "Mã giỏ hàng";
            dtg_showghct.Columns[2].Name = "Mã sản phẩm";
            dtg_showghct.Columns[3].Name = "Số lượng";
            dtg_showghct.Columns[4].Name = "Đơn giá";
            dtg_showghct.Columns[5].Name = "Đơn giá khi giảm";
            dtg_showghct.Rows.Clear();
            foreach (var x in _iqLGiohangChitietService.GetAllGiohangChitiet(IDGH))
            {
                dtg_showghct.Rows.Add(i++, x.MaGH, x.TenSP, x.SoLuong, x.DonGia, x.DonGiaKhiGiam);
            }
        }

        private void QLGiohangChitiet_Load(object sender, EventArgs e)
        {
            foreach (var x in _iqLGiohangService.Getallgiohang())
            {
                cbb_idgh.Items.Add(x.Ma);
            }
            foreach (var x in _iqLSPService.GetAllSanPham())
            {
                cbb_sanpham.Items.Add(x.Ten);
            }
            cbb_idgh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_sanpham.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbb_idgh_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDGH = _iqLGiohangService.Getallgiohang().Where(x => x.Ma == cbb_idgh.Text).Select(x => x.Id).FirstOrDefault();
            loadData();
        }

        private void dtg_showghct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_sanpham.SelectedItem = dtg_showghct.CurrentRow.Cells[2].Value.ToString();
            tb_soluong.Text = dtg_showghct.CurrentRow.Cells[3].Value.ToString();
            tb_dongia.Text = dtg_showghct.CurrentRow.Cells[4].Value.ToString();
            tb_dongiakhigiam.Text = dtg_showghct.CurrentRow.Cells[5].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            GiohangChitietView ghct = new GiohangChitietView();
            ghct = new GiohangChitietView()
            {
                
                IdCTSanpham = _iqSanPhamchitietService.GetAllChitietSp().Where(x => x.Tensp == cbb_sanpham.Text).Select(x => x.Id).FirstOrDefault(),
                IdGh = IDGH,
                SoLuong = Convert.ToInt32(tb_soluong.Text),
                DonGia = Convert.ToInt32(tb_dongia.Text),
                DonGiaKhiGiam = Convert.ToInt32(tb_dongiakhigiam.Text),
            };
            MessageBox.Show(_iqLGiohangChitietService.AddGiohangChitiet(ghct));
            loadData();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            GiohangChitietView ghct = new GiohangChitietView();
            ghct = new GiohangChitietView()
            {

                IdCTSanpham = _iqSanPhamchitietService.GetAllChitietSp().Where(x => x.Tensp == cbb_sanpham.Text).Select(x => x.Id).FirstOrDefault(),
                IdGh = IDGH,
                SoLuong = Convert.ToInt32(tb_soluong.Text),
                DonGia = Convert.ToInt32(tb_dongia.Text),
                DonGiaKhiGiam = Convert.ToInt32(tb_dongiakhigiam.Text),
            };
            MessageBox.Show(_iqLGiohangChitietService.UpdateGiohangChitiet(ghct));
            loadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            GiohangChitietView ghct = new GiohangChitietView();
            ghct = new GiohangChitietView()
            {

                IdCTSanpham = _iqSanPhamchitietService.GetAllChitietSp().Where(x => x.Tensp == cbb_sanpham.Text).Select(x => x.Id).FirstOrDefault(),
                IdGh = IDGH,
                
            };
            MessageBox.Show(_iqLGiohangChitietService.DeleteGiohangChitiet(ghct));
            loadData();
        }
    }
}
