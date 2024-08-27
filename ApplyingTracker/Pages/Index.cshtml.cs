using Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace ApplyingTracker.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IApplicationsService _applicationsService;
    public IEnumerable<Application> Applications { get; set; } = [];
    
    public IndexModel(ILogger<IndexModel> logger, IApplicationsService applicationsService)
    {
        _logger = logger;
        _applicationsService = applicationsService;
    }

    public async Task OnGetAsync()
    {
        var applications = await _applicationsService.GetApplications(1);
        Applications = applications;
    }
}