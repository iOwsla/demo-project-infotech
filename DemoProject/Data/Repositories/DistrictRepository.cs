using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class DistrictRepository : IRepository<District>
{
    private readonly AppDbContext _context;

    public DistrictRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<District>> GetAll()
    {
        var districts = await _context.Districts.ToListAsync();
        return districts;
    }

    public async Task<District> GetById(int id)
    {
        var district = await _context.Districts.FindAsync(id);
        return district;
    }

    public async Task<District> Create(District district)
    {
        _context.Districts.Add(district);
        await _context.SaveChangesAsync();
        return district;
    }

    public async Task<District> Update(District district)
    {
        _context.Districts.Update(district);
        await _context.SaveChangesAsync();
        return district;
    }

    public async Task Delete(District district)
    {
        _context.Districts.Remove(district);
        await _context.SaveChangesAsync();
    }
}