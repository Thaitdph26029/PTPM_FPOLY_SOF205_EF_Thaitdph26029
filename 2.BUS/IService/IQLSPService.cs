using _1.DAL.Repositories.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLSPService
    {
        string addSanPham(SpView SpView);
        string updateSanPham(SpView SpView);
        string deleteSanPham(SpView SpView);
        List<SpView> GetAllSanPham();
    }
}
