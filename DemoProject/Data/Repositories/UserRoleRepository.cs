using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class UserRoleRepository : IRepository<UserRole>
{
    private readonly AppDbContext _context;

    public UserRoleRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserRole>> GetAll()
    {
        var roles = await _context.UserRoles.ToListAsync();
        return roles;
    }

    public async Task<UserRole> GetById(int id)
    {
        var role = await _context.UserRoles.FindAsync(id);
        return role;
    }

    public async Task<UserRole> Create(UserRole role)
    {
        _context.UserRoles.Add(role);
        await _context.SaveChangesAsync();
        return role;
    }

    public async Task<UserRole> Update(UserRole role)
    {
        _context.UserRoles.Update(role);
        await _context.SaveChangesAsync();
        return role;
    }

    public async Task Delete(UserRole role)
    {
        _context.UserRoles.Remove(role);
        await _context.SaveChangesAsync();
    }
}