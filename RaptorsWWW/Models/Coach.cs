namespace RaptorsWWW.Models;

public class Coach
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}";
    public CoachRole Role { get; set; }
    public string PhotoUrl { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Credentials { get; set; } = string.Empty;
}

public enum CoachRole
{
    HeadCoach,
    AssistantCoach,
    GoalkeeperCoach,
    FitnessCoach,
    TeamManager
}
