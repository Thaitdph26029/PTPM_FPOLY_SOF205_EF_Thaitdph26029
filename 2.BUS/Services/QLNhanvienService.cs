using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _1.DAL.Repositories.Models;
using _2.BUS.IService;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLNhanvienService : IQLNhanvienService
    {
        private INhanVienRepository _inhanVienRepository = new NhanvienRepository();
        private ICuaHangRepository _icuaHangRepository = new CuahangRepository();
        private IChucVuRepository _iChucvuRepository = new ChucVuRepository();
        private NhanVien _nv = new NhanVien();
        public QLNhanvienService()
        {

        }

        public string AddNhanvien(NhanvienView obj)
        {
            if (obj == null) return "Thêm thất bại";
            _nv = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh,
                IdCv = obj.IdCv,
                TrangThai = obj.TrangThai,
            };
            if (_inhanVienRepository.AddNhanvien(_nv)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string DeleteNhanvien(NhanvienView obj)
        {

            _nv = new NhanVien()
            {
                Id = obj.Id,
                
            };
            if (_inhanVienRepository.DeleteNhanVien(_nv)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<NhanvienView> GetAllNhanvien()
        {
            List<NhanvienView> lstNhanvienView = new List<NhanvienView>();
            lstNhanvienView =
                (from a in _inhanVienRepository.GetAllNhanVien()
                 join b in _iChucvuRepository.GetAllChucVu() on a.IdCv equals b.Id
                 join c in _icuaHangRepository.GetAllCuahang() on a.IdCh equals c.Id
                 select new NhanvienView()
                 {
                     Id = a.Id,
                     Ma = a.Ma,
                     Ten = a.Ten,
                     TenDem = a.TenDem,
                     Ho = a.Ho,
                     GioiTinh = a.GioiTinh,
                     NgaySinh = a.NgaySinh,
                     DiaChi = a.DiaChi,
                     Sdt = a.Sdt,
                     MatKhau = a.MatKhau,
                     TenCh = c.Ten,
                     TenCv = b.Ten,
                     TrangThai = a.TrangThai
                 }).ToList();
            return lstNhanvienView;
        }

        public string UpdateNhanvien(NhanvienView obj)
        {
            if (obj == null) return "Sửa thất bại";
            _nv = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh,
                IdCv = obj.IdCv,
                TrangThai = obj.TrangThai,
            };
            if (_inhanVienRepository.UpdateNhanVien(_nv)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
