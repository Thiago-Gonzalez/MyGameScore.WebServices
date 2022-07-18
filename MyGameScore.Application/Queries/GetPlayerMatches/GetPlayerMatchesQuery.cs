using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetPlayerMatches
{
    public class GetPlayerMatchesQuery : IRequest<List<MatchViewModel>>
    {
        public GetPlayerMatchesQuery(int playerId)
        {
            PlayerId = playerId;
        }

        public int PlayerId { get; private set; }
    }
}
