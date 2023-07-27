using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class UserDescriptionRepository : IRepository<UserDescription>
{
    private readonly AppDbContext _context;

    public UserDescriptionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserDescription>> GetAll()
    {
        var descriptions = await _context.UserDescriptions.ToListAsync();
        return descriptions;
    }

    public async Task<UserDescription> GetById(int id)
    {
        var description = await _context.UserDescriptions.FindAsync(id);
        return description;
    }

    public async Task<UserDescription> Create(UserDescription description)
    {
        _context.UserDescriptions.Add(description);
        await _context.SaveChangesAsync();
        return description;
    }

    public async Task<UserDescription> Update(UserDescription description)
    {
        _context.UserDescriptions.Update(description);
        await _context.SaveChangesAsync();
        return description;
    }

    public async Task Delete(UserDescription description)
    {
        _context.UserDescriptions.Remove(description);
        await _context.SaveChangesAsync();
    }
}