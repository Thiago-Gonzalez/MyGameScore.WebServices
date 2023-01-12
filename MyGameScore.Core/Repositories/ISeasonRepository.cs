using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGameScore.Core.Entities;

namespace MyGameScore.Core.Repositories
{
    public interface ISeasonRepository
    {
        Task CreateSeasonAsync(Season season);
        Task<Season> GetByIdAsync(int id);
        Task<List<Season>> GetSeasonsByPlayerAsync(int idPlayer);
        Task UpdateSeasonAsync(int idSeason);
        Task SaveChangesAsync();
    }
}