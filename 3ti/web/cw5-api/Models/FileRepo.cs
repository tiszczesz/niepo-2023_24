using System.Text.Json;

namespace cw5_api;

public class FileRepo : IUserRepo
{
    private readonly string _filePath;
    public FileRepo(string filePath)
    {
        _filePath = filePath;
    }
    private List<User> ReadUsersFromFile()
    {
        if (!File.Exists(_filePath))
        {
            return new List<User>();
        }

        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }
    public int Delete(int? id)
    {
        var users = ReadUsersFromFile();
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user == null)
        {
            return 0;
        }
        users.Remove(user);
        File.WriteAllText(_filePath, JsonSerializer.Serialize(users));
        return 1;
    }

    public User? GetUser(int? id)
    {
        var users = ReadUsersFromFile();
        return users.FirstOrDefault(u => u.Id == id);
    }

    public List<User> GetUsers()
    {
        return ReadUsersFromFile();
    }

    public void Insert(User user)
    {
        var users = ReadUsersFromFile();
        users.Add(user);
        File.WriteAllText(_filePath, JsonSerializer.Serialize(users));
    }

    public int Update(int? id, User user)
    {
        var users = ReadUsersFromFile();
        var existingUser = users.FirstOrDefault(u => u.Id == id);
        if (existingUser == null)
        {
            return 0;
        }
        users.Remove(existingUser);
        users.Add(user);
        File.WriteAllText(_filePath, JsonSerializer.Serialize(users));
        return 1;
    }
}