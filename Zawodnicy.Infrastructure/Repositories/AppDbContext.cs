using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Infrastructure.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<SkiJumper> SkiJumper { get; set; } //dla pozostalych klas to samo

        //public DbSet<Coach> Coach { get; set; }
    }
}
