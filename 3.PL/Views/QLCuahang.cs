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
    public partial class QLCuahang : Form
    {
        public ICuahangService _iqlcuahangservice = new QLCuahangService();
        public CuahangView cuahangview;

        public Guid SelectID { get; set; }
        public QLCuahang()
        {
            InitializeComponent();
            _iqlcuahangservice=new QLCuahangService();
            loadData(); 
        }

        private void bt_themmau_Click(object sender, EventArgs e)
        {
            if (tb_macuahang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã cửa hàng");
            }
            else if (_iqlcuahangservice.GetallCuahang().Any(x => x.Ma == tb_macuahang.Text))
            {
                MessageBox.Show("Mã cửa hàng đã tồn tại");
            }
            else
            {
                CuahangView cuahangview = new CuahangView();
                cuahangview.Id = new Guid();
                cuahangview.Ma = tb_macuahang.Text;
                cuahangview.Ten = tb_tencuahang.Text;
                cuahangview.DiaChi = tb_diachi.Text;
                cuahangview.ThanhPho = tb_thanhpho.Text;
                cuahangview.QuocGia = tb_quocgia.Text;               
                _iqlcuahangservice.addCuahang(cuahangview);
                MessageBox.Show("Thêm cửa hàng thành công");
                loadData();
            }
        }
        public void loadData()
        {
            int i = 1;
            dtg_showcuahang.ColumnCount = 7;
            
            dtg_showcuahang.Columns[0].Name = "Số thứ tự";
            dtg_showcuahang.Columns[1].Name = "Id";
            dtg_showcuahang.Columns[1].Visible = false;
            dtg_showcuahang.Columns[2].Name = "Mã";
            dtg_showcuahang.Columns[3].Name = "Tên cửa hàng";
            dtg_showcuahang.Columns[4].Name = "Địa chỉ";
            dtg_showcuahang.Columns[5].Name = "Thành phố";
            dtg_showcuahang.Columns[6].Name = "Quốc gia";
            dtg_showcuahang.Rows.Clear();
            var lstcuahang = _iqlcuahangservice.GetallCuahang();
            if (tb_timkiem.Text != "")
            {
                lstcuahang = lstcuahang.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.DiaChi.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.ThanhPho.ToLower().Contains(tb_timkiem.Text.ToLower()) ||
                x.QuocGia.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstcuahang)
            {
                dtg_showcuahang.Rows.Add(i++, x.Id, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia);
            }

        }

        private void bt_suamau_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn Update cửa hàng không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CuahangView cuahangview = new CuahangView();
                cuahangview.Id = SelectID;
                cuahangview.Ma = tb_macuahang.Text;
                cuahangview.Ten = tb_tencuahang.Text;
                cuahangview.DiaChi = tb_diachi.Text;
                cuahangview.ThanhPho = tb_thanhpho.Text;
                cuahangview.QuocGia = tb_quocgia.Text;
                _iqlcuahangservice.updateCuahang(cuahangview);
                MessageBox.Show("Sửa cửa hàng thành công");
                loadData();
            }
        }

        private void dtg_showcuahang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_macuahang.Text = dtg_showcuahang.CurrentRow.Cells[2].Value.ToString();
            tb_tencuahang.Text = dtg_showcuahang.CurrentRow.Cells[3].Value.ToString();
            tb_diachi.Text = dtg_showcuahang.CurrentRow.Cells[4].Value.ToString();
            tb_thanhpho.Text = dtg_showcuahang.CurrentRow.Cells[5].Value.ToString();
            tb_quocgia.Text = dtg_showcuahang.CurrentRow.Cells[6].Value.ToString();
            SelectID = Guid.Parse(Convert.ToString(dtg_showcuahang.CurrentRow.Cells[1].Value));
        }

        private void bt_xoamau_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoa chức vụ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //cuahangview = new CuahangView();
                //cuahangview.Cuahang = new CuaHang()
                //{
                //    Id = SelectID,

                //};
                //if (_iqlcuahangservice.Checknhanvien(cuahangview)==false)
                //{
                //    MessageBox.Show("Khoong the xoa nhan vien");
                //}
                //else
                //{
                CuahangView cuahangview = new CuahangView();
                cuahangview.Id = SelectID;
                MessageBox.Show(_iqlcuahangservice.deleteCuahang(cuahangview));
                    loadData();
               // }
            }
        }

        private void QLCuahang_Load(object sender, EventArgs e)
        {

        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtg_showcuahang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
