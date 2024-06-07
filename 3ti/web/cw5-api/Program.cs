using cw5_api;

var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("MysqlConn")
    ?? "Server=localhost;Database=3ti_2023_24_cw5;Uid=root;";

//builder.Services.AddSingleton<IUserRepo, UserRepo>();//tylko jeden obiekt
//builder.Services.AddScoped<IUserRepo, UserRepo>();//jeden obiekt na cały Request
//builder.Services.AddTransient<IUserRepo, UserRepo>();//przy każdym zapytaniu nowy obiekt
//builder.Services.AddTransient<IUserRepo, FakeUserRepo>();//przy każdym zapytaniu nowy obiekt
//builder.Services.AddTransient<IUserRepo, UserRepo>();//przy każdym zapytaniu nowy obiekt
builder.Services.AddTransient<IUserRepo>(provider => new UserRepo(connString));
var app = builder.Build();
var repo = app.Services.GetService<IUserRepo>();

app.MapGet("/api",() => repo?.GetUsers());
 app.MapGet("/", () => "Hello World!");

app.Run();
