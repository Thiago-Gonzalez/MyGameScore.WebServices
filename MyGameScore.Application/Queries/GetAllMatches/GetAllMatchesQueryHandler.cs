using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetAllMatches
{
    public class GetAllMatchesQueryHandler : IRequestHandler<GetAllMatchesQuery, List<MatchViewModel>>
    {
        private readonly IMatchRepository _matchRepository;
        public GetAllMatchesQueryHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task<List<MatchViewModel>> Handle(GetAllMatchesQuery request, CancellationToken cancellationToken)
        {
            var matches = await _matchRepository.GetAllAsync();

            var matchesViewModel = matches
                .Select(m => new MatchViewModel(m.Id, m.Date, m.Score, m.Player.Name))
                .ToList();

            return matchesViewModel;
        }
    }
}
