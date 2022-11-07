using _1.DAL.Repositories.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLKhachhangService
    {
        string addKhachHang(KhachhangView KhachhangView);
        string updateKhachHang(KhachhangView KhachhangView);
        string deleteKhachHang(KhachhangView KhachhangView);
        List<KhachhangView> GetAllKhachHang();
    }
}
