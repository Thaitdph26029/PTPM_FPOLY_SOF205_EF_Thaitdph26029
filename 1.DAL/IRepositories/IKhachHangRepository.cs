using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        bool addKhachhang(KhachHang KhachHang);
        bool updateKhachhang( KhachHang KhachHang);
        bool deleteKhachhang( KhachHang KhachHang);
        List<KhachHang> GetAllKhachhang();
    }
}
