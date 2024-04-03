using System.Text.Json;

namespace cw3_razor_vs.Models
{
    public class UserRepo
    {
        public List<User>? Users { get; set; }
        private readonly string _filename;

        public List<User>? FromJson()
        {
            string json = System.IO.File.ReadAllText(_filename);

            List<User>? users = JsonSerializer.Deserialize<List<User>>(json);
            return users;

        }

        public UserRepo(string filename="dane.json")
        {
            _filename = filename;
            Users = FromJson();
        }
    }
}
