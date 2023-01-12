using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetSeasonStats
{
    public class GetSeasonStatsQuery : IRequest<SeasonStatsViewModel>
    {
        public GetSeasonStatsQuery(int seasonId)
        {
            SeasonId = seasonId;
        }

        public int SeasonId { get; private set; }
    }
}
