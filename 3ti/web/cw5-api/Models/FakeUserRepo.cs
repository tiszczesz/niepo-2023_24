
namespace cw5_api;

public class FakeUserRepo : IUserRepo
{
    public int Delete(int? id)
    {
        
        throw new NotImplementedException();
        
    }

    public User? GetUser(int? id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetUsers()
    {
        return new List<User>(){
            new User { Id = 1,Firstname="Adam", Lastname="Nowak",MyDate = DateTime.Now},
            new User { Id = 2,Firstname="Roman", Lastname="Nowak",MyDate = DateTime.Now},
            new User { Id = 3,Firstname="Tomasz", Lastname="Nowak",MyDate = DateTime.Now},
        };
    }

    public void Insert(User user)
    {
        throw new NotImplementedException();
    }

    public int Update(int? id, User user)
    {
        throw new NotImplementedException();
    }
}
