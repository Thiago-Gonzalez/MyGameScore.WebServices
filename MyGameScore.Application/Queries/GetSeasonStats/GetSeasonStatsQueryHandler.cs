using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetSeasonStats
{
    public class GetSeasonStatsQueryHandler : IRequestHandler<GetSeasonStatsQuery, SeasonStatsViewModel>
    {
        private readonly ISeasonRepository _seasonRepository;
        public GetSeasonStatsQueryHandler(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }
        public async Task<SeasonStatsViewModel> Handle(GetSeasonStatsQuery request, CancellationToken cancellationToken)
        {
            var season = await _seasonRepository.GetByIdAsync(request.SeasonId);

            if (season == null) return null;

            if (season.Matches.Count == 0) return new SeasonStatsViewModel(0, 0, 0, 0, 0, 0);

            return new SeasonStatsViewModel(
                season.GetGamesPlayed(), 
                season.GetTotalScore(),
                season.GetScoreAverage(),
                season.GetHighestScore(),
                season.GetLowestScore(),
                season.GetTimesRecordWasBeaten()
                );
        }
    }
}
