using MediatR;
using MyGameScore.Application.ViewModels;
using MyGameScore.Core.Repositories;
using MyGameScore.Core.Services;

namespace MyGameScore.Application.Commands.LoginPlayer
{
    public class LoginPlayerCommandHandler : IRequestHandler<LoginPlayerCommand, LoginPlayerViewModel>
    {
        private readonly IAuthService _authService;
        private readonly IPlayerRepository _playerRepository;
        public LoginPlayerCommandHandler(IAuthService authService, IPlayerRepository playerRepository)
        {
            _authService = authService;
            _playerRepository = playerRepository;
        }

        public async Task<LoginPlayerViewModel> Handle(LoginPlayerCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var player = await _playerRepository.GetPlayerByEmailAndPasswordAsync(request.Email, passwordHash);

            if (player == null) return null;

            var token = _authService.GenerateJwtToken(player.Email);

            return new LoginPlayerViewModel(player.Id, player.Email, token);
        }
    }
}
