using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data.Repository
{
    public class FreeDaysRepository : BaseRepository<FreeDays>, IFreeDays
    {
        protected override DbSet<FreeDays> DbSet => mDbContext.FreeDays;
        public FreeDaysRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {

        }
        public IEnumerable<FreeDays> GetAllFreeDays()
        {
            return DbSet.Select(x => x);
        }
    }
}
