using RaptorsWWW.Models;

namespace RaptorsWWW.Services;

public class TeamDataService
{
    public List<Player> GetPlayers()
    {
        return new List<Player>
        {
            // Goalkeepers
            new Player { Id = 1, JerseyNumber = 1, FirstName = "Lucas", LastName = "Martinez", Position = PlayerPosition.Goalkeeper, PhotoUrl = "images/players/player-placeholder.png", Description = "Team captain and starting goalkeeper with excellent reflexes.", DateOfBirth = new DateTime(2012, 3, 15) },
            new Player { Id = 2, JerseyNumber = 12, FirstName = "Noah", LastName = "Williams", Position = PlayerPosition.Goalkeeper, PhotoUrl = "images/players/player-placeholder.png", Description = "Reliable backup goalkeeper with great communication skills.", DateOfBirth = new DateTime(2013, 7, 22) },

            // Defenders
            new Player { Id = 3, JerseyNumber = 2, FirstName = "Ethan", LastName = "Johnson", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "Strong right-back known for his speed and tackles.", DateOfBirth = new DateTime(2012, 5, 8) },
            new Player { Id = 4, JerseyNumber = 3, FirstName = "Mason", LastName = "Brown", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "Left-back with excellent crossing ability.", DateOfBirth = new DateTime(2012, 11, 3) },
            new Player { Id = 5, JerseyNumber = 4, FirstName = "Oliver", LastName = "Davis", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "Center-back and defensive leader.", DateOfBirth = new DateTime(2012, 1, 19) },
            new Player { Id = 6, JerseyNumber = 5, FirstName = "William", LastName = "Garcia", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "Tall center-back great in the air.", DateOfBirth = new DateTime(2012, 9, 27) },

            // Midfielders
            new Player { Id = 7, JerseyNumber = 6, FirstName = "James", LastName = "Rodriguez", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "Defensive midfielder with excellent positioning.", DateOfBirth = new DateTime(2012, 4, 12) },
            new Player { Id = 8, JerseyNumber = 8, FirstName = "Benjamin", LastName = "Wilson", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "Box-to-box midfielder with endless energy.", DateOfBirth = new DateTime(2012, 6, 30) },
            new Player { Id = 9, JerseyNumber = 10, FirstName = "Alexander", LastName = "Anderson", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "Creative playmaker and set-piece specialist.", DateOfBirth = new DateTime(2012, 2, 14) },
            new Player { Id = 10, JerseyNumber = 14, FirstName = "Daniel", LastName = "Thomas", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "Right winger with great dribbling skills.", DateOfBirth = new DateTime(2013, 1, 5) },
            new Player { Id = 11, JerseyNumber = 11, FirstName = "Henry", LastName = "Jackson", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "Left winger known for his pace.", DateOfBirth = new DateTime(2012, 8, 18) },

            // Forwards
            new Player { Id = 12, JerseyNumber = 9, FirstName = "Sebastian", LastName = "White", Position = PlayerPosition.Forward, PhotoUrl = "images/players/player-placeholder.png", Description = "Clinical striker and top scorer.", DateOfBirth = new DateTime(2012, 10, 9) },
            new Player { Id = 13, JerseyNumber = 7, FirstName = "Jack", LastName = "Harris", Position = PlayerPosition.Forward, PhotoUrl = "images/players/player-placeholder.png", Description = "Versatile forward who can play anywhere in attack.", DateOfBirth = new DateTime(2012, 12, 1) },
            new Player { Id = 14, JerseyNumber = 17, FirstName = "Michael", LastName = "Martin", Position = PlayerPosition.Forward, PhotoUrl = "images/players/player-placeholder.png", Description = "Young talent with great potential.", DateOfBirth = new DateTime(2013, 3, 25) },
        };
    }

    public List<Coach> GetCoaches()
    {
        return new List<Coach>
        {
            new Coach { Id = 1, FirstName = "David", LastName = "Smith", Role = CoachRole.HeadCoach, PhotoUrl = "images/coaches/coach-placeholder.png", Description = "UEFA B licensed coach with 10 years of youth development experience.", Credentials = "UEFA B License" },
            new Coach { Id = 2, FirstName = "Robert", LastName = "Thompson", Role = CoachRole.AssistantCoach, PhotoUrl = "images/coaches/coach-placeholder.png", Description = "Former professional player focused on tactical development.", Credentials = "UEFA C License" },
            new Coach { Id = 3, FirstName = "Michael", LastName = "Lee", Role = CoachRole.GoalkeeperCoach, PhotoUrl = "images/coaches/coach-placeholder.png", Description = "Specialized goalkeeper training and development.", Credentials = "FA Goalkeeper Coach" },
            new Coach { Id = 4, FirstName = "Sarah", LastName = "Johnson", Role = CoachRole.TeamManager, PhotoUrl = "images/coaches/coach-placeholder.png", Description = "Team operations, scheduling, and parent communication.", Credentials = "Team Administrator" },
        };
    }

    public List<Game> GetGames()
    {
        var today = DateTime.Today;
        return new List<Game>
        {
            // Past games (Results)
            new Game { Id = 1, GameDate = today.AddDays(-35), Opponent = "Eagles FC", IsHomeGame = true, Venue = "Raptors Field", Competition = "League", HomeScore = 3, AwayScore = 1, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 2, GameDate = today.AddDays(-28), Opponent = "Thunder SC", IsHomeGame = false, Venue = "Thunder Park", Competition = "League", HomeScore = 2, AwayScore = 2, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 3, GameDate = today.AddDays(-21), Opponent = "Lions United", IsHomeGame = true, Venue = "Raptors Field", Competition = "Cup", HomeScore = 4, AwayScore = 0, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 4, GameDate = today.AddDays(-14), Opponent = "Wolves FC", IsHomeGame = false, Venue = "Wolf Den Stadium", Competition = "League", HomeScore = 1, AwayScore = 2, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 5, GameDate = today.AddDays(-7), Opponent = "Phoenix Rising", IsHomeGame = true, Venue = "Raptors Field", Competition = "League", HomeScore = 2, AwayScore = 1, OpponentLogoUrl = "images/teams/team-placeholder.png" },

            // Upcoming games (Schedule)
            new Game { Id = 6, GameDate = today.AddDays(7), Opponent = "Hawks Athletic", IsHomeGame = false, Venue = "Hawks Stadium", Competition = "League", OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 7, GameDate = today.AddDays(14), Opponent = "Bears FC", IsHomeGame = true, Venue = "Raptors Field", Competition = "League", OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 8, GameDate = today.AddDays(21), Opponent = "Tigers SC", IsHomeGame = false, Venue = "Tiger Arena", Competition = "Cup", OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 9, GameDate = today.AddDays(28), Opponent = "Dragons United", IsHomeGame = true, Venue = "Raptors Field", Competition = "League", OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 10, GameDate = today.AddDays(35), Opponent = "Sharks FC", IsHomeGame = false, Venue = "Sharks Bay Field", Competition = "League", OpponentLogoUrl = "images/teams/team-placeholder.png" },
        };
    }

    public List<TeamStanding> GetStandings()
    {
        return new List<TeamStanding>
        {
            new TeamStanding { Position = 1, TeamName = "FC Raptors", GamesPlayed = 10, Wins = 7, Draws = 2, Losses = 1, GoalsFor = 22, GoalsAgainst = 8, IsRaptors = true, LogoUrl = "images/raptors-logo.png" },
            new TeamStanding { Position = 2, TeamName = "Eagles FC", GamesPlayed = 10, Wins = 6, Draws = 3, Losses = 1, GoalsFor = 18, GoalsAgainst = 9, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 3, TeamName = "Wolves FC", GamesPlayed = 10, Wins = 6, Draws = 2, Losses = 2, GoalsFor = 20, GoalsAgainst = 12, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 4, TeamName = "Thunder SC", GamesPlayed = 10, Wins = 5, Draws = 3, Losses = 2, GoalsFor = 16, GoalsAgainst = 10, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 5, TeamName = "Phoenix Rising", GamesPlayed = 10, Wins = 5, Draws = 2, Losses = 3, GoalsFor = 15, GoalsAgainst = 12, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 6, TeamName = "Hawks Athletic", GamesPlayed = 10, Wins = 4, Draws = 3, Losses = 3, GoalsFor = 14, GoalsAgainst = 13, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 7, TeamName = "Bears FC", GamesPlayed = 10, Wins = 4, Draws = 2, Losses = 4, GoalsFor = 12, GoalsAgainst = 14, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 8, TeamName = "Lions United", GamesPlayed = 10, Wins = 3, Draws = 3, Losses = 4, GoalsFor = 11, GoalsAgainst = 15, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 9, TeamName = "Tigers SC", GamesPlayed = 10, Wins = 2, Draws = 2, Losses = 6, GoalsFor = 10, GoalsAgainst = 18, LogoUrl = "images/teams/team-placeholder.png" },
            new TeamStanding { Position = 10, TeamName = "Dragons United", GamesPlayed = 10, Wins = 1, Draws = 2, Losses = 7, GoalsFor = 8, GoalsAgainst = 22, LogoUrl = "images/teams/team-placeholder.png" },
        };
    }

    public List<Photo> GetPhotos()
    {
        return new List<Photo>
        {
            new Photo { Id = 1, Title = "Team Photo 2024", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-30), Category = PhotoCategory.Team, Description = "Official team photo for the 2024 season" },
            new Photo { Id = 2, Title = "Training Session", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-7), Category = PhotoCategory.Training, Description = "Weekly training at Raptors Field" },
            new Photo { Id = 3, Title = "Match vs Eagles FC", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-35), Category = PhotoCategory.Match, Description = "Highlights from our 3-1 victory" },
            new Photo { Id = 4, Title = "Trophy Celebration", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-60), Category = PhotoCategory.Awards, Description = "Celebrating our tournament win" },
            new Photo { Id = 5, Title = "Community Event", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-14), Category = PhotoCategory.Events, Description = "Team participating in community soccer clinic" },
            new Photo { Id = 6, Title = "Pre-Season Camp", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-90), Category = PhotoCategory.Training, Description = "Intensive training during pre-season" },
            new Photo { Id = 7, Title = "Cup Match Action", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-21), Category = PhotoCategory.Match, Description = "Action shots from cup match vs Lions United" },
            new Photo { Id = 8, Title = "Team Building", ImageUrl = "images/gallery/gallery-placeholder.png", ThumbnailUrl = "images/gallery/gallery-placeholder.png", DateTaken = DateTime.Today.AddDays(-45), Category = PhotoCategory.Events, Description = "Team bonding activities" },
        };
    }

    public (string Title, string Description, List<string> Achievements) GetTeamInfo()
    {
        return (
            "FC Raptors",
            "FC Raptors is a youth soccer club dedicated to developing young players in a fun, competitive environment. Founded in 2018, we focus on technical skills, teamwork, and sportsmanship. Our mission is to help every player reach their potential while fostering a love for the beautiful game.",
            new List<string>
            {
                "2024 Spring League Champions",
                "2023 Fall Cup Runners-Up",
                "2023 Fair Play Award",
                "2022 Tournament Champions"
            }
        );
    }
}
