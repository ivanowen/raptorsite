namespace RaptorsWWW.Models;

public class Photo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string ThumbnailUrl { get; set; } = string.Empty;
    public DateTime DateTaken { get; set; }
    public PhotoCategory Category { get; set; }
    public string Description { get; set; } = string.Empty;
}

public enum PhotoCategory
{
    Training,
    Match,
    Team,
    Events,
    Awards
}
