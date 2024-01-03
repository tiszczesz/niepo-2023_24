using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WFandSqliteEFver1.Data
{
    public class SqliteDbContext:DbContext
    {
        public SqliteDbContext() {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=gifts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Gift>().HasData(
                new Gift{Id = 1,Name = "Kolejka",Description = "Kolejka PIKO",Price = 23.99M},
                new Gift{Id = 2,Name = "Kolejka2",Description = "Kolejka PIKO",Price = 23.99M},
                new Gift{Id = 3,Name = "Kolejka3",Description = "Kolejka PIKO",Price = 12},
                new Gift{Id = 4,Name = "Kolejka4",Description = "Kolejka PIKO",Price = 44.89m},
                new Gift{Id = 5,Name = "Kolejka5",Description = "Kolejka PIKO",Price = 11.99M}
                );
        }

        public DbSet<Gift> Gifts { get; set; }
    }
}
