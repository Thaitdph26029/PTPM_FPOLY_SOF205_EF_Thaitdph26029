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
    public partial class QLNhanvien : Form
    {
        private IQLNhanvienService _iqLNhanvienService = new QLNhanvienService();
        private NhanvienView NhanvienView;
        private IQLChucVuService _iqLChucVuService = new QLChucVuService();
        private ICuahangService _iqCuahangService = new QLCuahangService();
        //  private List<Nhanvien>
        public Guid SelectID { get; set; }
        public QLNhanvien()
        {
            InitializeComponent();
            _iqLNhanvienService = new QLNhanvienService();
            _iqLChucVuService = new QLChucVuService();
            _iqCuahangService = new QLCuahangService();
            NhanvienView = new NhanvienView();

            loadData();
        }
        public void loadData()
        {
            int i = 1;

            dtg_shownv.ColumnCount = 14;
            dtg_shownv.Columns[0].Name = "Stt";
            dtg_shownv.Columns[1].Name = "ID";
            dtg_shownv.Columns[1].Visible = false;
            dtg_shownv.Columns[2].Name = "Mã";
            dtg_shownv.Columns[3].Name = "Tên";
            dtg_shownv.Columns[4].Name = "Tên Đệm";
            dtg_shownv.Columns[5].Name = "Họ";
            dtg_shownv.Columns[6].Name = "Giới tính";
            dtg_shownv.Columns[7].Name = "Ngày sinh";
            dtg_shownv.Columns[8].Name = "Địa chỉ";
            dtg_shownv.Columns[9].Name = "Sdt";
            dtg_shownv.Columns[10].Name = "Mật khẩu";
            dtg_shownv.Columns[11].Name = "Của hàng";
            dtg_shownv.Columns[12].Name = "Chức vụ";
            dtg_shownv.Columns[13].Name = "Trạng thái";
            dtg_shownv.Rows.Clear();
            foreach (var x in _iqLNhanvienService.GetAllNhanvien())
            {
                dtg_shownv.Rows.Add(i++, x.Id, x.Ma, x.Ten, x.TenDem, x.Ho, x.GioiTinh, x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, x.TenCh, x.TenCv, x.TrangThai==1?"Còn làm":"Đã nghỉ");
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        public NhanvienView GetdataFromGui()
        {
            string a = "";
            if (rd_nam.Checked == true)
            {
                a = "Nam";
            }
            else
            {
                a = "Nữ";
            }
            int b;
            if (cb_conlam.Checked == true)
            {
                b = 1;

            }
            else
            {
                b = 0;
            }

            
            
            NhanvienView = new NhanvienView()
            {
                Id = Guid.NewGuid(),
                Ma = tb_manv.Text,
                Ten = tb_tennv.Text,
                TenDem = tb_tendemnv.Text,
                Ho = tb_honv.Text,
                GioiTinh = a,
                TrangThai = b,
                NgaySinh = Convert.ToDateTime(dtp_ngaysinh.Text),
                DiaChi = tb_diachinv.Text,
                Sdt = tb_sdtnv.Text,
                MatKhau = tb_matkhau.Text,
                IdCh = _iqCuahangService.GetallCuahang().Where(c => c.Ten == Convert.ToString(cb_cuahang.Text)).Select(c => c.Id).FirstOrDefault(),
                IdCv = _iqLChucVuService.GetAllChucVu().Where(c => c.Ten == Convert.ToString(cb_chucvu.Text)).Select(c => c.ID).FirstOrDefault(),
            };
            return NhanvienView;
        }
        private void bt_themnv_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iqLNhanvienService.AddNhanvien(GetdataFromGui()));
            loadData();
        }

        private void QLNhanvien_Load(object sender, EventArgs e)
        {
            foreach (var x in _iqLChucVuService.GetAllChucVu())
            {
                cb_chucvu.Items.Add(x.Ten);
            }
            cb_chucvu.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var x in _iqCuahangService.GetallCuahang())
            {
                cb_cuahang.Items.Add(x.Ten);
            }
            cb_chucvu.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cuahang.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_chucvu.SelectedIndex = 0;
            cb_cuahang.SelectedIndex = 0;
            rd_nam.Checked = true;
            cb_conlam.Checked = true;
           
        }

        private void bt_suanv_Click(object sender, EventArgs e)
        {
            string a;
            if (rd_nam.Checked == true)
            {
                a = "Nam";
            }
            else
            {
                a = "Nữ";
            }
            int b;
            if (cb_conlam.Checked == true)
            {
                b = 1;

            }
            else
            {
                b = 0;
            }
            
            NhanvienView = new NhanvienView()
            {
                Id = SelectID,
                Ma = tb_manv.Text,
                Ten = tb_tennv.Text,
                TenDem = tb_tendemnv.Text,
                Ho = tb_honv.Text,
                GioiTinh = a,
                NgaySinh = Convert.ToDateTime(dtp_ngaysinh.Text),
                DiaChi = tb_diachinv.Text,
                Sdt = tb_sdtnv.Text,
                MatKhau = tb_matkhau.Text,
                TrangThai = b,
                IdCh = _iqCuahangService.GetallCuahang().Where(c => c.Ten == Convert.ToString(cb_cuahang.Text)).Select(c => c.Id).FirstOrDefault(),
                IdCv = _iqLChucVuService.GetAllChucVu().Where(c => c.Ten == Convert.ToString(cb_chucvu.Text)).Select(c => c.ID).FirstOrDefault(),
            };
            MessageBox.Show(_iqLNhanvienService.UpdateNhanvien(NhanvienView));
            loadData();
        }

        private void dtg_shownv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv.Text = dtg_shownv.CurrentRow.Cells[2].Value.ToString();
            tb_tennv.Text = dtg_shownv.CurrentRow.Cells[3].Value.ToString();
            tb_tendemnv.Text = dtg_shownv.CurrentRow.Cells[4].Value.ToString();
            tb_honv.Text = dtg_shownv.CurrentRow.Cells[5].Value.ToString();
            //   .Text = dtg_shownv.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaysinh.Value = Convert.ToDateTime(dtg_shownv.CurrentRow.Cells[7].Value.ToString());
            tb_diachinv.Text = dtg_shownv.CurrentRow.Cells[8].Value.ToString();
            tb_sdtnv.Text = dtg_shownv.CurrentRow.Cells[9].Value.ToString();
            tb_matkhau.Text = dtg_shownv.CurrentRow.Cells[10].Value.ToString();
            cb_cuahang.SelectedItem = dtg_shownv.CurrentRow.Cells[11].Value.ToString();
            cb_chucvu.SelectedItem = dtg_shownv.CurrentRow.Cells[12].Value.ToString();
            //    tb_manv.Text = dtg_shownv.CurrentRow.Cells[13].Value.ToString();
            // tb_manv.Text = dtg_shownv.CurrentRow.Cells[14].Value.ToString();
            if (dtg_shownv.CurrentRow.Cells[6].Value.ToString()=="Nam")
            {
                rd_nam.Checked = true;
            }
            else
            {
                rd_nu.Checked = true;
            }
            SelectID = Guid.Parse(dtg_shownv.CurrentRow.Cells[1].Value.ToString());
        }

        private void bt_xoanv_Click(object sender, EventArgs e)
        {
          
            NhanvienView = new NhanvienView()
            {
                Id = SelectID,
            };
            MessageBox.Show(_iqLNhanvienService.DeleteNhanvien(NhanvienView));
            loadData();
        }

        private void cb_conlam_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_conlam.Checked == true)
            {
                cb_danghi.Checked = false;
            }
            else
            {
                cb_conlam.Checked = false;
            }
        }

        private void cb_danghi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_danghi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_danghi.Checked == true)
            {
                cb_conlam.Checked = false;
            }
            else
            {
                cb_danghi.Checked = false;
            }
        }
    }
}
