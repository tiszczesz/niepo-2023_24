using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();
List<string> colors = new List<string>{"red","green","blue"};
app.MapGet("/", () => "Hello World!");
app.MapGet("/prog",()=>"A to jest od prog!!!");
app.MapGet("/date",()=>{
    return $"Data dzisiejsza:  {DateTime.Now.ToShortDateString()} aktualny czas: {DateTime.Now.ToLongTimeString()}";
});
app.MapGet("/colors",()=>{
    return colors;
    });
app.Run();
