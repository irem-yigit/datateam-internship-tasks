using BookerApp.Entities;
using BookerApp.Data;

namespace BookerApp.Services;
public interface IUserService
{
    List<User> GetAllUsers();

    User GetUserById(int id);
    User CreateUser(User user);
    User UpdateUser(int id, User user);
    void DeleteUser(int id);
}