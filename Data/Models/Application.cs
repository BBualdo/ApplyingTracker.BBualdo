using System.ComponentModel;

namespace Data.Models;

public class Application
{
    public int Id { get; set; }
    [DisplayName("Company Name")] public string? CompanyName { get; set; }
    public DateOnly Date { get; set; }
    [DisplayName("With Cover Letter?")] public bool IsCoverLetterIncluded { get; set; }
    public StatusOptions Status { get; set; }
}