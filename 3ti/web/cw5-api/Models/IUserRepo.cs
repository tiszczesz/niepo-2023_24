namespace cw5_api;

public interface IUserRepo
{
    List<User> GetUsers();
    User? GetUser(int? id);
    int Delete(int? id);
     void Insert(User user);
    int Update(int? id,User user);
}
