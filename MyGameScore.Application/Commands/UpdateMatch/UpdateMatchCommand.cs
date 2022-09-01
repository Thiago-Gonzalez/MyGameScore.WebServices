using MediatR;

namespace MyGameScore.Application.Commands.UpdateMatch
{
    public class UpdateMatchCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}