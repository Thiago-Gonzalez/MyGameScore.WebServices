using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MyGameScore.Application.Commands.CreateSeason
{
    public class CreateSeasonCommand : IRequest<int>
    {
        public int IdPlayer { get; set; }
    }
}