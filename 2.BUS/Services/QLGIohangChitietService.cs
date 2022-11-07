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
    public class QLGIohangChitietService : IQLGiohangChitietService
    {
        private IGiohangChitietRepository _igiohangChitietRepository = new GiohangChitietRepository();
        private IchitietSPRepositories _ichitietSPRepositories = new chitietSPRepositories();
        private IGioHangRepository _igioHangRepository = new GiohangRepository();
        private ISanPhamRepository _isanPhamRepository = new SanPhamRepository();
        private GioHangChiTiet _ghct = new GioHangChiTiet();

        public QLGIohangChitietService()
        {

        }
        public string AddGiohangChitiet(GiohangChitietView GiohangChitietView)
        {
            var lst = (from a in _igiohangChitietRepository.GetAllGiohangChitiet()
                       where a.IdChiTietSp == GiohangChitietView.IdCTSanpham && a.IdGioHang == GiohangChitietView.IdGh
                       select a).ToList();
            if (lst.Count == 0)
            {
                if (GiohangChitietView == null) return "Thêm thất bại";
                _ghct = new GioHangChiTiet()
                {
                    IdGioHang = GiohangChitietView.IdGh,
                    IdChiTietSp = GiohangChitietView.IdCTSanpham,
                    SoLuong = GiohangChitietView.SoLuong,
                    DonGia = GiohangChitietView.DonGia,
                    DonGiaKhiGiam = GiohangChitietView.DonGiaKhiGiam,
                };
                if (_igiohangChitietRepository.AddGiohangChitiet(_ghct)) return "Thêm thành công";
                return "Thêm thất bại";
            }
            else
            {
                return "Khong the them ";
            }
        }

        public string DeleteGiohangChitiet(GiohangChitietView GiohangChitietView)
        {
            if (GiohangChitietView == null) return "Xóa thất bại";
            var _lstghct = _igiohangChitietRepository.GetAllGiohangChitiet().Where(x => x.IdChiTietSp == GiohangChitietView.IdCTSanpham && x.IdGioHang == GiohangChitietView.IdGh).ToList();
            if (_lstghct.Count == 1)
            {
                _ghct = new GioHangChiTiet()
                {
                    IdGioHang = GiohangChitietView.IdGh,
                    IdChiTietSp = GiohangChitietView.IdCTSanpham,

                };
                if (_igiohangChitietRepository.DeleteGiohangChitiet(_ghct)) return "Xóa thành công";
                return "Xóa thất bại";
            }
            else
            {
                return "Không thể xóa do chưa có dữ liệu";
            }
        }

        public List<GiohangChitietView> GetAllGiohangChitiet(Guid idgh)
        {
            var lstghct = (from a in _igiohangChitietRepository.GetAllGiohangChitiet()
                           join b in _ichitietSPRepositories.GetAll() on a.IdChiTietSp equals b.Id
                           join c in _igioHangRepository.GetAllGiohang() on a.IdGioHang equals c.Id
                           join d in _isanPhamRepository.GetAllSanPham() on b.IdSp equals d.Id
                           where a.IdGioHang == idgh
                           select new GiohangChitietView()
                           {
                               MaGH = c.Ma,
                               TenSP = d.Ten,
                               SoLuong = a.SoLuong,
                               DonGia = a.DonGia,
                               DonGiaKhiGiam = a.DonGiaKhiGiam
                           }).ToList();
            return lstghct;
        }

        public string UpdateGiohangChitiet(GiohangChitietView GiohangChitietView)
        {
            if (GiohangChitietView == null) return "Sửa thất bại";
            var _lstghct = _igiohangChitietRepository.GetAllGiohangChitiet().Where(x => x.IdChiTietSp == GiohangChitietView.IdCTSanpham && x.IdGioHang == GiohangChitietView.IdGh).ToList();
            if (_lstghct.Count == 1)
            {
                _ghct = new GioHangChiTiet()
                {
                    IdGioHang = GiohangChitietView.IdGh,
                    IdChiTietSp = GiohangChitietView.IdCTSanpham,
                    SoLuong = GiohangChitietView.SoLuong,
                    DonGia = GiohangChitietView.DonGia,
                    DonGiaKhiGiam = GiohangChitietView.DonGiaKhiGiam,
                };
                if (_igiohangChitietRepository.UpdateGiohangChitiet(_ghct)) return "Sửa thành công";
                return "Sửa thất bại";
            }
            else
            {
                return "Không thể Sửa do chưa có dữ liệu";
            }
        }
    }
}
