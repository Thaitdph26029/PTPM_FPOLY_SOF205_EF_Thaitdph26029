using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICuaHangRepository
    {
        bool addCuahang(CuaHang CuaHang);
        bool updateCuahang(CuaHang CuaHang);
        bool deleteCuahang( CuaHang CuaHang);
        List<CuaHang> GetAllCuahang();
    }
}
