using MyGameScore.Core.Entities;

namespace MyGameScore.UnitTests.Core.Entities
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerAndMatchesIsOk_Executed_SetMatches()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var matches = new List<Match>
            {
                new Match(player.Id, DateTime.Now, 32),
                new Match(player.Id, DateTime.Now.AddMonths(3), 45)
            };

            // Act
            player.SetMatches(matches);

            // Assert
            Assert.True(player.Matches.Count > 0);
        }

        [Fact]
        public void PlayerAndMatchesIsOk_Executed_ReturnGamesPlayed()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var matches = new List<Match>
            {
                new Match(player.Id, DateTime.Now, 32),
                new Match(player.Id, DateTime.Now.AddMonths(3), 45)
            };

            player.SetMatches(matches);


            // Act
            var gamesPlayed = player.GetGamesPlayed();

            // Assert
            Assert.True(gamesPlayed >= 1);
        }

        [Fact]
        public void PlayerAndMatchesIsOk_Executed_ReturnTotalScore()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var matches = new List<Match>
            {
                new Match(player.Id, DateTime.Now, 32),
                new Match(player.Id, DateTime.Now.AddMonths(3), 45)
            };

            player.SetMatches(matches);


            // Act
            var totalScore = player.GetTotalScore();

            // Assert
            Assert.True(totalScore > 0);
        }

        [Fact]
        public void PlayerAndMatchesIsOk_Executed_ReturnScoreAverage()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var matches = new List<Match>
            {
                new Match(player.Id, DateTime.Now, 32),
                new Match(player.Id, DateTime.Now.AddMonths(3), 45)
            };

            player.SetMatches(matches);


            // Act
            var scoreAverage = player.GetScoreAverage();

            // Assert
            Assert.True(scoreAverage > 0);
        }

        [Fact]
        public void PlayerAndMatchesIsOk_Executed_ReturnHighestScore()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var matches = new List<Match>
            {
                new Match(player.Id, DateTime.Now, 32),
                new Match(player.Id, DateTime.Now.AddMonths(3), 45)
            };

            player.SetMatches(matches);


            // Act
            var highestScore = player.GetHighestScore();

            // Assert
            Assert.True(highestScore > 0);
        }

        [Fact]
        public void PlayerAndMatchesIsOk_Executed_ReturnLowestScore()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var matches = new List<Match>
            {
                new Match(player.Id, DateTime.Now, 32),
                new Match(player.Id, DateTime.Now.AddMonths(3), 45)
            };

            player.SetMatches(matches);


            // Act
            var lowestScore = player.GetLowestScore();

            // Assert
            Assert.True(lowestScore > 0);
        }

        [Fact]
        public void PlayerAndMatchesIsOk_Executed_ReturnTimesRecordWasBeaten()
        {
            // Arrange
            var player = new Player("Player de Teste", "playerteste@gmail.com", "TestP@ss123");
            var matches = new List<Match>
            {
                new Match(player.Id, DateTime.Now, 32),
                new Match(player.Id, DateTime.Now.AddMonths(3), 45)
            };

            player.SetMatches(matches);


            // Act
            var timesRecordWasBeaten = player.GetTimesRecordWasBeaten();

            // Assert
            Assert.True(timesRecordWasBeaten >= 1);
        }
    }
}
