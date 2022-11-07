using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class CuahangRepository : ICuaHangRepository
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        List<CuaHang> _lstCuaHang;
        public CuahangRepository()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstCuaHang = new List<CuaHang>();
        }
        public bool addCuahang(CuaHang CuaHang)
        {
            _DBcontext.CuaHangs.Add(CuaHang);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteCuahang( CuaHang CuaHang)
        {
            if (CuaHang == null) return false;         
            foreach (var x in GetAllCuahang().Where(x => x.Id == CuaHang.Id))
            {
                _DBcontext.CuaHangs.Remove(x);
                _DBcontext.SaveChanges();
            }
            return true;
        }

        public List<CuaHang> GetAllCuahang()
        {
            _lstCuaHang = _DBcontext.CuaHangs.ToList();
            return _lstCuaHang;
        }

        public bool updateCuahang( CuaHang CuaHang)
        {
            if (CuaHang == null) return false;

            foreach (CuaHang a in GetAllCuahang().Where(x => x.Id == CuaHang.Id))
            {
                a.Ma = CuaHang.Ma;
                a.Ten = CuaHang.Ten;
                a.DiaChi = CuaHang.DiaChi;
                a.ThanhPho = CuaHang.ThanhPho;
                a.QuocGia = CuaHang.QuocGia;
                _DBcontext.Update(a);
                _DBcontext.SaveChanges();
            }
            return true;
        }
    }
}
