using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class chitietSPRepositories : IchitietSPRepositories
    {
        public FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _Dbcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        public List<ChiTietSp> _lstChitietSp;
        public chitietSPRepositories()
        {
            _lstChitietSp = new List<ChiTietSp>();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            _Dbcontext.ChiTietSps.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _Dbcontext.ChiTietSps.FirstOrDefault(x => x.Id == obj.Id);
            _Dbcontext.Remove(tempobj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _Dbcontext.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _Dbcontext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdSp = obj.IdSp;
            tempobj.IdNsx = obj.IdNsx;
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdDongSp = obj.IdDongSp;
            tempobj.NamBh = obj.NamBh;
            tempobj.MoTa = obj.MoTa;
            tempobj.SoLuongTon = obj.SoLuongTon;
            tempobj.GiaNhap = obj.GiaNhap;
            tempobj.GiaBan = obj.GiaBan;          
            _Dbcontext.ChiTietSps.Update(tempobj);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
