using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDongSpRepository
    {
        bool addDongSp(DongSp DongSp);
        bool updateDongSp( DongSp DongSp);
        bool deleteDongSp( DongSp DongSp);
        List<DongSp> GetAllDongSp();
    }
}
