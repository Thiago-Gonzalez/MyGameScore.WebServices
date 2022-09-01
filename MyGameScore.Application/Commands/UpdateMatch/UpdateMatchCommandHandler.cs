using MediatR;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Commands.UpdateMatch
{
    public class UpdateMatchCommandHandler : IRequestHandler<UpdateMatchCommand, Unit>
    {
        private readonly IMatchRepository _matchRepository;
        public UpdateMatchCommandHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task<Unit> Handle(UpdateMatchCommand request, CancellationToken cancellationToken)
        {
            var match = await _matchRepository.GetByIdAsync(request.Id);

            match.Update(request.Date, request.Score);

            await _matchRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}