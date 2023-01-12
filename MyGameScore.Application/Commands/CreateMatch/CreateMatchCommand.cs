using MediatR;

namespace MyGameScore.Application.Commands.CreateMatch
{
    public class CreateMatchCommand : IRequest<int>
    {
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public int IdPlayer { get; set; }
        public int IdSeason { get; set; }
    }
}
