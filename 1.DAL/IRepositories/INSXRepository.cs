using _1.DAL.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INSXRepository
    {
        bool addNsx(Nsx Nsx);
        bool updateNsx( Nsx Nsx);
        bool deleteNsx( Nsx Nsx);
        List<Nsx> GetAllNsx();
    }
}
