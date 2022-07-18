using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Commands.LoginPlayer
{
    public class LoginPlayerCommand : IRequest<LoginPlayerViewModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
