using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyGameScore.Core.Entities;

namespace MyGameScore.Infrastructure.Persistence.Configurations
{
    public class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Season> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .HasOne(s => s.Player)
                .WithMany(p => p.Seasons)
                .HasForeignKey(s => s.IdPlayer)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}