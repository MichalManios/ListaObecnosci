using Lista_obecności.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_obecności.Data
{
    public interface IRepository<Entity> where Entity : BaseEntity
    {

        bool AddNew(Entity entity);
        bool Modify(Entity entity);
        bool Delete(Entity entity);
        bool SaveChanges();
        List<Entity> GetAll();
    }
}
