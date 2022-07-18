using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetAllMatches
{
    public class GetAllMatchesQuery : IRequest<List<MatchViewModel>>
    {
    }
}
