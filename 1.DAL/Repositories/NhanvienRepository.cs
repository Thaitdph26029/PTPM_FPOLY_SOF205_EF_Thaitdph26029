using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanvienRepository : INhanVienRepository
    {
        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _Dbcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public List<NhanVien> _lstNhanvien;
        public NhanvienRepository()
        {
            _lstNhanvien = new List<NhanVien>();
        }
        public bool AddNhanvien(NhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            _Dbcontext.NhanViens.Add(NhanVien);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool DeleteNhanVien(NhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            var tempobj = _Dbcontext.NhanViens.FirstOrDefault(x => x.Id == NhanVien.Id);
            _Dbcontext.Remove(tempobj);
            _Dbcontext.SaveChanges();
            return true;           
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return _Dbcontext.NhanViens.ToList();
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _Dbcontext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        public bool UpdateNhanVien(NhanVien NhanVien)
        {
            if (NhanVien == null) return false;
            var tempobj = _Dbcontext.NhanViens.FirstOrDefault(c=>c.Id == NhanVien.Id);
            tempobj.Ma = NhanVien.Ma;
            tempobj.Ten = NhanVien.Ten;
            tempobj.TenDem = NhanVien.TenDem;
            tempobj.Ho = NhanVien.Ho;
            tempobj.GioiTinh = NhanVien.GioiTinh;
            tempobj.NgaySinh = NhanVien.NgaySinh;
            tempobj.DiaChi = NhanVien.DiaChi;
            tempobj.Sdt = NhanVien.Sdt;
            tempobj.MatKhau = NhanVien.MatKhau;
            tempobj.IdCh = NhanVien.IdCh;
            tempobj.IdCv = NhanVien.IdCv;
            tempobj.IdGuiBc = NhanVien.IdGuiBc;
            tempobj.TrangThai = NhanVien.TrangThai;
            _Dbcontext.NhanViens.Update(tempobj);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
