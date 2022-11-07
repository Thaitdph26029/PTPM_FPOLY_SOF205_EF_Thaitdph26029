using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonChitietRepository : IHoaDonChitietRepository
    {
        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _Dbcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public List<HoaDonChiTiet> _lstHoadonChitiet;
        public bool AddHoaDonChitiet(HoaDonChiTiet HoaDonChiTiet)
        {
            if (HoaDonChiTiet == null) return false;
            _Dbcontext.HoaDonChiTiets.Add(HoaDonChiTiet);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDonChitiet(HoaDonChiTiet HoaDonChiTiet)
        {
            if (HoaDonChiTiet == null) return false;
            var tempobj = _Dbcontext.HoaDonChiTiets.FirstOrDefault(x => x.IdHoaDon == HoaDonChiTiet.IdHoaDon &&
             x.IdChiTietSp == HoaDonChiTiet.IdChiTietSp);
            _Dbcontext.Remove(tempobj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAllHoaDonChitiet()
        {
            return _Dbcontext.HoaDonChiTiets.ToList();
        }

        public bool UpdateHoaDonChitiet(HoaDonChiTiet HoaDonChiTiet)
        {
            
            if (HoaDonChiTiet == null) return false;
            var tempobj = _Dbcontext.HoaDonChiTiets.FirstOrDefault(c => c.IdChiTietSp == HoaDonChiTiet.IdChiTietSp && c.IdHoaDon == HoaDonChiTiet.IdHoaDon);
            tempobj.SoLuong = HoaDonChiTiet.SoLuong;
            tempobj.DonGia = HoaDonChiTiet.DonGia;  
           // tempobj.DonGiaKhi
            _Dbcontext.HoaDonChiTiets.Update(tempobj);
            _Dbcontext.SaveChanges();
            return true;

        }
    }
}
