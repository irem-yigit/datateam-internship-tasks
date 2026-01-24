using BookerApp.Entities;
using BookerApp.Data;


namespace BookerApp.Services;
public interface IUserService
{
    List<User> GetAllUsers();
    void Create(User user);
    void Update(int id, User user);
    void Delete(int id);
}