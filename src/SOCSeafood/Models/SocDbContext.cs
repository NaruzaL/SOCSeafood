using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SOCSeafood.Models;

namespace SOCSeafood.Models
{
    public class SocDbContext : IdentityDbContext<ApplicationUser>
    {
        public SocDbContext()
        {

        }
        public virtual DbSet<Newsletter> Newsletters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SocSeafood;integrated security=True");
        }
        public SocDbContext(DbContextOptions<SocDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
