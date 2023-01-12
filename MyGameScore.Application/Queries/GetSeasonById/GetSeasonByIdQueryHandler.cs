using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetSeasonById
{
    public class GetSeasonByIdQueryHandler : IRequestHandler<GetSeasonByIdQuery, SeasonViewModel>
    {
        private readonly ISeasonRepository _seasonRepository;
        public GetSeasonByIdQueryHandler(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }
        public async Task<SeasonViewModel> Handle(GetSeasonByIdQuery request, CancellationToken cancellationToken)
        {
            var season = await _seasonRepository.GetByIdAsync(request.Id);

            if (season == null) return null;

            var seasonMatchesViewModel = season.Matches
                .Select(sm => new MatchViewModel(sm.Id, sm.Date, sm.Score, sm.Player.Name))
                .ToList();

            return new SeasonViewModel(season.Id, season.CreatedAt, season.SeasonStart, season.SeasonEnd, seasonMatchesViewModel);
        }
    }
}