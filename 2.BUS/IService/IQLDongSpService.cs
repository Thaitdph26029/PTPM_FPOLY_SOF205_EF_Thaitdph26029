using _1.DAL.Repositories.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLDongSpService
    {
        string addDongSpc(DongSpView DongSpView);
        string updateDongSp(DongSpView DongSpView);
        string deleteDongSp(DongSpView DongSpView);
        
        List<DongSpView> GetAllDongSp();
    }
}
