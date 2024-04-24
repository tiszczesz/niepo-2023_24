namespace cw6_mvc.Models;

public class FilmsRepo
{
    private readonly string? _connString;
    public FilmsRepo(IConfiguration configuration){
        _connString = configuration.GetConnectionString("sqlite");
    }
}
