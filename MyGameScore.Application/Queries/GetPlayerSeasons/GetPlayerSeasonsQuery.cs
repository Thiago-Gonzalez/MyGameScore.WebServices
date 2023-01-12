using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetPlayerSeasons
{
    public class GetPlayerSeasonsQuery : IRequest<List<SeasonViewModel>>
    {
        public GetPlayerSeasonsQuery(int playerId)
        {
            PlayerId = playerId;
        }

        public int PlayerId { get; private set; }
    }
}