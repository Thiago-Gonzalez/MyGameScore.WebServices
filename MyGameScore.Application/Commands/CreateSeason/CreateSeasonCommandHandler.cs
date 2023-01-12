using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Commands.CreateSeason
{
    public class CreateSeasonCommandHandler : IRequestHandler<CreateSeasonCommand, int>
    {
        private readonly ISeasonRepository _seasonRepository;
        private readonly IPlayerRepository  _playerRepository;
        public CreateSeasonCommandHandler(ISeasonRepository seasonRepository, IPlayerRepository playerRepository)
        {
            _seasonRepository = seasonRepository;
            _playerRepository = playerRepository;
        }

        public async Task<int> Handle(CreateSeasonCommand request, CancellationToken cancellationToken)
        {
            var season = new Season(request.IdPlayer);

            await _seasonRepository.CreateSeasonAsync(season);

            return season.Id;
        }
    }
}