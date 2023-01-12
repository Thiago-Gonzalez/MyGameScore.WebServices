using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetTopHighScoreMatches
{
    public class GetTopHighScoreMatchesQueryHandler : IRequestHandler<GetTopHighScoreMatchesQuery, List<MatchViewModel>>
    {
        private readonly IMatchRepository _matchRepository;
        public GetTopHighScoreMatchesQueryHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task<List<MatchViewModel>> Handle(GetTopHighScoreMatchesQuery request, CancellationToken cancellationToken)
        {
            var matches = await _matchRepository.GetAllAsync();

            if (matches == null) return null;

            return matches.OrderByDescending(m => m.Score).Take(request.Quantity).Select(m => new MatchViewModel(m.Id, m.Date, m.Score, m.Player.Name)).ToList();
        }
    }
}