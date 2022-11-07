
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
    public class QLCuahangService : ICuahangService
    {
        private ICuaHangRepository _icuahangRepository;
        private INhanVienRepository _inhanVienRepository;
        private CuaHang ch;
        public QLCuahangService()
        {
            _icuahangRepository = new CuahangRepository();
            _inhanVienRepository = new NhanvienRepository();
        }
        public string addCuahang(CuahangView CuahangView)
        {
            ch = new CuaHang()
            {
                Id = CuahangView.Id,
                Ma = CuahangView.Ma,
                Ten = CuahangView.Ten,
                DiaChi = CuahangView.DiaChi,
                ThanhPho = CuahangView.ThanhPho,
                QuocGia = CuahangView.QuocGia,
            };
            _icuahangRepository.addCuahang(ch);
            return "Thêm thành công";
        }      
        public string deleteCuahang(CuahangView CuahangView)
        {
            var NhanvienList =
             (from a in _inhanVienRepository.GetAllNhanVien()
              where a.IdCh == CuahangView.Id
              select a).ToList();
            if (NhanvienList.Count==0)
            {
                ch = new CuaHang()
                {
                    Id = CuahangView.Id,
                    Ma = CuahangView.Ma,
                    Ten = CuahangView.Ten,
                    DiaChi = CuahangView.DiaChi,
                    ThanhPho = CuahangView.ThanhPho,
                    QuocGia = CuahangView.QuocGia,
                };
                if (_icuahangRepository.deleteCuahang(ch)) return "Xóa thành công";
                return "Xóa thất bại";
            }
            else
            {
                return "Khoong the xoa nha";
            }
           
        }

        public List<CuahangView> GetallCuahang()
        {
            List<CuahangView> lstCuahangView = new List<CuahangView>();
            lstCuahangView = (from a in _icuahangRepository.GetAllCuahang()
                              select new CuahangView()
                              {
                                  Id = a.Id,
                                  Ma = a.Ma,
                                  Ten = a.Ten,
                                  DiaChi= a.DiaChi,
                                  ThanhPho = a.ThanhPho,
                                  QuocGia= a.QuocGia,
                              }).ToList();
                return lstCuahangView;
        }
       
        public string updateCuahang(CuahangView CuahangView)
        {
            ch = new CuaHang()
            {
                Id = CuahangView.Id,
                Ma = CuahangView.Ma,
                Ten = CuahangView.Ten,
                DiaChi = CuahangView.DiaChi,
                ThanhPho = CuahangView.ThanhPho,
                QuocGia = CuahangView.QuocGia,
            };
            if (_icuahangRepository.updateCuahang(ch)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
