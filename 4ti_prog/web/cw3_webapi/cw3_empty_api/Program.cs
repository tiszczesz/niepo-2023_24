using cw3_empty_api;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<IStudentRepo,FakeStudentRepo>();     //przy każddym zapytaniu tworzymy nowy obiekt
//builder.Services.AddScoped<IStudentRepo,FakeStudentRepo>();        //trzymamy mozliwie jeden obiekt na cały Request
//builder.Services.AddSingleton<IStudentRepo,FakeStudentRepo>();    //używamy tylko jednego obiektu tylko jak zniknie tworzymy nowy
IStudentRepo repo = new FakeStudentRepo();
// tutaj dodaje sie funkcjonalnosci 

var app = builder.Build();
//tutaj uzywa sie funkcjonalnosci
app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");
app.MapGet("/students",()=>repo.GetAll());
app.Run();
