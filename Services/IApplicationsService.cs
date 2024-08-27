using Data.Models;

namespace Services;

public interface IApplicationsService
{
    Task<IEnumerable<Application>> GetApplications(int page);
    Task AddApplication(Application application);
    Task UpdateApplication(Application application);
    Task DeleteApplication(Application application);
}