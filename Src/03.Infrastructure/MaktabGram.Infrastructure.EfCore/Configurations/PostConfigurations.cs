

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
            builder.ToTable("Posts")
                   .HasKey(x => x.Id);


            builder.Property(x => x.Caption)
                   .HasMaxLength(4000)
                   .IsRequired();

            builder
                 .Property(x => x.MediaUrl)
                 .HasMaxLength(1000)
                 .IsRequired();

            builder.Property(x => x.OpenComment)
                   .HasDefaultValue(true);

           
            builder.HasOne(x => x.User)
                  .WithMany(x => x.Posts)
                  .HasForeignKey(x => x.UserId)
                  .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Comments)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.PostLikes)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.SavedByUsers)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.TaggedUsers)
                .WithOne(x => x.Post)
                .HasForeignKey(x => x.PostId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
