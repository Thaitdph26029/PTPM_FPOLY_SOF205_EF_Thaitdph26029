using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLHoaDonService
    {
        string AddHoadon(HoaDonView HoaDonView);
        string UpdateHoadon(HoaDonView HoaDonView);
        string DeleteHoadon(HoaDonView HoaDonView);
        List<HoaDonView> GetAllHoadon();
    }
}
