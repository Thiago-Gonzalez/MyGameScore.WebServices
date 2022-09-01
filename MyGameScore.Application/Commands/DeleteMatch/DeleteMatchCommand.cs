using MediatR;

namespace MyGameScore.Application.Commands.DeleteMatch
{
    public class DeleteMatchCommand : IRequest<Unit>
    {
        public DeleteMatchCommand(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}