using DemoProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data.Repositories;

public class RequestRepository : IRepository<Request>
{
    private readonly AppDbContext _context;

    public RequestRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Request>> GetAll()
    {
        var requests = await _context.Requests.ToListAsync();
        return requests;
    }

    public async Task<Request> GetById(int id)
    {
        var request = await _context.Requests.FindAsync(id);
        return request;
    }

    public async Task<Request> Create(Request request)
    {
        _context.Requests.Add(request);
        await _context.SaveChangesAsync();
        return request;
    }

    public async Task<Request> Update(Request request)
    {
        _context.Requests.Update(request);
        await _context.SaveChangesAsync();
        return request;
    }

    public async Task Delete(Request request)
    {
        _context.Requests.Remove(request);
        await _context.SaveChangesAsync();
    }
}