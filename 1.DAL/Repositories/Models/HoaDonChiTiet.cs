using System;
using System.Collections.Generic;

#nullable disable

namespace _1.DAL.Repositories.Models
{
    public partial class HoaDonChiTiet
    {
        public Guid IdHoaDon { get; set; }
        public Guid IdChiTietSp { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }

        public virtual ChiTietSp IdChiTietSpNavigation { get; set; }
        public virtual HoaDon IdHoaDonNavigation { get; set; }
    }
}
