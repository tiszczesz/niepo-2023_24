using Microsoft.EntityFrameworkCore;

namespace WebAppMysqlEF.Models;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
    }

    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.Entity<Car>().Property(p => p.Price).HasPrecision(10, 2);
        modelBuilder.Entity<Car>().HasData(
            new Car {
                Id = 1, Name = "Fiat", Description = "Jak zawsze nie rdzewieje",
                Price = 7000, Year = 2001
            },
            new Car {
                Id = 2,
                Name = "Opel",
                Description = "Jak zawsze rdzewieje",
                Price = 23000,
                Year = 2019
            },
            new Car {
                Id = 3,
                Name = "VW",
                Description = "Jak zawsze nie rdzewieje",
                Price = 33000,
                Year = 2021
            },
            new Car {
                Id = 4,
                Name = "Seat",
                Description = "....",
                Price = 17000,
                Year = 2017
            }
        );
    }
}