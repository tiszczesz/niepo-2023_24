var builder = WebApplication.CreateBuilder(args);
//wstrzykiwanie midlewar
var app = builder.Build();
//używanie dodatkowych ....
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");
app.MapGet("/szkola", () => "Witaj Szkola!");

app.Run();
