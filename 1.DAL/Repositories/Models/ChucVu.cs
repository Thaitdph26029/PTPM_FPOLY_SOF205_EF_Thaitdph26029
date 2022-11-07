using System;
using System.Collections.Generic;

#nullable disable

namespace _1.DAL.Repositories.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
