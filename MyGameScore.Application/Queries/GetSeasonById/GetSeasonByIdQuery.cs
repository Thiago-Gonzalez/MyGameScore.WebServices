using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetSeasonById
{
    public class GetSeasonByIdQuery : IRequest<SeasonViewModel>
    {
        public GetSeasonByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}