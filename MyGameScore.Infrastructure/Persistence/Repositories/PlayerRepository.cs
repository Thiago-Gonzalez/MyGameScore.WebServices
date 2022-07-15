using Microsoft.EntityFrameworkCore;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Infrastructure.Persistence.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly MyGameScoreDbContext _dbContext;
        public PlayerRepository(MyGameScoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreatePlayerAsync(Player player)
        {
            await _dbContext.Players.AddAsync(player);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Player> GetByIdAsync(int id)
        {
            return await _dbContext.Players.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Player> GetPlayerByEmailAndPasswordAsync(string email, string passwordHash)
        {
            return await _dbContext
                .Players
                .SingleOrDefaultAsync(p => p.Email == email && p.Password == passwordHash);
        }
    }
}
