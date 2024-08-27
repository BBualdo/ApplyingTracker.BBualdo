using Data.Models;

namespace Services;

public class ApplicationsService : IApplicationsService
{
    public Task<IEnumerable<Application>> GetApplications(int page)
    {
        throw new NotImplementedException();
    }

    public Task AddApplication(Application application)
    {
        throw new NotImplementedException();
    }

    public Task UpdateApplication(Application application)
    {
        throw new NotImplementedException();
    }

    public Task DeleteApplication(Application application)
    {
        throw new NotImplementedException();
    }
}