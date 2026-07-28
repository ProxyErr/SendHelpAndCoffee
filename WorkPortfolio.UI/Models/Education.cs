namespace WorkPortfolio.UI.Models;

/// <summary>
/// Represents an education entry.
/// Update content in PortfolioService.GetEducation()
/// </summary>
public class Education
{
    public string Id { get; set; } = string.Empty;
    public string School { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public string Field { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string? EndDate { get; set; }
    public string? Description { get; set; }
}
