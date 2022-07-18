using Moq;
using MyGameScore.Application.Queries.GetPlayer;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;

namespace MyGameScore.UnitTests.Application.Queries
{
    public class GetPlayerQueryHandlerTests
    {
        [Fact]
        public async Task PlayerExist_Executed_ReturnPlayerViewModel()
        {
            // Arrange
            var player = new Player("Test Player", "testplayer@gmail.com", "TestP@ss123");

            var playerRepositoryMock = new Mock<IPlayerRepository>();

            playerRepositoryMock.Setup(pr => pr.GetByIdAsync(player.Id).Result).Returns(player);

            var getPlayerQuery = new GetPlayerQuery(player.Id);
            var getPlayerQueryHandler = new GetPlayerQueryHandler(playerRepositoryMock.Object);

            // Act
            var playerViewModel = await getPlayerQueryHandler.Handle(getPlayerQuery, new CancellationToken());

            // Assert
            Assert.NotNull(playerViewModel);

            playerRepositoryMock.Verify(pr => pr.GetByIdAsync(player.Id).Result, Times.Once);
        }
    }
}
