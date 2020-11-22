using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data.Repository
{
    public interface IWorkers:IRepository<Workers>
    {
        IEnumerable<Workers> GetAllWorkers();
        ICollection<string> GetAllSection();
    }
}
