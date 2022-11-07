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
    public class QLChucVuService : IQLChucVuService
    {
        private IChucVuRepository ichucVuRepository;
        private INhanVienRepository _inhanvienRepository;
        private List<ChucVuView> _lstChucVu;
        private ChucVu cv;
        public QLChucVuService()
        {
            ichucVuRepository = new ChucVuRepository();
            _inhanvienRepository = new NhanvienRepository();
            _lstChucVu = new List<ChucVuView>();
        }
        public string addChucVu(ChucVuView ChucVuView)
        {
            ChucVu cv = new ChucVu()
            {
                Id = ChucVuView.ID,
                Ma = ChucVuView.Ma,
                Ten = ChucVuView.Ten
            };
            ichucVuRepository.addChucVu(cv);
            return "Thêm chức vụ thành công";
        }

        public string deleteChucVu(ChucVuView ChucVuView)
        {
            
            var NhanvienList =
            (from a in _inhanvienRepository.GetAllNhanVien()
             where a.IdCv == ChucVuView.ID 
             select a).ToList();
            if (NhanvienList.Count == 0)
            {
                ChucVu cv = new ChucVu()
                {
                    Id = ChucVuView.ID,
                    Ma = ChucVuView.Ma,
                    Ten = ChucVuView.Ten
                };
                if (ichucVuRepository.deleteChucVu(cv)) return "Xóa thành công";
                return "Xóa thất bại";
                          
            }
            else
            {
                return "Khoong the xoa nha";
            }
        }

        public List<ChucVuView> GetAllChucVu()
        {
            List<ChucVuView> _lstChucVu = new List<ChucVuView>();
            _lstChucVu = (from a in ichucVuRepository.GetAllChucVu()
                              select new ChucVuView()
                              {
                                  ID = a.Id,
                                  Ma= a.Ma,
                                  Ten= a.Ten ,
                              }).ToList();
            return _lstChucVu;

        }

        public string updateChucVu(ChucVuView ChucVuView)
        {
            ChucVu cv = new ChucVu()
            {
                Id = ChucVuView.ID,
                Ma = ChucVuView.Ma,
                Ten = ChucVuView.Ten
            };
            ichucVuRepository.updateChucVu(cv);
            return "Sửa chức vụ thành công";
        }
    }
}
