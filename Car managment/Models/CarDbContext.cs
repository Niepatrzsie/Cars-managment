using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_managment.Models
{
    public class CarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Connection String to Database");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
