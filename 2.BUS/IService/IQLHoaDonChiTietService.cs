using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLHoaDonChiTietService
    {
        string AddHoaDonChitiet(HoaDonChiTietView HoaDonChiTietView);
        string UpdateHoaDonChitiet(HoaDonChiTietView HoaDonChiTietView);
        string DeleteHoaDonChitiet(HoaDonChiTietView HoaDonChiTietView);
        List<HoaDonChiTietView> GetAllHoaDonChitiet(Guid idhoadon);
        List<SanPhamView> GetAllSanPhamChitiet(Guid idsp);
    }
}
