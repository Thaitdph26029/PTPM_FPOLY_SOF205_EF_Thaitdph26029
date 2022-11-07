using _1.DAL.Repositories.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface ICuahangService
    {
        string addCuahang(CuahangView CuahangView);
        string updateCuahang(CuahangView CuahangView);
        string deleteCuahang(CuahangView CuahangView);
       // bool Checknhanvien(CuahangView CuahangView);
        List<CuahangView> GetallCuahang();
    }
}
