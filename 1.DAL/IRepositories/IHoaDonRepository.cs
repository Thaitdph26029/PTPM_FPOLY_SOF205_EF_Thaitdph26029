using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        bool AddHoaDon(HoaDon HoaDon);
        bool UpdateHoaDon(HoaDon HoaDon);
        bool DeleteHoaDon(HoaDon HoaDon);
        
        List<HoaDon> GetAllHoaDon();
    }
}
