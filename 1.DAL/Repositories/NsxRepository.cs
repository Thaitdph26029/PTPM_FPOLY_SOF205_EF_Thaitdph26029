using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NsxRepository : INSXRepository
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        List<Nsx> _lstNsx;
        public NsxRepository()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstNsx = new List<Nsx>();  
        }

        public bool addNsx(Nsx Nsx)
        {
          _DBcontext.Nsxes.Add(Nsx);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteNsx( Nsx Nsx)
        {
            if (Nsx == null) return false;
            foreach (var x in GetAllNsx().Where(x => x.Id == Nsx.Id))
            {
                _DBcontext.Nsxes.Remove(x);
                _DBcontext.SaveChanges();
            }
            return true;
        }

        public List<Nsx> GetAllNsx()
        {
            _lstNsx = _DBcontext.Nsxes.ToList();
            return _lstNsx;
        }

        public bool updateNsx( Nsx Nsx)
        {
            if (Nsx == null) return false;

            foreach (Nsx a in GetAllNsx().Where(x => x.Id == Nsx.Id))
            {
                a.Ma = Nsx.Ma;
                a.Ten = Nsx.Ten;
                _DBcontext.Update(a);
                _DBcontext.SaveChanges();
            }
            return true;
        }
    }
}
