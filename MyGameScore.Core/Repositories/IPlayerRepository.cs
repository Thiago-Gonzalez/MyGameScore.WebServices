using MyGameScore.Core.Entities;

namespace MyGameScore.Core.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player> GetByIdAsync(int id);
        Task CreatePlayerAsync(Player player);
        Task<Player> GetPlayerByEmailAndPasswordAsync(string email, string passwordHash);
    }
}
