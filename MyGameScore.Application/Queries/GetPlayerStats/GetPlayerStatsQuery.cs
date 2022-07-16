using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetPlayerStats
{
    public class GetPlayerStatsQuery : IRequest<PlayerStatsViewModel>
    {
        public GetPlayerStatsQuery(int playerId)
        {
            PlayerId = playerId;
        }

        public int PlayerId { get; private set; }
    }
}
