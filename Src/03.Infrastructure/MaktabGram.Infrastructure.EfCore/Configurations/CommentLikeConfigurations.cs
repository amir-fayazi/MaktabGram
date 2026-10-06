using MaktabGram.Domain.Core.CommentAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    public class CommentLikeConfigurations : IEntityTypeConfiguration<CommentLike>
    {
        public void Configure(EntityTypeBuilder<CommentLike> builder)
        {
            builder.HasKey(x => new
            {
                x.UserId,
                x.CommentId
            });
                
        }
    }
}
