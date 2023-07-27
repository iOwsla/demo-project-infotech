using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class CityRepository : IRepository<City>
{
    private readonly AppDbContext _context;

    public CityRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<City>> GetAll()
    {
        var cities = await _context.Cities.ToListAsync();
        return cities;
    }

    public async Task<City> GetById(int id)
    {
        var city = await _context.Cities.FindAsync(id);
        return city;
    }

    public async Task<City> Create(City city)
    {
        _context.Cities.Add(city);
        await _context.SaveChangesAsync();
        return city;
    }

    public async Task<City> Update(City city)
    {
        _context.Cities.Update(city);
        await _context.SaveChangesAsync();
        return city;
    }

    public async Task Delete(City city)
    {
        _context.Cities.Remove(city);
        await _context.SaveChangesAsync();
    }
}