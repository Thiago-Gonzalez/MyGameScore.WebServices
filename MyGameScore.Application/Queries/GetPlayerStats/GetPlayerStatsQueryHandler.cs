using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetPlayerStats
{
    public class GetPlayerStatsQueryHandler : IRequestHandler<GetPlayerStatsQuery, PlayerStatsViewModel>
    {
        private readonly IPlayerRepository _playerRepository;
        public GetPlayerStatsQueryHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task<PlayerStatsViewModel> Handle(GetPlayerStatsQuery request, CancellationToken cancellationToken)
        {
            var player = await _playerRepository.GetByIdAsync(request.PlayerId);

            if (player == null) return null;

            return new PlayerStatsViewModel(
                player.GetGamesPlayed(), 
                player.GetTotalScore(),
                player.GetScoreAverage(),
                player.GetHighestScore(),
                player.GetLowestScore(),
                player.GetTimesRecordWasBeaten()
                );
        }
    }
}
