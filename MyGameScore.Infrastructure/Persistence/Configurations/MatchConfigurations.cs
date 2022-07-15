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
                .HasOne(m => m.Player)
                .WithMany(m => m.Matches)
                .HasForeignKey(m => m.IdPlayer)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
