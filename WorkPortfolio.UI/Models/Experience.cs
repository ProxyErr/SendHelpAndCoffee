namespace WorkPortfolio.UI.Models;

/// <summary>
/// Represents a professional experience/job entry.
/// Update content in PortfolioService.GetExperiences()
/// </summary>
public class Experience
{
    public string Id { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string? EndDate { get; set; }
    public string Summary { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
}
