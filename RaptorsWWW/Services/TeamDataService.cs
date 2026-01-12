using RaptorsWWW.Models;

namespace RaptorsWWW.Services;

public class TeamDataService
{
    public List<Player> GetPlayers()
    {
        return new List<Player>
        {
            // Goalkeepers
            new Player { Id = 1, JerseyNumber = 22, FirstName = "Liam", LastName = "", Position = PlayerPosition.Goalkeeper, PhotoUrl = "images/players/player-placeholder.png", Description = "A fearless shot-stopper with lightning-quick reflexes and unstoppable determination. Dominates the box, shuts down one-on-one chances, and rises in the biggest moments. A vocal leader and relentless competitor who turns pressure into confidence and protects the goal at all costs." },
        
            // Defenders
            new Player { Id = 3, JerseyNumber = 7, FirstName = "Jacob", LastName = "", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "A rock-solid defender built for big moments. Explosive in challenges, fearless in the air, and relentless in recovery runs. Brings intensity, discipline, and leadership to the back line, shutting down attacks and setting the standard with every play. A true enforcer who never backs down." },
            new Player { Id = 4, JerseyNumber = 4, FirstName = "Oliver", LastName = "", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "A relentless and physical defender who thrives in every challenge. Locks down attackers, wins crucial tackles, and dominates in the air. Reads the game with confidence, leads from the back, and brings nonstop intensity to every match. A true wall in defense who plays with heart, grit, and pride." },
            new Player { Id = 5, JerseyNumber = 24, FirstName = "Christopher", LastName = "", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "A battle-tested defender with unmatched intensity and toughness. Fearless in tackles, ruthless in duels, and always one step ahead. Controls the back line, shuts down threats before they develop, and brings pure dominance to every match. When this defender is on the field, attackers know it’s going to be a long night."},
            new Player { Id = 6, JerseyNumber = 13, FirstName = "Ivan", LastName = "", Position = PlayerPosition.Defender, PhotoUrl = "images/players/player-placeholder.png", Description = "A dominant force at the back built for high-pressure moments. Explodes into tackles, rules the air, and hunts down attackers with relentless recovery runs. Leads with fire and focus, sets the tone for the entire defense, and shuts down threats with authority. A fearless enforcer who plays with power, pride, and zero hesitation." },

            // Midfielders
            new Player { Id = 17, JerseyNumber = 17, FirstName = "Austin", LastName = "", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "A creative engine with flair, vision, and confidence on the ball. Breaks lines with precision passes, controls the tempo, and unlocks defenses with explosive movement. Fearless going forward, dangerous in the final third, and always ready to deliver in big moments. A true playmaker who turns chances into goals and goals into momentum." },
            new Player { Id = 8, JerseyNumber = 6, FirstName = "Kenny", LastName = "", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "Explosive, creative, and daring, this midfielder thrives in the attacking third. Breaks lines, combines with flair, and makes decisive plays when it matters most. A constant spark of creativity and excitement who turns midfield battles into goal-scoring opportunities." },
            new Player { Id = 9, JerseyNumber = 18, FirstName = "David", LastName = "", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "A fearless creator in the heart of the pitch, blending skill, speed, and vision. Breaks defenses with clever passes, drives the attack with relentless energy, and thrives in the moments that matter most. A true spark in midfield who turns possession into opportunities and keeps the game alive." },
            new Player { Id = 10, JerseyNumber = 15, FirstName = "Kai", LastName = "", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "A hardworking and versatile midfielder who drives the team forward. Combines stamina, awareness, and creativity to influence the game at both ends of the field. Reliable, focused, and always ready to make an impact." },
            new Player { Id = 11, JerseyNumber = 12, FirstName = "Milo", LastName = "", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "A determined and adaptable midfielder who never stops moving and always pushes the team forward. Brings focus, vision, and energy to the heart of the pitch, influencing the game whenever it counts. Strong, reliable, and unstoppable in effort." },
            new Player { Id = 12, JerseyNumber = 10, FirstName = "Sawyer", LastName = "", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "A creative force in the heart of midfield, dictating the game with vision, precision, and flair. Threads passes that split defenses, drives attacks with intelligence and pace, and turns every opportunity into a chance. Always one step ahead, always a threat, always shaping the game." },
             new Player { Id = 13, JerseyNumber = 9, FirstName = "Alec", LastName = "", Position = PlayerPosition.Midfielder, PhotoUrl = "images/players/player-placeholder.png", Description = "A master of the pass with vision that splits defenses and creativity that unlocks every attack. Controls the tempo, finds teammates in perfect positions, and turns every opportunity into a dangerous chance. A true orchestrator in midfield who makes the game flow and keeps the opposition guessing." },
            // Forwards
            new Player { Id = 12, JerseyNumber = 16, FirstName = "Benji", LastName = "", Position = PlayerPosition.Forward, PhotoUrl = "images/players/player-placeholder.png", Description = "A fast and intelligent forward who knows exactly when to strike. Uses his pace to stretch defenses, times his runs to perfection, and creates chances for teammates with precise assists. Deadly when the moment comes, combining speed, vision, and composure to turn opportunities into goals and game-changing plays." },
            new Player { Id = 13, JerseyNumber = 2, FirstName = "Gio", LastName = "", Position = PlayerPosition.Forward, PhotoUrl = "images/players/player-placeholder.png", Description = "A clever and unpredictable forward who strikes when it matters most. Reads the game brilliantly, finds space where others can’t, and finishes with deadly accuracy. A true secret weapon in the attack, always ready to turn the tide and make a decisive impact." },
            new Player { Id = 14, JerseyNumber = 14, FirstName = "Adrian", LastName = "", Position = PlayerPosition.Forward, PhotoUrl = "images/players/player-placeholder.png", Description = "A lightning-fast forward with a deadly instinct for goal. Explodes past defenders, strikes with precision, and consistently finds the back of the net. A constant threat in the final third, turning speed and skill into unforgettable moments and match-winning goals." },
        };
    }

    public List<Coach> GetCoaches()
    {
        return new List<Coach>
        {
            new Coach { Id = 1, FirstName = "Marcos", LastName = "Jimenez", Role = CoachRole.HeadCoach, PhotoUrl = "images/coaches/coach-placeholder.png", Description = "A visionary leader who inspires and guides the team with expertise, strategy, and passion. Focused on developing players, fostering teamwork, and maximizing performance on the field. Known for tactical intelligence, clear communication, and the ability to bring out the best in every player." },
            new Coach { Id = 2, FirstName = "Luis", LastName = "Centina", Role = CoachRole.AssistantCoach, PhotoUrl = "images/coaches/coach-placeholder.png", Description = "A dedicated and knowledgeable coach who supports the head coach in strategy, training, and player development. Focused on improving skills, maintaining team discipline, and ensuring the squad is prepared for every challenge. A reliable leader who helps bring out the best in each player." },
            new Coach { Id = 4, FirstName = "Estefany", LastName = "Novelo", Role = CoachRole.TeamManager, PhotoUrl = "images/coaches/coach-placeholder.png", Description = "A dedicated and organized leader who ensures the team runs smoothly on and off the field. Manages logistics, coordinates schedules, and supports players and staff to create a focused and prepared environment. A reliable backbone of the team, keeping everything running seamlessly so the squad can perform at its best." },
        };
    }

    public List<Game> GetGames()
    {
        var today = DateTime.Today;
        return new List<Game>
        {
            // Past games (Results)
                new Game { Id = 1, GameDate = today.AddDays(-127), Opponent = "LCSA Wildcats", IsHomeGame = true, Venue = "Cox Fields Field 1", Competition = "CFBSA League", HomeScore = 0, AwayScore = 0, OpponentLogoUrl = "images/teams/lcsa-wildcats.jpg", WasRescheduled = true, RescheduledTo = new DateTime(2025, 9, 22) }, // Rescheduled to September 22
                new Game { Id = 1, GameDate = today.AddDays(-120), Opponent = "Knights", IsHomeGame = false, Venue = "Cox Fields Field 1", Competition = "CFBSA League", HomeScore = 4, AwayScore = 4, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 2, GameDate = today.AddDays(-113), Opponent = "GLASA Scorpions", IsHomeGame = true, Venue = "Cox Fields Field 1", Competition = "CFBSA League", HomeScore = 1, AwayScore = 2, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 3, GameDate = today.AddDays(-111), Opponent = "LCSA Wildcats", IsHomeGame = true, Venue = "Veterans Park Field E", Competition = "CFBSA League", HomeScore = 0, AwayScore = 7, OpponentLogoUrl = "images/teams/lcsa-wildcats.jpg" },
            new Game { Id = 4, GameDate = today.AddDays(-106), Opponent = "Mustangs", IsHomeGame = true, Venue = "Cox Fields Field 1", Competition = "CFBSA League", HomeScore = 8, AwayScore = 3, OpponentLogoUrl = "images/teams/mustangs.jpg" },
            new Game { Id = 5, GameDate = today.AddDays(-99), Opponent = "GLASA Avengers", IsHomeGame = false, Venue = "Bob Wiseman Soccer Complex Field 2", Competition = "CFBSA League", HomeScore = 2, AwayScore = 1, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 5, GameDate = today.AddDays(-92), Opponent = "GLASA Scorpions", IsHomeGame = false, Venue = "Bob Wiseman Soccer Complex Field 1", Competition = "CFBSA League", HomeScore = 0, AwayScore = 5, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 5, GameDate = today.AddDays(-85), Opponent = "Mustangs", IsHomeGame = false, Venue = "Cox Fields Field 1", Competition = "CFBSA League", HomeScore = 2, AwayScore = 5, OpponentLogoUrl = "images/teams/mustangs.jpg" },
            new Game { Id = 5, GameDate = today.AddDays(-82), Opponent = "Mustangs", IsHomeGame = false, Venue = "Veterans Park Field D", Competition = "Tournament Of Champions", HomeScore = 1, AwayScore = 6, OpponentLogoUrl = "images/teams/mustangs.jpg" },
            new Game { Id = 1, GameDate = today.AddDays(-78), Opponent = "GLASA Avengers", IsHomeGame = true, Venue = "Cox Fields Field 1", Competition = "Tournament Of Champions", HomeScore = 0, AwayScore = 0, OpponentLogoUrl = "images/teams/team-placeholder.png", WasRescheduled = true, RescheduledTo = new DateTime(2025, 11, 10) }, // Rescheduled to November 10
            new Game { Id = 5, GameDate = today.AddDays(-71), Opponent = "LCSA Wildcats", IsHomeGame = false, Venue = "Corinth Community Park Field 1A", Competition = "CFBSA League", HomeScore = 4, AwayScore = 4, OpponentLogoUrl = "images/teams/lcsa-wildcats.jpg" },
            new Game { Id = 5, GameDate = today.AddDays(-69), Opponent = "Ender Dragons", IsHomeGame = true, Venue = "Veterans Park Field D", Competition = "Tournament Of Champions", HomeScore = 5, AwayScore = 3, OpponentLogoUrl = "images/teams/team-placeholder.png" }, 
            new Game { Id = 5, GameDate = today.AddDays(-64), Opponent = "Knights", IsHomeGame = true, Venue = "Cox Fields Field 1", Competition = "CFBSA League", HomeScore = 4, AwayScore = 2, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 5, GameDate = today.AddDays(-62), Opponent = "GLASA Avengers", IsHomeGame = true, Venue = "Veterans Park Field D", Competition = "CFBSA League", HomeScore = 3, AwayScore = 4, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 5, GameDate = today.AddDays(-36), Opponent = "Predators", IsHomeGame = false, Venue = "Keller Sports Park Legacy Field South", Competition = "Tournament Of Champions", HomeScore = 5, AwayScore = 0, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 5, GameDate = today.AddDays(-36), Opponent = "Mesquite SA", IsHomeGame = false, Venue = "Keller Sports Park Field A South", Competition ="Tournament Of Champions", HomeScore = 3, AwayScore = 1, OpponentLogoUrl = "images/teams/team-placeholder.png" },
            new Game { Id = 5, GameDate = today.AddDays(-35), Opponent = "Odesa SA", IsHomeGame = false, Venue = "Keller Sports Park Field E North", Competition = "Tournament Of Champions", HomeScore = 0, AwayScore = 1, OpponentLogoUrl = "images/teams/team-placeholder.png" },
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
