var builder = WebApplication.CreateBuilder(args);
// tutaj dodaje sie funkcjonalnosci 

var app = builder.Build();
//tutaj uzywa sie funkcjonalnosci
app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");

app.Run();
