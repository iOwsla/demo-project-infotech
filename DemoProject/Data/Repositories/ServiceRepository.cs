using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class ServiceRepository : IRepository<Service>
{
    private readonly AppDbContext _context;

    public ServiceRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Service>> GetAll()
    {
        var services = await _context.Services.ToListAsync();
        return services;
    }

    public async Task<Service> GetById(int id)
    {
        var service = await _context.Services.FindAsync(id);
        return service;
    }

    public async Task<Service> Create(Service service)
    {
        _context.Services.Add(service);
        await _context.SaveChangesAsync();
        return service;
    }

    public async Task<Service> Update(Service service)
    {
        _context.Services.Update(service);
        await _context.SaveChangesAsync();
        return service;
    }

    public async Task Delete(Service service)
    {
        _context.Services.Remove(service);
        await _context.SaveChangesAsync();
    }
}