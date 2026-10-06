

using MaktabGram.Domain.Core.PostAgg.Entities;
using MaktabGram.Domain.Core.UserAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    public class PostConfigurations : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Comments)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.PostLikes)
                .WithOne(x => x.Post)
                .HasForeignKey(x =>x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.PostSaves)
                .WithOne(x => x.Post)
                .HasForeignKey(x =>x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
