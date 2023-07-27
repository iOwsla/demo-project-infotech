using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class ServiceCategoryRepository : IRepository<ServiceCategory>
{
    private readonly AppDbContext _context;

    public ServiceCategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ServiceCategory>> GetAll()
    {
        var categories = await _context.ServiceCategories.ToListAsync();
        return categories;
    }

    public async Task<ServiceCategory> GetById(int id)
    {
        var category = await _context.ServiceCategories.FindAsync(id);
        return category;
    }

    public async Task<ServiceCategory> Create(ServiceCategory category)
    {
        _context.ServiceCategories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<ServiceCategory> Update(ServiceCategory category)
    {
        _context.ServiceCategories.Update(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task Delete(ServiceCategory category)
    {
        _context.ServiceCategories.Remove(category);
        await _context.SaveChangesAsync();
    }
}