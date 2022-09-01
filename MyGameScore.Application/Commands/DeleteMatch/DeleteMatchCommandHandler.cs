using MediatR;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Commands.DeleteMatch
{
    public class DeleteMatchCommandHandler : IRequestHandler<DeleteMatchCommand, Unit>
    {
        private readonly IMatchRepository _matchRepository;
        public DeleteMatchCommandHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<Unit> Handle(DeleteMatchCommand request, CancellationToken cancellationToken)
        {
            await _matchRepository.DeleteMatchAsync(request.Id);

            return Unit.Value;
        }
    }
}