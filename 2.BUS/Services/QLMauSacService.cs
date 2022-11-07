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
    public class QLMauSacService : IQLMauSacService
    {
        private IMauSacRepository _IMauSacRepository;
        private IchitietSPRepositories _ichitietSPRepositories = new chitietSPRepositories();
        private List<MauSac> _lstMauSac = new List<MauSac>();
        private MauSac _ms = new MauSac();
        public QLMauSacService()
        {
            _IMauSacRepository = new MauSacRepository();
            _lstMauSac = new List<MauSac>();
        }
        public string addMauSac(MausacView MausacView)
        {
            _ms = new MauSac()
            {
                Id = MausacView.Id,
                Ma = MausacView.Ma,
                Ten = MausacView.Ten,
            };
            _IMauSacRepository.addMauSac(_ms);
            return "Thêm thành công";
        }

        public string deleteMauSac(MausacView MausacView)
        {
            var Mausaclst =
              (from a in _ichitietSPRepositories.GetAll()
               where a.Id == MausacView.Id
               select a).ToList();
            if (Mausaclst.Count == 0)
            {
                _ms = new MauSac()
                {
                    Id = MausacView.Id,
                    Ma = MausacView.Ma,
                    Ten = MausacView.Ten,
                };
                _IMauSacRepository.deleteMauSac(_ms);
                return "Xóa thành công";
            }
            else
            {
                return "Khoong the xoa nha";
            }
        }

        public List<MausacView> GetAllMauSac()
        {
            List<MausacView> lstmausac = new List<MausacView>();
            lstmausac = (from a in _IMauSacRepository.GetAllMauSac()
                             select new MausacView()
                             {
                                 Id = a.Id,
                                 Ma = a.Ma,
                                 Ten = a.Ten,
                             }).ToList();
            return lstmausac;
        }

        public string updateMauSac(MausacView MausacView)
        {
            _ms = new MauSac()
            {
                Id = MausacView.Id,
                Ma = MausacView.Ma,
                Ten = MausacView.Ten,
            };
           
            _IMauSacRepository.updateMauSac(_ms);
            return "Update màu sắc thành công";
        }
    }
}
