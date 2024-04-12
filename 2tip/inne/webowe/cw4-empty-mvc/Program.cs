var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews(); //mvc

var app = builder.Build();
app.UseStaticFiles(); //wwwroot

app.MapDefaultControllerRoute();
//app.MapGet("/", () => "Hello World!");

app.Run();
