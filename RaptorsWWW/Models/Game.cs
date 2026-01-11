namespace RaptorsWWW.Models;

public class Game
{
    public int Id { get; set; }
    public DateTime GameDate { get; set; }
    public string Opponent { get; set; } = string.Empty;
    public string OpponentLogoUrl { get; set; } = string.Empty;
    public bool IsHomeGame { get; set; }
    public string Venue { get; set; } = string.Empty;
    public string Competition { get; set; } = "League";
    public int? HomeScore { get; set; }
    public int? AwayScore { get; set; }
    public bool IsCompleted => HomeScore.HasValue && AwayScore.HasValue;

    public int? RaptorsScore => IsHomeGame ? HomeScore : AwayScore;
    public int? OpponentScore => IsHomeGame ? AwayScore : HomeScore;

    public GameResult? Result
    {
        get
        {
            if (!IsCompleted) return null;
            if (RaptorsScore > OpponentScore) return GameResult.Win;
            if (RaptorsScore < OpponentScore) return GameResult.Loss;
            return GameResult.Draw;
        }
    }
}

public enum GameResult
{
    Win,
    Loss,
    Draw
}
