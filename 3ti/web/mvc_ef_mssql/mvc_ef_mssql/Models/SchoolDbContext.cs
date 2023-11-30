using Microsoft.EntityFrameworkCore;

namespace mvc_ef_mssql.Models
{
    public class SchoolDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    Age = 23
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Monika",
                    LastName = "Kika",
                    Age = 22
                },
                new Student
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
