using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lista_obecności.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public override DbSet<IdentityUser> Users { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<FreeDays> FreeDays { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
