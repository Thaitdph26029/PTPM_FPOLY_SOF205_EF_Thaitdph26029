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
    public class QLHoaDonService : IQLHoaDonService
    {
        private IHoaDonRepository _iHoaDonRepository = new HoaDonRepository();
        private INhanVienRepository _inhanVienRepository = new NhanvienRepository();
        private IKhachHangRepository _ikhachHangRepository = new KhachhangRepository();
        private HoaDon _hoadon = new HoaDon();
        public QLHoaDonService()
        {

        }
        public string AddHoadon(HoaDonView HoaDonView)
        {
            if (HoaDonView == null) return "Thêm thất bại";
            _hoadon = new HoaDon()
            {
                Id = HoaDonView.Id,
                IdKh = HoaDonView.IdKh,
                IdNv = HoaDonView.IdNv,
                Ma = HoaDonView.Ma,
                NgayTao = HoaDonView.NgayTao,
                NgayThanhToan = HoaDonView.NgayThanhToan,
                NgayShip = HoaDonView.NgayShip,
                NgayNhan = HoaDonView.NgayNhan,
                TinhTrang = HoaDonView.TinhTrang,
                TenNguoiNhan = HoaDonView.TenNguoiNhan,
                DiaChi = HoaDonView.DiaChi,
                Sdt = HoaDonView.Sdt,
            };
            if (_iHoaDonRepository.AddHoaDon(_hoadon)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string DeleteHoadon(HoaDonView HoaDonView)
        {
            if (HoaDonView == null) return "Thêm thất bại";
            _hoadon = new HoaDon()
            {
                Id = HoaDonView.Id,
                IdKh = HoaDonView.IdKh,
                IdNv = HoaDonView.IdNv,
                Ma = HoaDonView.Ma,
                NgayTao = HoaDonView.NgayTao,
                NgayThanhToan = HoaDonView.NgayThanhToan,
                NgayShip = HoaDonView.NgayShip,
                NgayNhan = HoaDonView.NgayNhan,
                TinhTrang = HoaDonView.TinhTrang,
                TenNguoiNhan = HoaDonView.TenNguoiNhan,
                DiaChi = HoaDonView.DiaChi,
                Sdt = HoaDonView.Sdt,
            };
            if (_iHoaDonRepository.DeleteHoaDon(_hoadon)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public List<HoaDonView> GetAllHoadon()
        {
            List<HoaDonView> lstHoadon = new List<HoaDonView>();
            lstHoadon =
                (from a in _iHoaDonRepository.GetAllHoaDon()
                 join b in _ikhachHangRepository.GetAllKhachhang() on a.IdKh equals b.Id
                 join c in _inhanVienRepository.GetAllNhanVien() on a.IdNv equals c.Id
                 select new HoaDonView()
                 {
                     Id = a.Id,
                     TenKh = b.Ten,
                     TenNv = c.Ten,
                     Ma = a.Ma,
                     NgayTao = a.NgayTao,
                     NgayThanhToan = a.NgayThanhToan,
                     NgayShip = a.NgayShip,
                     NgayNhan = a.NgayNhan,
                     TinhTrang = a.TinhTrang,
                     TenNguoiNhan = a.TenNguoiNhan,
                     DiaChi = a.DiaChi,
                     Sdt = a.Sdt
                 }).ToList();
            return lstHoadon;
        }

        public string UpdateHoadon(HoaDonView HoaDonView)
        {
            if (HoaDonView == null) return "Thêm thất bại";
            _hoadon = new HoaDon()
            {
                Id = HoaDonView.Id,
                IdKh = HoaDonView.IdKh,
                IdNv = HoaDonView.IdNv,
                Ma = HoaDonView.Ma,
                NgayTao = HoaDonView.NgayTao,
                NgayThanhToan = HoaDonView.NgayThanhToan,
                NgayShip = HoaDonView.NgayShip,
                NgayNhan = HoaDonView.NgayNhan,
                TinhTrang = HoaDonView.TinhTrang,
                TenNguoiNhan = HoaDonView.TenNguoiNhan,
                DiaChi = HoaDonView.DiaChi,
                Sdt = HoaDonView.Sdt,
            };
            if (_iHoaDonRepository.UpdateHoaDon(_hoadon)) return "Thêm thành công";
            return "Thêm thất bại";
        }
    }
}
