using ConsoleApp59.Data;
using ConsoleApp59.Methods;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp59.Service;

public class UserService
{
    private readonly SpotifyTaskDbContext _context;

    public UserService(SpotifyTaskDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }
    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }
    public async Task AddUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}
