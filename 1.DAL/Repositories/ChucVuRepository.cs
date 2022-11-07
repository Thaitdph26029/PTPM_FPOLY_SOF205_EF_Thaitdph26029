using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        List<ChucVu> _chucVuList;
        public ChucVuRepository()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _chucVuList = new List<ChucVu>();
        }
        public bool addChucVu(ChucVu ChucVu)
        {
            _DBcontext.ChucVus.Add(ChucVu);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteChucVu( ChucVu chucVu)
        {
            if (chucVu == null) return false;
            foreach (var x in GetAllChucVu().Where(x => x.Id == chucVu.Id))
            {
                _DBcontext.ChucVus.Remove(x);
                _DBcontext.SaveChanges();
            }
            return true;
        }

        public List<ChucVu> GetAllChucVu()
        {
            _chucVuList =_DBcontext.ChucVus.ToList();
            return _chucVuList;
        }

        public bool updateChucVu( ChucVu chucVu)
        {
            if (chucVu == null) return false;

            foreach (ChucVu a in GetAllChucVu().Where(x => x.Id == chucVu.Id))
            {
                a.Ma = chucVu.Ma;
                a.Ten = chucVu.Ten;
                _DBcontext.Update(a);
                _DBcontext.SaveChanges();
            }
            return true;
        }
    }
}
