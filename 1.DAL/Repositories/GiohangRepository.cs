using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class GiohangRepository : IGioHangRepository
    {
        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _Dbcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public List<GioHang> _lstGiohang;
        public GiohangRepository()
        {
            _lstGiohang = new List<GioHang>();
        }
        public bool addGiohang(GioHang GioHang)
        {
            _Dbcontext.GioHangs.Add(GioHang);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool deleteGiohang(GioHang GioHang)
        {
            if (GioHang == null) return false;
            foreach (var x in GetAllGiohang().Where(x => x.Id == GioHang.Id))
            {
                _Dbcontext.GioHangs.Remove(x);
                _Dbcontext.SaveChanges();
            }
            return true;
        }

        public List<GioHang> GetAllGiohang()
        {
            _lstGiohang = _Dbcontext.GioHangs.ToList();
            return _lstGiohang;
        }

        public bool updateGiohang(GioHang GioHang)
        {
            if (GioHang == null) return false;
            var tempobj = _Dbcontext.GioHangs.FirstOrDefault(c => c.Id == GioHang.Id);
           // tempobj.IdKh = GioHang.IdKh;
           // tempobj.IdNv = GioHang.IdNv;
            tempobj.Ma = GioHang.Ma;
            tempobj.NgayTao = GioHang.NgayTao;
            tempobj.NgayThanhToan = GioHang.NgayThanhToan;           
            tempobj.TinhTrang = GioHang.TinhTrang;
            tempobj.TenNguoiNhan = GioHang.TenNguoiNhan;
            tempobj.DiaChi = GioHang.DiaChi;
            tempobj.Sdt = GioHang.Sdt;
            _Dbcontext.GioHangs.Update(tempobj);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
