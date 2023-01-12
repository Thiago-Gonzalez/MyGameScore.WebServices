using MyGameScore.Core.Entities;

namespace MyGameScore.Core.Repositories
{
    public interface IMatchRepository
    {
        Task<List<Match>> GetAllAsync();
        Task<List<Match>> GetMatchesBySeasonAsync(int idSeason);
        Task<List<Match>> GetMatchesByPlayerAsync(int idPlayer);
        Task<Match> GetByIdAsync(int id);
        Task AddAsync(Match match);
        Task DeleteMatchAsync(int id);
        Task SaveChangesAsync();
    }
}
