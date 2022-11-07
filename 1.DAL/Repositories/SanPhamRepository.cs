using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRepository: ISanPhamRepository
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        List<SanPham> _lstSanPham;
        public SanPhamRepository()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstSanPham = new List<SanPham>();
        }

        public bool addSanPham(SanPham SanPham)
        {
            _DBcontext.SanPhams.Add(SanPham);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteSanPham (SanPham SanPham)
        {
            if (SanPham == null) return false;
            foreach (var x in GetAllSanPham().Where(x => x.Id == SanPham.Id))
            {
                _DBcontext.SanPhams.Remove(x);
                _DBcontext.SaveChanges();
            }
            return true;
        }

        public List<SanPham> GetAllSanPham()
        {
            _lstSanPham = _DBcontext.SanPhams.ToList();
            return _lstSanPham;
        }

        public bool updateSanPham( SanPham SanPham)
        {
            if (SanPham == null) return false;

            foreach (SanPham a in GetAllSanPham().Where(x => x.Id == SanPham.Id))
            {
                a.Ma = SanPham.Ma;
                a.Ten = SanPham.Ten;
                _DBcontext.Update(a);
                _DBcontext.SaveChanges();
            }
            return true;
        }
    }
}
