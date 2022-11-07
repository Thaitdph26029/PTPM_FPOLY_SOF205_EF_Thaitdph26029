using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class GiohangChitietView
    {
        public Guid IdGh { get; set; }
        public string MaGH { get; set; }
        public Guid IdCTSanpham { get; set; }
        public string TenSP { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? DonGiaKhiGiam { get; set; }


    }
}
