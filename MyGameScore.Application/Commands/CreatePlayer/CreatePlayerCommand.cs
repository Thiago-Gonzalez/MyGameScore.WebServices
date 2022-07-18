using MediatR;

namespace MyGameScore.Application.Commands.CreatePlayer
{
    public class CreatePlayerCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
