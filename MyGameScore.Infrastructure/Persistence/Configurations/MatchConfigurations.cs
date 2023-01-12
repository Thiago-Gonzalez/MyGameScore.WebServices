using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameScore.Core.Entities;

namespace MyGameScore.Infrastructure.Persistence.Configurations
{
    public class MatchConfigurations : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .HasOne(m => m.Season)
                .WithMany(s => s.Matches)
                .HasForeignKey(m => m.IdSeason)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.Player)
                .WithMany(p => p.Matches)
                .HasForeignKey(m => m.IdPlayer)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
