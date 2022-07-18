using MediatR;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Commands.CreateMatch
{
    public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, int>
    {
        private readonly IMatchRepository _matchRepository;
        public CreateMatchCommandHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task<int> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
        {
            var match = new Match(request.IdPlayer, request.Date, request.Score);

            await _matchRepository.AddAsync(match);

            return match.Id;
        }
    }
}
