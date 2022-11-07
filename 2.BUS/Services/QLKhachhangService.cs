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
    public class QLKhachhangService: IQLKhachhangService
    {
        private IKhachHangRepository _ikhachHangRepository;
        private IHoaDonRepository _ihoaDonRepository = new HoaDonRepository();
        private KhachHang _kh = new KhachHang();
        private List<KhachHang> _lstkhachhang;
        public QLKhachhangService()
        {
            _ikhachHangRepository = new KhachhangRepository();
            _lstkhachhang = new List<KhachHang>();
        }

        public string addKhachHang(KhachhangView KhachhangView)
        {
            _kh = new KhachHang()
            {
                Id = KhachhangView.Id,
                Ma = KhachhangView.Ma,
                Ten = KhachhangView.Ten,
                TenDem = KhachhangView.TenDem,
                Ho = KhachhangView.Ho,
                NgaySinh = KhachhangView.NgaySinh,
                Sdt = KhachhangView.Sdt,
                DiaChi = KhachhangView.DiaChi,
                ThanhPho = KhachhangView.ThanhPho,
                QuocGia = KhachhangView.QuocGia,
                MatKhau = KhachhangView.MatKhau
            };
            _ikhachHangRepository.addKhachhang(_kh);
            return "Thêm thành công";
        }

        public string deleteKhachHang(KhachhangView KhachhangView)
        {
            var _lstHoadon =
                (from a in _ihoaDonRepository.GetAllHoaDon() where a.IdKh == KhachhangView.Id select a).ToList();
            if (_lstHoadon.Count ==0)
            {
                _kh = new KhachHang()
                {
                    Id = KhachhangView.Id,
                };
                _ikhachHangRepository.deleteKhachhang(_kh);
                return "Xóa khách hàng thành công";
            }
            else
            {
                return "Không thể xóa đâu";
            }    
        }

        public List<KhachhangView> GetAllKhachHang()
        {
            List<KhachhangView> lstkhachhang = new List<KhachhangView>();
            lstkhachhang = (from a in _ikhachHangRepository.GetAllKhachhang()
                             select new KhachhangView()
                             {
                                 Id = a.Id,
                                 Ma = a.Ma,
                                 Ten = a.Ten,
                                 TenDem = a.TenDem,
                                 Ho = a.Ho,
                                 NgaySinh = a.NgaySinh,
                                 Sdt = a.Sdt,
                                 DiaChi = a.DiaChi,
                                 ThanhPho = a.ThanhPho,
                                 QuocGia = a.QuocGia,
                                 MatKhau = a.MatKhau
                             }).ToList();
            return lstkhachhang;
        }

        public string updateKhachHang(KhachhangView KhachhangView)
        {
            _kh = new KhachHang()
            {
                Id = KhachhangView.Id,
                Ma = KhachhangView.Ma,
                Ten = KhachhangView.Ten,
                TenDem = KhachhangView.TenDem,
                Ho = KhachhangView.Ho,
                NgaySinh = KhachhangView.NgaySinh,
                Sdt = KhachhangView.Sdt,
                DiaChi = KhachhangView.DiaChi,
                ThanhPho = KhachhangView.ThanhPho,
                QuocGia = KhachhangView.QuocGia,
                MatKhau = KhachhangView.MatKhau
            };
            _ikhachHangRepository.updateKhachhang(_kh);
            return "Sửa khách hàng thành công";
        }
    }
}
