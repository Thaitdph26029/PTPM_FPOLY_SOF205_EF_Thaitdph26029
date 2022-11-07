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
    public class QLSpService: IQLSPService
    {
        ISanPhamRepository _isanPhamRepository;
        private IchitietSPRepositories _ichitietSPRepositories = new chitietSPRepositories();
        List<SanPham> _lstSanPham;
        private SanPham _sanPham = new SanPham();
        public QLSpService()
        {
            _isanPhamRepository = new SanPhamRepository();
            _lstSanPham = new List<SanPham>();
        }

        public string addSanPham(SpView SpView)
        {
            var _sanPham = new SanPham()
            { 
                Id = SpView.Id,
                Ma = SpView.Ma,
                Ten = SpView.Ten,
            };

            _isanPhamRepository.addSanPham(_sanPham);
            return "Thêm sản phẩm thành công";
        }

        public string deleteSanPham(SpView SpView)
        {
            var lstSp =
              (from a in _ichitietSPRepositories.GetAll()
               where a.IdSp == SpView.Id
               select a).ToList();
            if (lstSp.Count == 0)
            {
                var _sanPham = new SanPham()
                {
                    Id = SpView.Id,
                    Ma = SpView.Ma,
                    Ten = SpView.Ten,
                };

                if (_isanPhamRepository.deleteSanPham(_sanPham)) return "Xóa thành công";
                return "Xóa thất bại";
            }
            else
            {
                return "Khoong the xoa nha";
            }
        }

        public List<SpView> GetAllSanPham()
        {
            List<SpView> lstSp = new List<SpView>();
            lstSp = (from a in _isanPhamRepository.GetAllSanPham()
                             select new SpView()
                             {
                                 Id = a.Id,
                                 Ma = a.Ma,
                                 Ten = a.Ten,
                             }).ToList();
            return lstSp;
        }

        public string updateSanPham(SpView SpView)
        {
            var _sanPham = new SanPham()
            {
                Id = SpView.Id,
                Ma = SpView.Ma,
                Ten = SpView.Ten,
            };

            _isanPhamRepository.updateSanPham(_sanPham);
            return "Sửa sản phẩm thành công";
        }
    }
}
