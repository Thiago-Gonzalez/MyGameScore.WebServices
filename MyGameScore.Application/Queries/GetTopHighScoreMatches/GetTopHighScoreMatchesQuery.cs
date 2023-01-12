using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetTopHighScoreMatches
{
    public class GetTopHighScoreMatchesQuery : IRequest<List<MatchViewModel>>
    {
        public GetTopHighScoreMatchesQuery(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}