using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class MauSacRepository:IMauSacRepository
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<MauSac> _lstMauSac;
        public MauSacRepository()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstMauSac = new List<MauSac>();
        }

        public bool addMauSac(MauSac mauSac)
        {
            _DBcontext.MauSacs.Add(mauSac);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteMauSac( MauSac mauSac)
        {
            if (mauSac == null) return false;
            foreach (var x in GetAllMauSac().Where(x=>x.Id==mauSac.Id))
            {
                _DBcontext.MauSacs.Remove(x);
                _DBcontext.SaveChanges();
            }                               
            return true;
        }

        public List<MauSac> GetAllMauSac()
        {
            _lstMauSac = _DBcontext.MauSacs.ToList();
            return _lstMauSac;
        }

        public bool updateMauSac(MauSac mauSac)
        {
            if(mauSac == null) return false;

            foreach (MauSac a in GetAllMauSac().Where(x=>x.Id==mauSac.Id))
            {
                a.Ma = mauSac.Ma;
                a.Ten = mauSac.Ten;
                _DBcontext.Update(a);
                _DBcontext.SaveChanges();
            }

            
            return true;
        }
    }
}
