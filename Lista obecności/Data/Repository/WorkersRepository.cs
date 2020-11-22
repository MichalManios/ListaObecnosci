using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data.Repository
{
    public class WorkersRepository : BaseRepository<Workers>, IWorkers
    {
        protected override DbSet<Workers> DbSet => mDbContext.Workers;
        public WorkersRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {

        }
        public IEnumerable<Workers> GetAllWorkers()
        {
            return DbSet.Select(x => x);
        }


        public ICollection<string> GetAllSection()
        {
            ICollection<string> sectionWithoutDouble = new List<string>();
            var allSection = DbSet.Select(x => x.Section);
            foreach (var section in allSection)
            {
                if (sectionWithoutDouble.Count==0) sectionWithoutDouble.Add(section);
                else
                {
                    if (sectionWithoutDouble.All(x => x != section)) sectionWithoutDouble.Add(section);
                }
            }
            return sectionWithoutDouble;
        }
    }
}
