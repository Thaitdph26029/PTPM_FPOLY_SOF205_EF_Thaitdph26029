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
    public partial class QLChucVu : Form
    {
        public IQLChucVuService _QLChucVuService = new QLChucVuService();
        public ChucVu chucVu;
        public Guid SelectID { get; set; }
        public QLChucVu()
        {
            InitializeComponent();
            chucVu = new ChucVu();
            loadData();
        }
        public void loadData()
        {
            int i = 1;
            dtg_showmau.ColumnCount = 4;
            dtg_showmau.Columns[1].Name = "Id";
            dtg_showmau.Columns[1].Visible = false;
            dtg_showmau.Columns[0].Name = "Số thứ tự";
            dtg_showmau.Columns[2].Name = "Mã";
            dtg_showmau.Columns[3].Name = "Tên chức vụ";
            dtg_showmau.Rows.Clear();
            var lstChucVu = _QLChucVuService.GetAllChucVu();
            if (tb_timkiem.Text != "")
            {
                lstChucVu = lstChucVu.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
          //  var lstChucVu = _QLChucVuService.GetAllChucVu();
            foreach (var x in lstChucVu)
            {
                dtg_showmau.Rows.Add(i++, x.ID, x.Ma, x.Ten);
            }

        }

        private void QLChucVu_Load(object sender, EventArgs e)
        {

        }

        private void bt_themchucvu_Click(object sender, EventArgs e)
        {
            if (tb_machucvu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Chức vụ");
            }
            else if (_QLChucVuService.GetAllChucVu().Any(x => x.Ma == tb_machucvu.Text))
            {   
                MessageBox.Show("Mã chức vụ đã tồn tại");
            }
            else
            {
                ChucVuView cvview = new ChucVuView();
                cvview.ID = Guid.NewGuid();
                cvview.Ma = tb_machucvu.Text;
                cvview.Ten = tb_tenchucvu.Text;
                
                _QLChucVuService.addChucVu(cvview);
                MessageBox.Show("Thêm Chức vụ thành công");
                loadData();
            }
        }

        private void bt_suachucvu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn Update chức vụ không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChucVuView cvview = new ChucVuView();
                cvview.ID = SelectID;
                cvview.Ma = tb_machucvu.Text;
                cvview.Ten = tb_tenchucvu.Text;
               
                MessageBox.Show(_QLChucVuService.updateChucVu(cvview));
                loadData();
            }
        }

        private void dtg_showmau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_machucvu.Text = dtg_showmau.CurrentRow.Cells[2].Value.ToString();
            tb_tenchucvu.Text = dtg_showmau.CurrentRow.Cells[3].Value.ToString();
            SelectID = Guid.Parse(Convert.ToString(dtg_showmau.CurrentRow.Cells[1].Value));
        }

        private void bt_xoachucvu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoa chức vụ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChucVuView cvview = new ChucVuView();
                cvview.ID = SelectID;
                MessageBox.Show(_QLChucVuService.deleteChucVu(cvview));
                loadData();
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtg_showmau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
