using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGameScore.Core.Entities;

namespace MyGameScore.Infrastructure.Persistence.Configurations
{
    public class PlayerConfigurations : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
                .HasKey(p => p.Id);
        }
    }
}
