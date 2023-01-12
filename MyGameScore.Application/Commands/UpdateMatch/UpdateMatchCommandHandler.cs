using MediatR;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Commands.UpdateMatch
{
    public class UpdateMatchCommandHandler : IRequestHandler<UpdateMatchCommand, Unit>
    {
        private readonly IMatchRepository _matchRepository;
        private readonly ISeasonRepository _seasonRepository;
        public UpdateMatchCommandHandler(IMatchRepository matchRepository, ISeasonRepository seasonRepository)
        {
            _matchRepository = matchRepository;
            _seasonRepository = seasonRepository;
        }
        public async Task<Unit> Handle(UpdateMatchCommand request, CancellationToken cancellationToken)
        {
            var match = await _matchRepository.GetByIdAsync(request.Id);

            match.Update(request.Date, request.Score);

            await _matchRepository.SaveChangesAsync();

            await _seasonRepository.UpdateSeasonAsync(match.IdSeason);

            return Unit.Value;
        }
    }
}