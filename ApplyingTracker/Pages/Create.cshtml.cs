using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace ApplyingTracker.Pages;

public class CreateModel : PageModel
{
    private readonly IApplicationsService _applicationsService;
    [BindProperty] public Application Application { get; set; } = new();

    public CreateModel(IApplicationsService applicationsService)
    {
        _applicationsService = applicationsService;
    }
    
    public void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        await _applicationsService.AddApplication(Application);
        return Redirect("/");
    }
}