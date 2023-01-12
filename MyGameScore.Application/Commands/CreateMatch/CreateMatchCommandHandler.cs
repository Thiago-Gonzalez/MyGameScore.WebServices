using MediatR;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Commands.CreateMatch
{
    public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, int>
    {
        private readonly IMatchRepository _matchRepository;
        private readonly ISeasonRepository _seasonRepository;
        public CreateMatchCommandHandler(IMatchRepository matchRepository, ISeasonRepository seasonRepository)
        {
            _matchRepository = matchRepository;
            _seasonRepository = seasonRepository;
        }
        public async Task<int> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
        {
            var match = new Match(request.IdPlayer, request.IdSeason, request.Date, request.Score);

            await _matchRepository.AddAsync(match);

            await _seasonRepository.UpdateSeasonAsync(request.IdSeason);

            return match.Id;
        }
    }
}
