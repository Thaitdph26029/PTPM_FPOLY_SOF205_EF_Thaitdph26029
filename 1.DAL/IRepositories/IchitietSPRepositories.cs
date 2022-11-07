using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IchitietSPRepositories
    {
        bool Add(ChiTietSp obj);
        bool Update(ChiTietSp obj);
        bool Delete(ChiTietSp obj);
        ChiTietSp GetById(Guid id);//Phương thức tìm sp theo id
        List<ChiTietSp> GetAll();
    }
}
