using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        bool addSanPham(SanPham SanPham);
        bool updateSanPham( SanPham SanPham);
        bool deleteSanPham( SanPham SanPham);
        List<SanPham> GetAllSanPham();
    }
}
