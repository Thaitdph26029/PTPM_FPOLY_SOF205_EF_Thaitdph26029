using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public  interface INhanVienRepository
    {
        bool AddNhanvien(NhanVien NhanVien);
        bool UpdateNhanVien(NhanVien NhanVien);
        bool DeleteNhanVien(NhanVien NhanVien);
        NhanVien GetById(Guid id);//Phương thức tìm sp theo id
        List<NhanVien> GetAllNhanVien();
    }
}
