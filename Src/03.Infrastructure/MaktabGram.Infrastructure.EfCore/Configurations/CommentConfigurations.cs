using MaktabGram.Domain.Core.CommentAgg.Entities;
using MaktabGram.Domain.Core.FollowAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    internal class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.HasMany(x => x.CommentLikes)
                .WithOne(x => x.Comment)
                .HasForeignKey(x  => x.CommentId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
