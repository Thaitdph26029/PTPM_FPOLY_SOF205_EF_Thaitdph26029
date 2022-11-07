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
    public partial class QLSanPham : Form
    {
        private IQLSPService _iqLSanPhamService = new QLSpService();
        public SpView _spv = new SpView();
        private List<SanPham> _lstSanPham= new List<SanPham>();
        public Guid SelectID { get; set; }

        public QLSanPham()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            int i = 1;
            dtg_showsp.ColumnCount = 4;
            dtg_showsp.Columns[1].Name = "Id";
            dtg_showsp.Columns[1].Visible = false;
            dtg_showsp.Columns[0].Name = "Số thứ tự";
            dtg_showsp.Columns[2].Name = "Mã";
            dtg_showsp.Columns[3].Name = "Tên sản phẩm";
            dtg_showsp.Rows.Clear();
            var lstSp = _iqLSanPhamService.GetAllSanPham();
            if (tb_timkiem.Text != "")
            {
                lstSp = lstSp.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstSp)
            {
                dtg_showsp.Rows.Add(i++, x.Id, x.Ma, x.Ten);
            }

        }
        private void bt_themsp_Click(object sender, EventArgs e)
        {
            if (tb_masp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Sản Phẩm");
            }
            else if (_iqLSanPhamService.GetAllSanPham().Any(x => x.Ma == tb_masp.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
            }
            else
            {
                _spv = new SpView();
                _spv.Id = new Guid();
                _spv.Ma = tb_masp.Text;
                _spv.Ten = tb_tensp.Text;                            
                MessageBox.Show(_iqLSanPhamService.addSanPham(_spv));
                loadData();
            }
        }

        private void dtg_showsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_masp.Text = dtg_showsp.CurrentRow.Cells[2].Value.ToString();
            tb_tensp.Text = dtg_showsp.CurrentRow.Cells[3].Value.ToString();
            SelectID = Guid.Parse(Convert.ToString(dtg_showsp.CurrentRow.Cells[1].Value));
        }

        private void bt_suasp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn Update Sản phẩm không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _spv = new SpView();
                _spv.Id = SelectID;
                _spv.Ma = tb_masp.Text;
                _spv.Ten = tb_tensp.Text;
                MessageBox.Show(_iqLSanPhamService.updateSanPham(_spv));
                loadData();
            }
        }

        private void bt_xoasp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _spv = new SpView();
                _spv.Id = SelectID;
                MessageBox.Show(_iqLSanPhamService.deleteSanPham(_spv));
                loadData();
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
