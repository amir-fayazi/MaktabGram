using MaktabGram.Domain.Core.FollowAgg.Entities;
using MaktabGram.Domain.Core.PostAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    public class PostLikeConfigurations : IEntityTypeConfiguration<PostLike>
    {
        public void Configure(EntityTypeBuilder<PostLike> builder)
        {
            builder.HasKey(x => new
            {
                x.UserId,
                x.PostId
            });


        }
    }
}
