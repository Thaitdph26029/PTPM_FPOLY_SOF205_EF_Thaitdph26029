using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGiohangChitietRepository
    {
        bool AddGiohangChitiet(GioHangChiTiet GioHangChiTiet);
        bool UpdateGiohangChitiet(GioHangChiTiet GioHangChiTiet);
        bool DeleteGiohangChitiet(GioHangChiTiet GioHangChiTiet);
        ChiTietSp GetById(Guid id);//Phương thức tìm sp theo id
        List<GioHangChiTiet> GetAllGiohangChitiet();
    }
}
