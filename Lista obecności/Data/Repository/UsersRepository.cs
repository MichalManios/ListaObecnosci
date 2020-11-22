using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data.Repository
{
    public class UsersRepository :  IUsers
    {
        protected ApplicationDbContext dbContext;
        protected DbSet<IdentityUser> DbSet => dbContext.Users;
        public UsersRepository(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        public List<IdentityUser> GetAll()
        {
            var list = new List<IdentityUser>();
            var users = DbSet;

            foreach (var user in users)
            {
                list.Add(user);
            }
            return list;
        }
        public IEnumerable<IdentityUser> GetAllUsers()
        {
            return DbSet.Select(x => x);
        }
        public bool SaveChanges()
        {
            return dbContext.SaveChanges() > 0;
        }


        public bool AddNew(Users user)
        {
            DbSet.Add(user);
            return SaveChanges();
        }

        public bool Modify(Users user)
        {
            DbSet.Update(user);
            return SaveChanges();
        }

        public bool Delete(Users user)
        {
            var foundUser = DbSet.FirstOrDefault(x => x.Id == user.Id);

            if (foundUser != null)
            {
                DbSet.Remove(foundUser);

                return SaveChanges();
            }
            return false;
        }
    }
}
