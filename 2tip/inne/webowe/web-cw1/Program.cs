var builder = WebApplication.CreateBuilder(args);
//wstrzykiwanie middleware
builder.Services.AddRazorPages();
var app = builder.Build();
//używanie dodatkowych ....
app.UseStaticFiles();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/szkola", () => "Witaj Szkola!");
app.MapRazorPages();

app.Run();
//Daj znać jak skończysz lub będziesz chciał zacząć PHP