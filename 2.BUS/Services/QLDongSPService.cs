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
    public class QLDongSPService: IQLDongSpService
    {
        IDongSpRepository _idongSpRepository;
        IchitietSPRepositories _chitietSPRepositories = new chitietSPRepositories();
        DongSp DongSP;
        List<DongSp> _lstDongSp;
        public QLDongSPService()
        {
            _idongSpRepository = new DongSpRepository();
            _lstDongSp = new List<DongSp>();
        }

        public string addDongSpc(DongSpView DongSpView)
        {
            DongSP = new DongSp()
            {
                Id = DongSpView.Id,
                Ma = DongSpView.Ma,
                Ten = DongSpView.Ten,
            };
            _idongSpRepository.addDongSp(DongSP);
            return "Thêm thành công";
        }

        public string deleteDongSp(DongSpView DongSpView)
        {

            var lstDongSp =
             (from a in _chitietSPRepositories.GetAll()
              where a.IdDongSp == DongSpView.Id
              select a).ToList();
            if (lstDongSp.Count == 0)
            {
                DongSP = new DongSp()
                {
                    Id = DongSpView.Id,
                    Ma = DongSpView.Ma,
                    Ten = DongSpView.Ten,
                };
                if (_idongSpRepository.deleteDongSp(DongSP)) return "Xóa thành công";
                return "Xóa thất bại";
            }
            else
            {
                return "Khoong the xoa nha";
            }

        }

        public List<DongSpView> GetAllDongSp()
        {
            List<DongSpView> lstDongSpView = new List<DongSpView>();
            lstDongSpView = (from a in _idongSpRepository.GetAllDongSp()
                              select new DongSpView()
                              {
                                Id   = a.Id,
                                Ma = a.Ma,
                                Ten= a.Ten,
                              }).ToList();
            return lstDongSpView;
        }

        public string updateDongSp(DongSpView DongSpView)
        {
            DongSP = new DongSp()
            {
                Id = DongSpView.Id,
                Ma = DongSpView.Ma,
                Ten = DongSpView.Ten,
            };
            if (_idongSpRepository.updateDongSp(DongSP)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
