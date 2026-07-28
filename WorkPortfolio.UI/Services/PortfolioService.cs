using WorkPortfolio.UI.Models;

namespace WorkPortfolio.UI.Services;

/// <summary>
/// Service providing all portfolio data (projects, experiences, education).
/// Update the placeholder data here to change portfolio content.
/// </summary>
public class PortfolioService
{
    // TODO: Update with your actual projects
    public List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = "PX-024",
                Title = "Orbit Commerce",
                Type = "Product Design + Engineering",
                Description = "A conversion-focused storefront for independent makers, built around tactile discovery and frictionless checkout.",
                Stack = new List<string> { "React", "TypeScript", "Stripe" },
                Status = "Live",
                Url = "#",
                GithubUrl = "#"
            },
            new Project
            {
                Id = "PX-019",
                Title = "Northstar OS",
                Type = "Design System",
                Description = "A modular interface language that unified analytics, operations, and customer tooling across one platform.",
                Stack = new List<string> { "Figma", "Storybook", "React" },
                Status = "Shipped",
                Url = "#",
                GithubUrl = "#"
            },
            new Project
            {
                Id = "PX-011",
                Title = "Signal Archive",
                Type = "Creative Development",
                Description = "An immersive editorial archive pairing generative visuals with a fast, accessible reading experience.",
                Stack = new List<string> { "WebGL", "GSAP", "Sanity" },
                Status = "Featured",
                Url = "#",
                GithubUrl = "#"
            }
        };
    }

    // TODO: Update with your actual capabilities/skills
    public Dictionary<string, int> GetCapabilities()
    {
        return new Dictionary<string, int>
        {
            { "Frontend systems", 96 },
            { "Product design", 90 },
            { "Creative direction", 86 },
            { "Rapid prototyping", 93 }
        };
    }

    // TODO: Update with your actual work experience
    public List<Experience> GetExperiences()
    {
        return new List<Experience>
        {
            new Experience
            {
                Id = "EXP-001",
                JobTitle = "Senior Frontend Engineer",
                Company = "Tech Company A",
                Location = "Remote",
                StartDate = "Jan 2023",
                EndDate = "Present",
                Summary = "Led frontend architecture and mentored junior developers on modern React patterns and performance optimization.",
                Tags = new List<string> { "React", "TypeScript", "Leadership", "Performance" }
            },
            new Experience
            {
                Id = "EXP-002",
                JobTitle = "Full Stack Developer",
                Company = "Tech Company B",
                Location = "New York, NY",
                StartDate = "Jun 2021",
                EndDate = "Dec 2022",
                Summary = "Developed and maintained full-stack applications using React and Node.js, improving site performance by 40%.",
                Tags = new List<string> { "React", "Node.js", "MongoDB", "AWS" }
            }
        };
    }

    // TODO: Update with your actual education
    public List<Education> GetEducation()
    {
        return new List<Education>
        {
            new Education
            {
                Id = "EDU-001",
                School = "State University",
                Degree = "Bachelor of Science",
                Field = "Computer Science",
                StartDate = "2017",
                EndDate = "2021",
                Description = "Focused on web development and software engineering best practices."
            }
        };
    }

    // Career summary shown on resume page
    public string GetCareerSummary()
    {
        return "I am a passionate and driven professional seeking opportunities that will leverage my extensive experience in frontend development while providing continuous growth and learning opportunities. My goal is to contribute to innovative projects that challenge me to expand my skill set and make meaningful impacts through technology.";
    }

    // Contact information
    public string GetEmail() => "your-email@example.com"; // TODO: Update
    public string GetGithub() => "https://github.com/yourusername"; // TODO: Update
    public string GetLinkedin() => "https://linkedin.com/in/yourusername"; // TODO: Update
    public string GetTwitter() => "https://twitter.com/yourusername"; // TODO: Update
}
