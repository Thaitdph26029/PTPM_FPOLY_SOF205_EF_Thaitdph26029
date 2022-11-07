using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IMauSacRepository
    {
        bool addMauSac(MauSac mauSac);
        bool updateMauSac(MauSac mauSac);
        bool deleteMauSac( MauSac mauSac);
        List<MauSac> GetAllMauSac();
    }
}
