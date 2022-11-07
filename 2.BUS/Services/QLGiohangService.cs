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
    public class QLGiohangService : IQLGiohangService

    {
        private IGioHangRepository _igioHangRepository = new GiohangRepository();
        private INhanVienRepository _inhanVienRepository = new NhanvienRepository();
        private IHoaDonRepository _ihoaDonRepository = new HoaDonRepository();
        private IKhachHangRepository _ikhachHangRepository = new KhachhangRepository();
        private GioHang _gh = new GioHang();
        private List<GiohangView> _ghList = new List<GiohangView>();
        public QLGiohangService()
        {
            _ghList = new List<GiohangView>();
        }
        public string addGiohang(GiohangView GiohangView)
        {
            if (GiohangView == null) return "Thêm thất bại";
            _gh = new GioHang()
            {
                Id = GiohangView.Id,
                IdKh = GiohangView.IdKh,
                IdNv = GiohangView.IdNv,
                Ma = GiohangView.Ma,
                NgayTao = GiohangView.NgayTao,
                NgayThanhToan = GiohangView.NgayThanhToan,
                TinhTrang = GiohangView.TinhTrang,
                TenNguoiNhan = GiohangView.TenNguoiNhan,
                DiaChi = GiohangView.DiaChi,
                Sdt = GiohangView.Sdt,
            };
            if (_igioHangRepository.addGiohang(_gh)) return "Thêm thành công";
            return "Thêm thất bại";

        }

        public string deleteGiohang(GiohangView GiohangView)
        {
            if (GiohangView == null) return "Xóa thất bại";
            _gh = new GioHang()
            {
                Id = GiohangView.Id,
                IdKh = GiohangView.IdKh,
                IdNv = GiohangView.IdNv,
            };
            if (_igioHangRepository.deleteGiohang(_gh)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<GiohangView> Getallgiohang()
        {
            _ghList = (from a in _igioHangRepository.GetAllGiohang()
                       join b in _ikhachHangRepository.GetAllKhachhang() on a.IdKh equals b.Id
                       join c in _inhanVienRepository.GetAllNhanVien() on a.IdNv equals c.Id
                       select new GiohangView()
                       {
                           Id = a.Id,
                           Ma = a.Ma,
                           TenKh = b.Ten,
                           TenNv = c.Ten,
                           NgayTao = a.NgayTao,
                           NgayThanhToan = a.NgayThanhToan,
                           TenNguoiNhan = a.TenNguoiNhan,
                           DiaChi = a.DiaChi,
                           Sdt = a.Sdt,
                           TinhTrang = a.TinhTrang,
                       }).ToList();
            return _ghList;
        }

        public string updateGiohang(GiohangView GiohangView)
        {
            if (GiohangView == null) return "Sửa thất bại";
            _gh = new GioHang()
            {
                Id = GiohangView.Id,
                IdKh = GiohangView.IdKh,
                IdNv = GiohangView.IdNv,
                Ma = GiohangView.Ma,
                NgayTao = GiohangView.NgayTao,
                NgayThanhToan = GiohangView.NgayThanhToan,
                TinhTrang = GiohangView.TinhTrang,
                TenNguoiNhan = GiohangView.TenNguoiNhan,
                DiaChi = GiohangView.DiaChi,
                Sdt = GiohangView.Sdt,
            };
            if (_igioHangRepository.updateGiohang(_gh)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
