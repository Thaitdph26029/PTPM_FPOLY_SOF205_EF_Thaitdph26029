using _1.DAL.IRepositories;
using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class KhachhangRepository: IKhachHangRepository

    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        List<KhachHang> _lstKhachhang;
        public KhachhangRepository()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstKhachhang = new List<KhachHang>();  
        }

        public bool addKhachhang(KhachHang KhachHang)
        {
            _DBcontext.KhachHangs.Add(KhachHang);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteKhachhang( KhachHang KhachHang)
        {
            if (KhachHang == null) return false;
            foreach (var x in GetAllKhachhang().Where(x => x.Id == KhachHang.Id))
            {
                _DBcontext.KhachHangs.Remove(x);
                _DBcontext.SaveChanges();
            }
            return true;
        }

        public List<KhachHang> GetAllKhachhang()
        {
            _lstKhachhang = _DBcontext.KhachHangs.ToList();
            return _lstKhachhang;
        }

        public bool updateKhachhang( KhachHang KhachHang)
        {
            if (KhachHang == null) return false;

            foreach (KhachHang a in GetAllKhachhang().Where(x => x.Id == KhachHang.Id))
            {
                a.Ma = KhachHang.Ma;
                a.Ten = KhachHang.Ten;
                a.TenDem = KhachHang.TenDem;
                a.Ho = KhachHang.Ho;
                a.NgaySinh = KhachHang.NgaySinh;
                a.Sdt = KhachHang.Sdt;
                a.DiaChi = KhachHang.DiaChi;
                a.ThanhPho = KhachHang.ThanhPho;
                a.QuocGia = KhachHang.QuocGia;
                a.MatKhau = KhachHang.MatKhau;
                _DBcontext.Update(a);
                _DBcontext.SaveChanges();
            }
            return true;
        }
    }
}
