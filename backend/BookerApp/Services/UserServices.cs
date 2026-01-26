using BookerApp.Entities;
using BookerApp.Data;

namespace BookerApp.Services;
public class UserService :IUserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    //Get all users 
    public List<User> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    //Get user by id
    public User GetUserById(int id)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == id);
        return user;
    }

    //Add a new user
    public User CreateUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return user;
    }

    //Update a user
    public User UpdateUser(int id, User user)
    {
        var existing = _context.Users.FirstOrDefault(u => u.Id == id);
        if (existing == null) 
            throw new Exception("User not found");

        existing.Username = user.Username;
        existing.Email = user.Email;

        _context.SaveChanges();
        return existing;
    }

    //Delete a user by id
    public void DeleteUser(int id)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == id);
        if (user == null)
            throw new KeyNotFoundException("User not found");

        _context.Users.Remove(user);
        _context.SaveChanges();
    }
}
