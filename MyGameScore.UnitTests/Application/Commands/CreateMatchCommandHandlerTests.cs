using Moq;
using MyGameScore.Application.Commands.CreateMatch;
using MyGameScore.Core.Repositories;
using MyGameScore.Core.Entities;
using MyGameScore.Application.Commands.CreateSeason;

namespace MyGameScore.UnitTests.Application.Commands
{
    public class CreateMatchCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnMatchId()
        {
            // Arrange
            var matchRepositoryMock = new Mock<IMatchRepository>();
            var seasonRepositoryMock = new Mock<ISeasonRepository>();

            var createMatchCommand = new CreateMatchCommand
            {
                Date = DateTime.Now,
                Score = 22,
                IdPlayer = 1,
                IdSeason = 1
            };

            var createMatchCommandHandler = new CreateMatchCommandHandler(matchRepositoryMock.Object, seasonRepositoryMock.Object);

            // Act
            var id = await createMatchCommandHandler.Handle(createMatchCommand, new CancellationToken());

            // Assert
            Assert.True(id >= 0);

            matchRepositoryMock.Verify(mr => mr.AddAsync(It.IsAny<MyGameScore.Core.Entities.Match>()), Times.Once);
        }
    }
}
