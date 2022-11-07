using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChucVuRepository
    {
        bool addChucVu(ChucVu ChucVu);
        bool updateChucVu( ChucVu ChucVu);
        bool deleteChucVu( ChucVu ChucVu);
        List<ChucVu> GetAllChucVu();
    }
}
