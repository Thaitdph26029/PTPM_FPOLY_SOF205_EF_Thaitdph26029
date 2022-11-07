using _1.DAL.Repositories.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IQLMauSacService
    {
        string addMauSac(MausacView MausacView);
        string updateMauSac(MausacView MausacView);
        string deleteMauSac(MausacView MausacView);
        List<MausacView> GetAllMauSac();
    }
}
