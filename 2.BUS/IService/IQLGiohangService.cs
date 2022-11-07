using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLGiohangService
    {
        string addGiohang(GiohangView GiohangView);
        string updateGiohang(GiohangView GiohangView);
        string deleteGiohang(GiohangView GiohangView);       
        List<GiohangView> Getallgiohang();
    }
}
