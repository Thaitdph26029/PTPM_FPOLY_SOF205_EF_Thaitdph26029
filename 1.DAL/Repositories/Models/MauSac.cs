using System;
using System.Collections.Generic;

#nullable disable

namespace _1.DAL.Repositories.Models
{
    public partial class MauSac
    {
        public MauSac()
        {
            ChiTietSps = new HashSet<ChiTietSp>();
        }

        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<ChiTietSp> ChiTietSps { get; set; }
    }
}
