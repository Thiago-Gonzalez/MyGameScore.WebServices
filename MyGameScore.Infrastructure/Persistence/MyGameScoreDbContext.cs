using Microsoft.EntityFrameworkCore;
using MyGameScore.Core.Entities;
using System.Reflection;

namespace MyGameScore.Infrastructure.Persistence
{
    public class MyGameScoreDbContext : DbContext
    {
        public MyGameScoreDbContext(DbContextOptions<MyGameScoreDbContext> options) : base(options)
        {
        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
