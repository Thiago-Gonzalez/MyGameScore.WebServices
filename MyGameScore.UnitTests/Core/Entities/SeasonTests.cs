using MyGameScore.Core.Entities;

namespace MyGameScore.UnitTests.Core.Entities
{
    public class SeasonTests
    {
        [Fact]
        public async void PlayerAndSeasonAndMatchesIsOk_Executed_ReturnGamesPlayed()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var season = new Season(player.Id);
            var matches = new List<Match>
            {
                new Match(player.Id, season.Id, DateTime.Now, 32),
                new Match(player.Id, season.Id, DateTime.Now.AddMonths(3), 45)
            };

            season.SetMatches(matches);

            // Act
            var gamesPlayed = season.GetGamesPlayed();

            // Assert
            Assert.True(gamesPlayed >= 1);
        }

        [Fact]
        public void PlayerAndSeasonAndMatchesIsOk_Executed_ReturnTotalScore()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var season = new Season(player.Id);
            var matches = new List<Match>
            {
                new Match(player.Id, season.Id, DateTime.Now, 32),
                new Match(player.Id, season.Id, DateTime.Now.AddMonths(3), 45)
            };

            season.SetMatches(matches);


            // Act
            var totalScore = season.GetTotalScore();

            // Assert
            Assert.True(totalScore > 0);
        }

        [Fact]
        public void PlayerAndSeasonAndMatchesIsOk_Executed_ReturnScoreAverage()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var season = new Season(player.Id);
            var matches = new List<Match>
            {
                new Match(player.Id, season.Id, DateTime.Now, 32),
                new Match(player.Id, season.Id, DateTime.Now.AddMonths(3), 45)
            };

            season.SetMatches(matches);


            // Act
            var scoreAverage = season.GetScoreAverage();

            // Assert
            Assert.True(scoreAverage > 0);
        }

        [Fact]
        public void PlayerAndSeasonAndMatchesIsOk_Executed_ReturnHighestScore()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var season = new Season(player.Id);
            var matches = new List<Match>
            {
                new Match(player.Id, season.Id, DateTime.Now, 32),
                new Match(player.Id, season.Id, DateTime.Now.AddMonths(3), 45)
            };

            season.SetMatches(matches);


            // Act
            var highestScore = season.GetHighestScore();

            // Assert
            Assert.True(highestScore > 0);
        }

        [Fact]
        public void PlayerAndSeasonAndMatchesIsOk_Executed_ReturnLowestScore()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var season = new Season(player.Id);
            var matches = new List<Match>
            {
                new Match(player.Id, season.Id, DateTime.Now, 32),
                new Match(player.Id, season.Id, DateTime.Now.AddMonths(3), 45)
            };

            season.SetMatches(matches);


            // Act
            var lowestScore = season.GetLowestScore();

            // Assert
            Assert.True(lowestScore > 0);
        }

        [Fact]
        public void PlayerAndSeasonAndMatchesIsOk_Executed_ReturnTimesRecordWasBeaten()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var season = new Season(player.Id);
            var matches = new List<Match>
            {
                new Match(player.Id, season.Id, DateTime.Now, 32),
                new Match(player.Id, season.Id, DateTime.Now.AddMonths(3), 45)
            };

            season.SetMatches(matches);


            // Act
            var timesRecordWasBeaten = season.GetTimesRecordWasBeaten();

            // Assert
            Assert.True(timesRecordWasBeaten >= 1);
        }
    }
}
