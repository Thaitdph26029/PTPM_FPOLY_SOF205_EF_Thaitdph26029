using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class GiohangChitietRepository : IGiohangChitietRepository
    {
        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _Dbcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public GioHangChiTiet ghct = new GioHangChiTiet();
        public List<GioHangChiTiet> _lstGiohangChitiet;
        public GiohangChitietRepository()
        {
            _lstGiohangChitiet = new List<GioHangChiTiet>();
        }
        public bool AddGiohangChitiet(GioHangChiTiet GioHangChiTiet)
        {
            if (GioHangChiTiet == null) return false;
            _Dbcontext.GioHangChiTiets.Add(GioHangChiTiet);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool DeleteGiohangChitiet(GioHangChiTiet GioHangChiTiet)
        {
            if (GioHangChiTiet == null) return false;
            ghct = _Dbcontext.GioHangChiTiets.FirstOrDefault(x => x.IdChiTietSp == GioHangChiTiet.IdChiTietSp && x.IdGioHang == GioHangChiTiet.IdGioHang);
            _Dbcontext.GioHangChiTiets.Remove(ghct);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> GetAllGiohangChitiet()
        {
            _lstGiohangChitiet = _Dbcontext.GioHangChiTiets.ToList();
            return _lstGiohangChitiet;
        }

        public ChiTietSp GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateGiohangChitiet(GioHangChiTiet GioHangChiTiet)
        {
            if (GioHangChiTiet == null) return false;
            ghct = _Dbcontext.GioHangChiTiets.FirstOrDefault(x => x.IdChiTietSp == GioHangChiTiet.IdChiTietSp && x.IdGioHang == GioHangChiTiet.IdGioHang);
            ghct.SoLuong = GioHangChiTiet.SoLuong;
            ghct.DonGia = GioHangChiTiet.DonGia;
            ghct.DonGiaKhiGiam = GioHangChiTiet.DonGiaKhiGiam;
            _Dbcontext.GioHangChiTiets.Update(ghct);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
