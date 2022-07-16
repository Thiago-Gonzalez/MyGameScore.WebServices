using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetPlayerMatches
{
    public class GetPlayerMatchesQueryHandler : IRequestHandler<GetPlayerMatchesQuery, List<MatchViewModel>>
    {
        private readonly IMatchRepository _matchRepository;
        public GetPlayerMatchesQueryHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task<List<MatchViewModel>> Handle(GetPlayerMatchesQuery request, CancellationToken cancellationToken)
        {
            var playerMatches = await _matchRepository.GetPlayerMatchesAsync(request.PlayerId);

            var playerMatchesViewModel = playerMatches
                .Select(pm => new MatchViewModel(pm.Id, pm.Date, pm.Score, pm.Player.Name))
                .ToList();

            return playerMatchesViewModel;
        }
    }
}
