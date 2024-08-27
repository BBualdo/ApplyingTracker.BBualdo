namespace Data.Models;

public class Application
{
    public int Id { get; set; }
    public string? CompanyName { get; set; }
    public DateOnly Date { get; set; }
    public bool IsCoverLetterIncluded { get; set; }
    public StatusOptions Status { get; set; }
}