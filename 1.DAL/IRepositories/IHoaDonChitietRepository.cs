using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChitietRepository
    {
        bool AddHoaDonChitiet(HoaDonChiTiet HoaDonChiTiet);
        bool UpdateHoaDonChitiet(HoaDonChiTiet HoaDonChiTiet);
        bool DeleteHoaDonChitiet(HoaDonChiTiet HoaDonChiTiet);

        List<HoaDonChiTiet> GetAllHoaDonChitiet();
    }
}
