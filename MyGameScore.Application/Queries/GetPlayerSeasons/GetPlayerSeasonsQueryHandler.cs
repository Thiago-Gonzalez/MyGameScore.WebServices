using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetPlayerSeasons
{
    public class GetPlayerSeasonsQueryHandler : IRequestHandler<GetPlayerSeasonsQuery, List<SeasonViewModel>>
    {
        private readonly ISeasonRepository _seasonRepository;
        public GetPlayerSeasonsQueryHandler(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        public async Task<List<SeasonViewModel>> Handle(GetPlayerSeasonsQuery request, CancellationToken cancellationToken)
        {
            var playerSeasons = await _seasonRepository.GetSeasonsByPlayerAsync(request.PlayerId);
                

            var playerSeasonsViewModel = playerSeasons
                .Select(ps => new SeasonViewModel(ps.Id, ps.CreatedAt, ps.SeasonStart, ps.SeasonEnd, ps.Matches.Select(psm => new MatchViewModel(psm.Id, psm.Date, psm.Score, psm.Player.Name)).ToList()))
                .ToList();

            return playerSeasonsViewModel;
        }
    }
}