using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class DongSpRepository : IDongSpRepository
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        List<DongSp> _DongSp;
        public DongSpRepository()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _DongSp = new List<DongSp>();
        }
        public bool addDongSp(DongSp DongSp)
        {
            _DBcontext.DongSps.Add(DongSp);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteDongSp( DongSp DongSp)
        {
            if (DongSp == null) return false;
            foreach (var x in GetAllDongSp().Where(x => x.Id == DongSp.Id))
            {
                _DBcontext.DongSps.Remove(x);
                _DBcontext.SaveChanges();
            }
            return true;
        }

        public List<DongSp> GetAllDongSp()
        {
            _DongSp =_DBcontext.DongSps.ToList();
            return _DongSp;
        }

        public bool updateDongSp( DongSp DongSp)
        {
            if (DongSp == null) return false;

            foreach (DongSp a in GetAllDongSp().Where(x => x.Id == DongSp.Id))
            {
                a.Ma = DongSp.Ma;
                a.Ten = DongSp.Ten;
               
                _DBcontext.Update(a);
                _DBcontext.SaveChanges();
            }
            return true;
        }
    }
}
