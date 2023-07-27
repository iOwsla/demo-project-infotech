using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class UserRepository : IRepository<User>
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }

    public async Task<User> GetById(int id)
    {
        var user = await _context.Users.FindAsync(id);

        return user;
    }

    public async Task<User> Create(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<User> Update(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task Delete(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}