using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ChucVuView
    {
      //  public ChucVu ChucVu { get; set; }        
        public Guid ID { get; set; }
        public string? Ma { get; set; }
        public string?  Ten { get; set; }
    }
}
