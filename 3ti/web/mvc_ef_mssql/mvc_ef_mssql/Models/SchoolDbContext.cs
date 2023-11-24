using Microsoft.EntityFrameworkCore;

namespace mvc_ef_mssql.Models
{
    public class SchoolDbContext:DbContext
    {
        public DbSet<MyStudent> Students { get; set; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MyStudent>().HasData(
                new MyStudent
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    Age = 23
                },
                new MyStudent
                {
                    Id = 2,
                    FirstName = "monika",
                    LastName = "Kika",
                    Age = 22
                },
                new MyStudent
                {
                    Id = 3,
                    FirstName = "Janusz",
                    LastName = "Banusz",
                    Age = 42
                }
                );
        }
    }
}
