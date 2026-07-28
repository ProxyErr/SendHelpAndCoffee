namespace WorkPortfolio.UI.Models;

/// <summary>
/// Represents a project in the portfolio.
/// Update content in PortfolioService.GetProjects()
/// </summary>
public class Project
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Stack { get; set; } = new();
    public string Status { get; set; } = string.Empty;
    public string? Url { get; set; }
    public string? GithubUrl { get; set; }
}
