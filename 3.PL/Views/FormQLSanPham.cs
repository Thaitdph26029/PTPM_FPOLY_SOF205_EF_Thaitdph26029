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
    public partial class FormQLSanPham : Form
    {
       // private IQLSanPhamService iQLSanPhamService;
        public FormQLSanPham()
        {
            InitializeComponent();
          //  iQLSanPhamService = new QLSanPhamService();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

      //  }
        //private SanPhamView GetDataFromGui()
        //{
        //    SanPhamView spv = new SanPhamView();
        //    spv.ChiTietSp = new ChiTietSp()
        //    {
        //        IdSp = Guid.Parse("6C519155-C6C6-4E78-830D-D035001541FA"),
        //        IdDongSp = Guid.Parse("4FD32F54-93EE-4749-8A1A-E0A3B3E6A22E"),
        //        IdMauSac = Guid.Parse("BF1707F4-69AC-497C-962E-2E9AFA571985"),
        //        MoTa = "Sản phẩm add tay"
        //    };//Gán các control từ giao diện vào chỗ này

        //    //spv.MauSac = đối tượng mầu sắc trên control mà tìm được
        //    return spv;
        //}
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtg_showsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private void LoadDGriSP()
        //{
        //    int stt = 1;
        //    Type type = typeof(CuaHang);
        //    dtg_showsanpham.Rows.Clear();
        //    dtg_showsanpham.ColumnCount = 8;//Hiển thị bao nhiểu cột tự cấu hình
        //    dtg_showsanpham.Columns[0].Name = "STT";
        //    dtg_showsanpham.Columns[1].Name = "Id";
        //    dtg_showsanpham.Columns[2].Name = "Tên SP";
        //    dtg_showsanpham.Columns[3].Name = "Tên Màu";
        //    dtg_showsanpham.Columns[4].Name = "Tên NSX";
        //    dtg_showsanpham.Columns[5].Name = "Tên Dòng SP";
        //    dtg_showsanpham.Columns[6].Name = "Năm BH";
        //    dtg_showsanpham.Columns[7].Name = "Mô tả";


        //    foreach (var x in iQLSanPhamService.GetAll())
        //    {
        //        dtg_showsanpham.Rows.Add(stt++, x.ChiTietSp.Id, x.SanPham.Ten, x.MauSac.Ten, x.Nsx.Ten, x.DongSp.Ten, x.ChiTietSp.NamBh, x.ChiTietSp.MoTa);
        //    }
        //}
    }
}
