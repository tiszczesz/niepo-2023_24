using todos.Models;

var builder = WebApplication.CreateBuilder(args);

//cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
        builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyMethod().AllowAnyHeader();            
        }
    );
});
string? connString = builder.Configuration.GetConnectionString("mysqlConn");
var app = builder.Build();

app.UseCors("MyPolicy");

TodoRepo repo = new TodoRepo(connString);
app.MapGet("/", () => "Hello World!");
app.MapGet("/todos", () => {
    var todos = repo.GetAll();
    if (todos.Count == 0) return Results.NotFound();
    return Results.Ok(todos);
});
app.MapGet("/todos/{id}", (int? id) => {
    var todo = repo.GetByIdTodo(id);
    if (todo == null) return Results.NotFound();
    return Results.Ok(todo);
});
app.MapPost("/todos", (Todo todo) => {
    repo.Insert(todo);
   // return Results.Created($"/todos/{todo.Id}", todo);
});
app.MapDelete("/todos/{id}", (int? id) => {
    repo.Delete(id);
});

app.MapPut("/todos/{id}", (int? id, Todo todo) => {
    repo.Update(id, todo);
});
app.Run();
