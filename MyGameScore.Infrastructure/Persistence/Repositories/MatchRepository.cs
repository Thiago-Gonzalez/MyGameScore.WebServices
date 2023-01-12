using Microsoft.EntityFrameworkCore;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;

namespace MyGameScore.Infrastructure.Persistence.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly MyGameScoreDbContext _dbContext;
        public MatchRepository(MyGameScoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Match match)
        {
            await _dbContext.Matches.AddAsync(match);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Match>> GetAllAsync()
        {
            return await _dbContext.Matches
                .Include(m => m.Season)
                .Include(m => m.Player)
                .ToListAsync();
        }

        public async Task<List<Match>> GetMatchesBySeasonAsync(int idSeason)
        {
            var matches = await _dbContext.Matches
                .Where(m => m.IdSeason == idSeason)
                .Include(m => m.Season)
                .Include(m => m.Player)
                .ToListAsync();

            if (matches == null) return null;

            return matches;
        }

        public async Task<List<Match>> GetMatchesByPlayerAsync(int idPlayer)
        {
            var matches = await _dbContext.Matches
                .Where(m => m.IdPlayer == idPlayer)
                .Include(m => m.Season)
                .Include(m => m.Player)
                .ToListAsync();
            
            if (matches == null) return null;

            return matches;
        }

        public async Task<Match> GetByIdAsync(int id)
        {
            var match = await _dbContext.Matches
                .Include(m => m.Season)
                .Include(m => m.Player)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (match == null) return null;

            return match;    
        }

        public async Task DeleteMatchAsync(int id)
        {
            var match = await GetByIdAsync(id);

            _dbContext.Matches.Remove(match);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}