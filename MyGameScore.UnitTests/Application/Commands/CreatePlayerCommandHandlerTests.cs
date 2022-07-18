using Moq;
using MyGameScore.Application.Commands.CreatePlayer;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;
using MyGameScore.Core.Services;

namespace MyGameScore.UnitTests.Application.Commands
{
    public class CreatePlayerCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnPlayerId()
        {
            // Arrange
            var playerRepositoryMock = new Mock<IPlayerRepository>();
            var authServiceMock = new Mock<IAuthService>();

            var createPlayerCommand = new CreatePlayerCommand
            {
                Name = "Test Player",
                Email = "testplayer@gmail.com",
                Password = "TestP@ss123"
            };

            var createPlayerCommandHandler = new CreatePlayerCommandHandler(playerRepositoryMock.Object, authServiceMock.Object);

            // Act
            var id = await createPlayerCommandHandler.Handle(createPlayerCommand, new CancellationToken());

            // Assert
            Assert.True(id >= 0);

            playerRepositoryMock.Verify(pr => pr.CreatePlayerAsync(It.IsAny<Player>()), Times.Once);
        }
    }
}
