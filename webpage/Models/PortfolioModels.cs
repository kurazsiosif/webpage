using System.Text.Json.Serialization;

namespace webpage.Models;

public class PortfolioData
{
    public Meta Meta { get; set; } = new();
    public List<RecentItem> Recent { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
    public List<Skill> Skills { get; set; } = new();
    public List<FocusItem> Focus { get; set; } = new();
}

public class Meta
{
    public string Name { get; set; } = "";
    public string Subtitle { get; set; } = "";
    public List<string> Pills { get; set; } = new();
    public string Email { get; set; } = "";
    public string Github { get; set; } = "";
    public string Linkedin { get; set; } = "";
    public string About { get; set; } = "";
    public List<Kpi> Kpis { get; set; } = new();
}

public class Kpi
{
    public string Value { get; set; } = "";
    public string Label { get; set; } = "";
}

public class RecentItem
{
    public string Title { get; set; } = "";
    public string When { get; set; } = "";
    public string Note { get; set; } = "";
}

public class Project
{
    public string Name { get; set; } = "";
    public string When { get; set; } = "";
    public string What { get; set; } = "";
    public Dictionary<string, string> Impact { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public List<Link> Links { get; set; } = new();
}

public class Link
{
    public string Label { get; set; } = "";
    public string Url { get; set; } = "";
}

public class Skill
{
    public string Name { get; set; } = "";
    public int Level { get; set; }
}

public class FocusItem
{
    public string Title { get; set; } = "";
    public string Note { get; set; } = "";
}
