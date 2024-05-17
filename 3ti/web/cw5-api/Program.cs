var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("MysqlConn")
    ?? "Server=localhost;Database=3ti_2023_24_cw5;Uid=root;";


var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.Run();
