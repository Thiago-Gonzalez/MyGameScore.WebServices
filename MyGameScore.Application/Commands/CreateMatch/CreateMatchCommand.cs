using MediatR;

namespace MyGameScore.Application.Commands.CreateMatch
{
    public class CreateMatchCommand : IRequest<int>
    {
        public DateTime Date { get; private set; }
        public int Score { get; private set; }
        public int IdPlayer { get; private set; }
    }
}
