using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLSanPhamService
    {
        string AddChitietSp(SanPhamView obj);
        string UpdateChitietSp(SanPhamView obj);
        string DeleteChitietSp(SanPhamView obj);
        List<SanPhamView> GetAllChitietSp(); 
    }
}
