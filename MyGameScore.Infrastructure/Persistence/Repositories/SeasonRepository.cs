using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGameScore.Core.Entities;
using MyGameScore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MyGameScore.Infrastructure.Persistence.Repositories
{
    public class SeasonRepository : ISeasonRepository
    {
        private readonly MyGameScoreDbContext _dbContext;

        public SeasonRepository(MyGameScoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateSeasonAsync(Season season)
        {
            await _dbContext.Seasons.AddAsync(season);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Season> GetByIdAsync(int id)
        {
            var season = await _dbContext.Seasons
                .Include(s => s.Player)
                .Include(s => s.Matches)
                .SingleOrDefaultAsync(s => s.Id == id);

            if (season == null) return null;

            return season;
        }

        public async Task<List<Season>> GetSeasonsByPlayerAsync(int idPlayer)
        {
            var playerSeasons = await _dbContext.Seasons
                .Where(s => s.IdPlayer == idPlayer)
                .Include(s => s.Player)
                .Include(s => s.Matches)
                .ToListAsync();

            if (playerSeasons == null) return null;

            return playerSeasons;
        }

        public async Task UpdateSeasonAsync(int idSeason)
        {
            var season = await _dbContext.Seasons
                .Where(s => s.Id == idSeason)
                .Include(s => s.Player)
                .Include(s => s.Matches)
                .SingleOrDefaultAsync();
            
            if (season == null) return;

            season.Update();
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}