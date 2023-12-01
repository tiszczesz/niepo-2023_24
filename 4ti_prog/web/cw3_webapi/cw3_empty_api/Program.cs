using cw3_empty_api;

var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("mySqlConn")
  ?? "Server=localhost;Database=4ti_2023_apiStudents;Uid=root;";

builder.Services.AddTransient<IStudentRepo>(
  repo => new MysqlStudentRepo(connString)
);
//builder.Services.AddTransient<IStudentRepo>()//przy każddym zapytaniu tworzymy nowy obiekt
//builder.Services.AddScoped<IStudentRepo,FakeStudentRepo>();        //trzymamy mozliwie jeden obiekt na cały Request
//builder.Services.AddSingleton<IStudentRepo,FakeStudentRepo>();    //używamy tylko jednego obiektu tylko jak zniknie tworzymy nowy
//IStudentRepo repo = new MysqlStudentRepo(connString);
// tutaj dodaje sie funkcjonalnosci 

var app = builder.Build();

var repo = app.Services.GetService<IStudentRepo>() ?? new MysqlStudentRepo(connString);
//tutaj uzywa sie funkcjonalnosci
app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");
app.MapGet("/students", () => repo.GetAll());
app.MapGet("/students/{id}", (int? id) =>
{
  var student = repo.GetById(id);
  return student != null ? Results.Ok(student) : Results.NotFound();
});

app.MapPost("/students", (Student student) =>
{
  repo.Insert(student);
});

app.Run();
