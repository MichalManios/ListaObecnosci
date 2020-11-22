using Lista_obecności.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lista_obecności.Data
{
    public abstract class BaseRepository<Entity> : IRepository<Entity> where Entity : BaseEntity
    {
        protected ApplicationDbContext mDbContext;

        protected abstract DbSet<Entity> DbSet { get;}

        public BaseRepository(ApplicationDbContext dBContext)
        {
            mDbContext = dBContext;
        }

        public List<Entity> GetAll()
        {
            var list = new List<Entity>();
            var entitis = DbSet;

            foreach (var entity in entitis)
            {
                list.Add(entity);
            }
            return list;
        }

        public bool SaveChanges()
        {
            return mDbContext.SaveChanges() > 0;
        }

        
        public bool AddNew(Entity entity)
        {
            DbSet.Add(entity);
            return SaveChanges();
        }

        public bool Modify(Entity entity)
        {
            DbSet.Update(entity);
            return SaveChanges();

        }

        public bool Delete(Entity entity)
        {
            var foundEntity = DbSet.FirstOrDefault(x => x.Id == entity.Id);

            if (foundEntity != null)
            {
                DbSet.Remove(foundEntity);

                return SaveChanges();
            }
            return false;
        }
    }
}
