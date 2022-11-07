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
    public class QLNsxService: IQLNsxService
    {
        private INSXRepository _inSXRepository;
        private IchitietSPRepositories _ichitietSPRepositories = new chitietSPRepositories();
        private List<Nsx> _lstNsx;
        private Nsx _nsx = new Nsx();
        public QLNsxService()
        {
            _inSXRepository = new NsxRepository();
            _lstNsx = new List<Nsx>();
        }

        public string addNsx(NsxView NsxView)
        {
            _nsx = new Nsx()
            { 
                Id = NsxView.Id,
                Ma = NsxView.Ma,
                Ten = NsxView.Ten
            };

            _inSXRepository.addNsx(_nsx);
            return "Thêm nhà sản xuất thành công";
        }

        public string deleteNsx(NsxView NsxView)
        {
            var Nsxlst =
             (from a in _ichitietSPRepositories.GetAll()
              where a.IdNsx == NsxView.Id
              select a).ToList();
            if (Nsxlst.Count == 0)
            {
                _nsx = new Nsx()
                {
                    Id = NsxView.Id,
                    Ma = NsxView.Ma,
                    Ten = NsxView.Ten
                };
                if (_inSXRepository.deleteNsx(_nsx)) return "Xóa thành công";
                return "Xóa thất bại";
            }
            else
            {
                return "Khoong the xoa nha";
            }
        }

        public List<NsxView> GetAllNsx()
        {
            List<NsxView> lstNsx = new List<NsxView>();
            lstNsx = (from a in _inSXRepository.GetAllNsx()
                             select new NsxView()
                             {
                                 Id = a.Id,
                                 Ma = a.Ma,
                                 Ten = a.Ten
                             }).ToList();
            return lstNsx;
        }

        public string updateNsx(NsxView NsxView)
        {
            _nsx = new Nsx()
            {
                Id = NsxView.Id,
                Ma = NsxView.Ma,
                Ten = NsxView.Ten
            };
            _inSXRepository.updateNsx(_nsx);
            return "Sửa nhà sản xuất thành công";
        }
    }
}
