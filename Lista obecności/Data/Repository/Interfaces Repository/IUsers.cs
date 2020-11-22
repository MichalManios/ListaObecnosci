using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data.Repository
{
    public interface IUsers
    {
        IEnumerable<IdentityUser> GetAllUsers();
        bool AddNew(Users users);
        bool Modify(Users users);
        bool Delete(Users users);
        bool SaveChanges();
        List<IdentityUser> GetAll();
    }
}
