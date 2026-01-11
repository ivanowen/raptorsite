namespace RaptorsWWW.Models;

public class Player
{
    public int Id { get; set; }
    public int JerseyNumber { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}";
    public PlayerPosition Position { get; set; }
    public string PhotoUrl { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime? DateOfBirth { get; set; }
    public int? Age => DateOfBirth.HasValue ? (int)((DateTime.Today - DateOfBirth.Value).TotalDays / 365.25) : null;
}

public enum PlayerPosition
{
    Goalkeeper,
    Defender,
    Midfielder,
    Forward
}
