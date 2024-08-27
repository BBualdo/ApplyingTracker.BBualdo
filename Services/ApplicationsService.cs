using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Services;

public class ApplicationsService(AppDbContext dbContext) : IApplicationsService
{
    private readonly AppDbContext _dbContext = dbContext;
    
    public async Task<IEnumerable<Application>> GetApplications(int page)
    {
        const int pageSize = 10;

        return await _dbContext.Applications.Skip(pageSize * (page - 1)).Take(pageSize).ToListAsync();
    }

    public async Task AddApplication(Application application)
    {
        await _dbContext.Applications.AddAsync(application);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateApplication(Application application)
    {
        _dbContext.Entry(application).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteApplication(Application application)
    {
        _dbContext.Remove(application);
        await _dbContext.SaveChangesAsync();
    }
}