# EntityFramework

## Program.cs
```cs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
var app = builder.Build();

```

## DbContext
```cs
public class SchoolDbContext:DbContext
{
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
    :base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>().HasData(
            new Student {
                Id = 1,
                FirstName = "Adam",
                LastName = "Nowak",
                Age = 23
            },
            new Student
            {
                Id = 2,
                FirstName = "monika",
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
```

##  Dodanie Connection string w appconfig
* dla MSSQL 
```json
"ConnectionStrings": {
        "myConn": "Data Source=(localdb)\\MSSQLLocalDB;Database=MyMVC1;Integrated Security=True"
    }
```

* dla SQLite 
```json
"ConnectionStrings": {
        "myConn": "Data Source=LocalDatabase.db"
    }
```

* dla MySql
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=sp_cw1;User=root;Password=;"
  }
```