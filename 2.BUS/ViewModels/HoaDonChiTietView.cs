using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonChiTietView
    {
        public Guid IdHoadon { get; set; }
        public Guid IdChitietSP { get; set; }
        public string TenSp { get; set; }
        public string  TenMau { get; set; }
        public string TenDong { get; set; }
        public string TenNsx { get; set; }
        public string Mahd { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
    }
}
