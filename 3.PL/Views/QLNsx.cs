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
    public partial class QLNsx : Form
    {
        private IQLNsxService _iqLNsxService = new QLNsxService();
        public NsxView _nsxView = new NsxView();
        private List<Nsx> _lstNsx = new List<Nsx>();
        public Guid SelectID { get; set; }
        public QLNsx()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            int i = 1;
            dtg_showNsx.ColumnCount = 4;
            dtg_showNsx.Columns[1].Name = "Id";
            dtg_showNsx.Columns[1].Visible = false;
            dtg_showNsx.Columns[0].Name = "Số thứ tự";
            dtg_showNsx.Columns[2].Name = "Mã";
            dtg_showNsx.Columns[3].Name = "Tên Nsx";
            dtg_showNsx.Rows.Clear();
            var lstNsx = _iqLNsxService.GetAllNsx();
            if (tb_timkiem.Text != "")
            {
                lstNsx = lstNsx.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstNsx)
            {
                dtg_showNsx.Rows.Add(i++, x.Id, x.Ma, x.Ten);
            }

        }
        private void bt_themmau_Click(object sender, EventArgs e)
        {
            if (tb_maNsx.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã màu");
            }
            else if (_iqLNsxService.GetAllNsx().Any(x => x.Ma == tb_maNsx.Text))
            {
                MessageBox.Show("Mã màu đã tồn tại");
            }
            else
            {
                _nsxView = new NsxView();
                _nsxView.Id = Guid.NewGuid();
                _nsxView.Ma = tb_maNsx.Text;
                _nsxView.Ten = tb_tenNsx.Text;
                MessageBox.Show(_iqLNsxService.addNsx(_nsxView));
                loadData();
            }
        }

        private void dtg_showNsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maNsx.Text = dtg_showNsx.CurrentRow.Cells[2].Value.ToString();
            tb_tenNsx.Text = dtg_showNsx.CurrentRow.Cells[3].Value.ToString();
            SelectID = Guid.Parse(Convert.ToString(dtg_showNsx.CurrentRow.Cells[1].Value));
        }

        private void bt_suamau_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn Update Nsx không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _nsxView = new NsxView();
                _nsxView.Id = SelectID;
                _nsxView.Ma = tb_maNsx.Text;
                _nsxView.Ten = tb_tenNsx.Text;
                MessageBox.Show(_iqLNsxService.updateNsx(_nsxView));
                loadData();
            }
        }

        private void bt_xoamau_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Nsx không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _nsxView = new NsxView();
                _nsxView.Id = SelectID;
                MessageBox.Show(_iqLNsxService.deleteNsx(_nsxView));
                loadData();
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtg_showNsx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
