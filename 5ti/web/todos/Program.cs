using todos.Models;

var builder = WebApplication.CreateBuilder(args);
string? connString = builder.Configuration.GetConnectionString("mysqlConn");
var app = builder.Build();
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

app.Run();
