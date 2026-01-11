namespace RaptorsWWW.Models;

public class TeamStanding
{
    public int Position { get; set; }
    public string TeamName { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
    public int GamesPlayed { get; set; }
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }
    public int GoalsFor { get; set; }
    public int GoalsAgainst { get; set; }
    public int GoalDifference => GoalsFor - GoalsAgainst;
    public int Points => (Wins * 3) + Draws;
    public bool IsRaptors { get; set; }
}
