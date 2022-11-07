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
    public partial class QLMauSac : Form
    {
        public IQLMauSacService _quanlyMauSacService = new QLMauSacService();
        public MausacView _msV = new MausacView();
        public MauSac mausac;
        public Guid SelectID { get; set; }
        public QLMauSac()
        {
            InitializeComponent();
            mausac = new MauSac();
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
            dtg_showmau.Columns[3].Name = "Tên màu";
            dtg_showmau.Rows.Clear();
            var lstMauSac = _quanlyMauSacService.GetAllMauSac();
            if (tb_timkiem.Text != "")
            {
                lstMauSac = lstMauSac.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstMauSac)
            {
                dtg_showmau.Rows.Add(i++, x.Id, x.Ma, x.Ten);
            }

        }

        private void bt_themmau_Click(object sender, EventArgs e)
        {
            if (tb_mamau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã màu");
            }
            else if (_quanlyMauSacService.GetAllMauSac().Any(x => x.Ma == tb_mamau.Text))
            {
                MessageBox.Show("Mã màu đã tồn tại");
            }
            else
            {
                _msV = new MausacView();
                _msV.Id = new Guid();
                _msV.Ma = tb_mamau.Text;
                _msV.Ten = tb_tenmau.Text;                       
                MessageBox.Show(_quanlyMauSacService.addMauSac(_msV));
                loadData();

            }
            //var MS = new MauSac()
            //{
            //    Id = new Guid(),
            //    Ma = tb_mamau.Text,
            //    Ten = tb_tenmau.Text
            //};
            //_quanlyMauSacService.addMauSac(MS);
            //loadData();
            //MessageBox.Show("Thêm màu sắc thành công");
        }

        private void dtg_showmau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_mamau.Text = dtg_showmau.CurrentRow.Cells[2].Value.ToString();
            tb_tenmau.Text = dtg_showmau.CurrentRow.Cells[3].Value.ToString();
            SelectID = Guid.Parse(Convert.ToString(dtg_showmau.CurrentRow.Cells[1].Value));
        }

        private void bt_suamau_Click(object sender, EventArgs e)
        {
            //mausac.Id = SelectID;
            //mausac.Ma = tb_mamau.Text;
            //mausac.Ten = tb_tenmau.Text;
            //_quanlyMauSacService.updateMauSac(mausac);
            //MessageBox.Show("Sửa màu thành công");
            //loadData();

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn Update màu sắc không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _msV = new MausacView();
                _msV.Id = SelectID;
                _msV.Ma = tb_mamau.Text;
                _msV.Ten = tb_tenmau.Text;
                MessageBox.Show(_quanlyMauSacService.addMauSac(_msV));
                loadData();
                MessageBox.Show(_quanlyMauSacService.updateMauSac(_msV));
                loadData();
            }
        }

        private void bt_xoamau_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoa màu sắc không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _msV = new MausacView();
                _msV.Id = SelectID;
                MessageBox.Show(_quanlyMauSacService.deleteMauSac(_msV));
                loadData();
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void QLMauSac_Load(object sender, EventArgs e)
        {

        }
    }
}
