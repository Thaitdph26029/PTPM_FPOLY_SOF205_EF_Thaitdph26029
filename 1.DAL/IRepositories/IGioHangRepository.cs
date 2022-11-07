using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangRepository
    {
        bool addGiohang(GioHang GioHang);
        bool updateGiohang(GioHang GioHang);
        bool deleteGiohang(GioHang GioHang);
        List<GioHang> GetAllGiohang();
    }
}
