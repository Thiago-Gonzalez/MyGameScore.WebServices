using MediatR;
using MyGameScore.Application.ViewModels;

namespace MyGameScore.Application.Queries.GetPlayer
{
    public class GetPlayerQuery : IRequest<PlayerViewModel>
    {
        public GetPlayerQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
