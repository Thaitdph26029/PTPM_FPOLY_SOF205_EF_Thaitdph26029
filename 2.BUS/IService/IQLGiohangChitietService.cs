using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLGiohangChitietService
    {
        string AddGiohangChitiet(GiohangChitietView GiohangChitietView);
        string UpdateGiohangChitiet(GiohangChitietView GiohangChitietView);
        string DeleteGiohangChitiet(GiohangChitietView GiohangChitietView);
        //List<HoaDonChiTietView> GetAllHoaDonChitiet(Guid idhoadon);
        List<GiohangChitietView> GetAllGiohangChitiet(Guid idgh);
    }
}
