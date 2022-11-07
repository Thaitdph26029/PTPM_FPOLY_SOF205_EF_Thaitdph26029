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
    public class QLHoaDonChiTietService : IQLHoaDonChiTietService
    {
        private IHoaDonChitietRepository _ihoaDonChitietRepository = new HoaDonChitietRepository();
        private IHoaDonRepository _iHoaDonRepository = new HoaDonRepository();
        private IchitietSPRepositories _ichitietSPRepositories = new chitietSPRepositories();
        private IMauSacRepository _iMauSacRepository = new MauSacRepository();
        private IDongSpRepository _idongSpRepository = new DongSpRepository();
        private INSXRepository _insxRepository = new NsxRepository();
        private ISanPhamRepository _isanPhamRepository = new SanPhamRepository();
        private HoaDonChiTiet _hdct = new HoaDonChiTiet();
        private HoaDonChiTietView hoaDonChiTietView = new HoaDonChiTietView();
        public QLHoaDonChiTietService()
        {

        }
        public string AddHoaDonChitiet(HoaDonChiTietView HoaDonChiTietView)
        {
            if (HoaDonChiTietView == null) return "Thêm thất bại";
            var lst = (from a in _ihoaDonChitietRepository.GetAllHoaDonChitiet()
                       where a.IdChiTietSp == HoaDonChiTietView.IdChitietSP && a.IdHoaDon == HoaDonChiTietView.IdHoadon
                       select a).ToList();
            if (lst.Count == 0)
            {
                _hdct = new HoaDonChiTiet()
                {
                    IdHoaDon = HoaDonChiTietView.IdHoadon,
                    IdChiTietSp = HoaDonChiTietView.IdChitietSP,
                    SoLuong = HoaDonChiTietView.SoLuong,
                    DonGia = HoaDonChiTietView.DonGia,
                };

                if (_ihoaDonChitietRepository.AddHoaDonChitiet(_hdct)) return "Thêm thành công";
                return "Thêm thất bại";
            }
            else
            {
                return "Thêm thất bại";
            }

        }

        public string DeleteHoaDonChitiet(HoaDonChiTietView HoaDonChiTietView)
        {
            var lst = (from a in _ihoaDonChitietRepository.GetAllHoaDonChitiet()
                       where a.IdChiTietSp == HoaDonChiTietView.IdChitietSP && a.IdHoaDon == HoaDonChiTietView.IdHoadon
                       select a).ToList();
            if (lst.Count ==1)
            {
                _hdct = new HoaDonChiTiet()
                {
                    IdHoaDon = HoaDonChiTietView.IdHoadon,
                    IdChiTietSp = HoaDonChiTietView.IdChitietSP,
                    SoLuong = HoaDonChiTietView.SoLuong,
                    DonGia = HoaDonChiTietView.DonGia,
                };
                if (_ihoaDonChitietRepository.DeleteHoaDonChitiet(_hdct)) return "Xóa thành công";
                return "Xóa thất bại";
            }    
            else
            {
                return "Có đâu mà xóa";
            }    
            
        }

        public List<HoaDonChiTietView> GetAllHoaDonChitiet(Guid idhoadon)
        {
            List<HoaDonChiTietView> lstHdCtView = new List<HoaDonChiTietView>();
            lstHdCtView =
                (from a in _ihoaDonChitietRepository.GetAllHoaDonChitiet()
                 join c in _ichitietSPRepositories.GetAll() on a.IdChiTietSp equals c.Id
                 join d in _idongSpRepository.GetAllDongSp() on c.IdDongSp equals d.Id
                 join e in _iMauSacRepository.GetAllMauSac() on c.IdMauSac equals e.Id
                 join f in _insxRepository.GetAllNsx() on c.IdNsx equals f.Id
                 join g in _isanPhamRepository.GetAllSanPham() on c.IdSp equals g.Id
                 where a.IdHoaDon == idhoadon
                 select new HoaDonChiTietView()
                 {
                     IdChitietSP = c.Id,
                     TenSp = g.Ten,
                     TenMau = e.Ten,
                     TenDong = d.Ten,
                     TenNsx = f.Ten,
                     SoLuong = a.SoLuong,
                     DonGia = a.DonGia,
                 }).ToList();
            return lstHdCtView;
        }
        public List<SanPhamView> GetAllSanPhamChitiet(Guid idsanpham)
        {
            List<SanPhamView> lstHdCtView = new List<SanPhamView>();
            lstHdCtView =
                (
                 from c in _ichitietSPRepositories.GetAll()
                 join d in _idongSpRepository.GetAllDongSp() on c.IdDongSp equals d.Id
                 join e in _iMauSacRepository.GetAllMauSac() on c.IdMauSac equals e.Id
                 join f in _insxRepository.GetAllNsx() on c.IdNsx equals f.Id
                 join g in _isanPhamRepository.GetAllSanPham() on c.IdSp equals g.Id
                 where c.Id == idsanpham
                 select new SanPhamView()
                 {
                     Id = c.Id,
                     TenDongSp = d.Ten,
                     TenMauSac = e.Ten,
                     TenNsx = f.Ten,
                     Tensp = g.Ten,
                 }).ToList();
            return lstHdCtView;
        }
        public string UpdateHoaDonChitiet(HoaDonChiTietView HoaDonChiTietView)
        {
            if (HoaDonChiTietView == null) return "Sửa thất bại";
            var lst = (from a in _ihoaDonChitietRepository.GetAllHoaDonChitiet()
                       where a.IdChiTietSp == HoaDonChiTietView.IdChitietSP && a.IdHoaDon == HoaDonChiTietView.IdHoadon
                       select a).ToList();
            if (lst.Count == 1)
            {
                _hdct = new HoaDonChiTiet()
                {
                    IdHoaDon = HoaDonChiTietView.IdHoadon,
                    IdChiTietSp = HoaDonChiTietView.IdChitietSP,
                    SoLuong = HoaDonChiTietView.SoLuong,
                    DonGia = HoaDonChiTietView.DonGia,
                };
                if (_ihoaDonChitietRepository.UpdateHoaDonChitiet(_hdct)) return "Sửa thành công";
                return "Sửa thất bại";
            }
            else
            {
                return "Sửa thất bại";
            }

        }
    }
}
