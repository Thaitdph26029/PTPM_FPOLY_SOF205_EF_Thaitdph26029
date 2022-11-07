using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class SanPhamView
    {
        public Guid Id { get; set; }
        public Guid? IdSp { get; set; }
        public string Tensp { get; set; }
        public Guid? IdNsx { get; set; }
        public string TenNsx { get; set; }
        public Guid? IdMauSac { get; set; }
        public string TenMauSac { get; set; }
        public Guid? IdDongSp { get; set; }
        public string TenDongSp { get; set; }
        public int? NamBh { get; set; }
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
    }
}
