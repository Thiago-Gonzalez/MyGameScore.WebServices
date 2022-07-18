using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Application.Queries.GetPlayer
{
    public class GetPlayerQueryHandler : IRequestHandler<GetPlayerQuery, PlayerViewModel>
    {
        private readonly IPlayerRepository _playerRepository;
        public GetPlayerQueryHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task<PlayerViewModel> Handle(GetPlayerQuery request, CancellationToken cancellationToken)
        {
            var player = await _playerRepository.GetByIdAsync(request.Id);

            if (player == null) return null;

            return new PlayerViewModel(player.Name, player.Email);
        }
    }
}
