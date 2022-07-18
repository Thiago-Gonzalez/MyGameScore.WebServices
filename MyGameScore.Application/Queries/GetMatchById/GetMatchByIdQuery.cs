using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetMatchById
{
    public class GetMatchByIdQuery : IRequest<MatchViewModel>
    {
        public GetMatchByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
