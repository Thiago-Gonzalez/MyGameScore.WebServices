using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetPlayerStats
{
    public class GetPlayerStatsQueryHandler : IRequestHandler<GetPlayerStatsQuery, PlayerStatsViewModel>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMatchRepository _matchRepository;
        public GetPlayerStatsQueryHandler(IPlayerRepository playerRepository, IMatchRepository matchRepository)
        {
            _playerRepository = playerRepository;
            _matchRepository = matchRepository;
        }
        public async Task<PlayerStatsViewModel> Handle(GetPlayerStatsQuery request, CancellationToken cancellationToken)
        {
            var player = await _playerRepository.GetByIdAsync(request.PlayerId);

            var matches = await _matchRepository.GetPlayerMatchesAsync(request.PlayerId);

            player.SetMatches(matches);

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
