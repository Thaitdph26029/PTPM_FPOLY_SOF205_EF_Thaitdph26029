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
    public class QLSanPhamService : IQLSanPhamService
    {
        private IchitietSPRepositories _ichitietSPRepositories = new chitietSPRepositories();
        private IMauSacRepository _iMauSacRepository = new MauSacRepository();
        private IDongSpRepository _idongSpRepository = new DongSpRepository();
        private INSXRepository _insxRepository = new NsxRepository();
        private ISanPhamRepository _isanPhamRepository = new SanPhamRepository();
        ChiTietSp _chiTietSp = new ChiTietSp();
        public string AddChitietSp(SanPhamView obj)
        {
            if (obj == null) return "Thêm thất bại";
            _chiTietSp = new ChiTietSp()
            {
                Id = obj.Id,
                IdSp = obj.IdSp,
                IdNsx = obj.IdNsx,
                IdMauSac = obj.IdMauSac,
                IdDongSp = obj.IdDongSp,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            if (_ichitietSPRepositories.Add(_chiTietSp)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string DeleteChitietSp(SanPhamView obj)
        {
            _chiTietSp = new ChiTietSp()
            {
                Id = obj.Id,
                IdSp = obj.IdSp,
                IdNsx = obj.IdNsx,
                IdMauSac = obj.IdMauSac,
                IdDongSp = obj.IdDongSp,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            if (_ichitietSPRepositories.Delete(_chiTietSp)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<SanPhamView> GetAllChitietSp()
        {
            List<SanPhamView> lstchitietsp = new List<SanPhamView>();
            lstchitietsp =
                (from a in _ichitietSPRepositories.GetAll()
                 join b in _iMauSacRepository.GetAllMauSac() on a.IdMauSac equals b.Id
                 join c in _insxRepository.GetAllNsx() on a.IdNsx equals c.Id
                 join d in _idongSpRepository.GetAllDongSp() on a.IdDongSp equals d.Id
                 join e in _isanPhamRepository.GetAllSanPham() on a.IdSp equals e.Id
                 select new SanPhamView()
                 {
                     Id = a.Id,
                     Tensp = e.Ten,
                     TenNsx = c.Ten,
                     TenMauSac = b.Ten,
                     TenDongSp = d.Ten,
                     NamBh = a.NamBh,
                     MoTa = a.MoTa,
                     SoLuongTon = a.SoLuongTon,
                     GiaBan = a.GiaBan,
                     GiaNhap = a.GiaNhap,
                 }).ToList();
            return lstchitietsp;
        }

        public string UpdateChitietSp(SanPhamView obj)
        {
            if (obj == null) return "Sửa thất bại";
            _chiTietSp = new ChiTietSp()
            {
                Id = obj.Id,
                IdSp = obj.IdSp,
                IdNsx = obj.IdNsx,
                IdMauSac = obj.IdMauSac,
                IdDongSp = obj.IdDongSp,
                NamBh = obj.NamBh,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            if (_ichitietSPRepositories.Update(_chiTietSp)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
