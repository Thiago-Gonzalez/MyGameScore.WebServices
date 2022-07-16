using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetMatchById
{
    public class GetMatchByIdQueryHandler : IRequestHandler<GetMatchByIdQuery, MatchViewModel>
    {
        private readonly IMatchRepository _matchRepository;
        public GetMatchByIdQueryHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task<MatchViewModel> Handle(GetMatchByIdQuery request, CancellationToken cancellationToken)
        {
            var match = await _matchRepository.GetByIdAsync(request.Id);

            if (match == null) return null;

            return new MatchViewModel(match.Id, match.Date, match.Score, match.Player.Name);
        }
    }
}
