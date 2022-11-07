using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _Dbcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public List<HoaDon> _lstHoadon;
        public bool AddHoaDon(HoaDon HoaDon)
        {
            if (HoaDon == null) return false;
            _Dbcontext.HoaDons.Add(HoaDon);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(HoaDon HoaDon)
        {
            if (HoaDon == null) return false;
            var tempobj = _Dbcontext.HoaDons.FirstOrDefault(x => x.Id == HoaDon.Id);
            _Dbcontext.Remove(tempobj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return _Dbcontext.HoaDons.ToList();
        }

        public bool UpdateHoaDon(HoaDon HoaDon)
        {
            if (HoaDon == null) return false;
            var tempobj = _Dbcontext.HoaDons.FirstOrDefault(c => c.Id == HoaDon.Id);
            tempobj.IdKh = HoaDon.IdKh;
            tempobj.IdNv = HoaDon.IdNv;
            tempobj.Ma = HoaDon.Ma;
            tempobj.NgayTao = HoaDon.NgayTao;
            tempobj.NgayThanhToan = HoaDon.NgayThanhToan;
            tempobj.NgayShip = HoaDon.NgayShip;
            tempobj.NgayNhan = HoaDon.NgayNhan;
            tempobj.TinhTrang = HoaDon.TinhTrang;
            tempobj.TenNguoiNhan = HoaDon.TenNguoiNhan;
            tempobj.DiaChi = HoaDon.DiaChi;
            tempobj.Sdt = HoaDon.Sdt;
            _Dbcontext.HoaDons.Update(tempobj);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
