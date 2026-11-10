
using MaktabGram.Domain.Core.UserAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("Users")
                   .HasKey(x => x.Id);


            builder.Property(x => x.Username)
                   .HasMaxLength(100);
                   //.IsRequired();

            builder.Property(x => x.PasswordHash)
                 .HasMaxLength(100)
                 .IsRequired();

            builder.OwnsOne(x => x.Mobile, mobileBuilder =>
            {
                mobileBuilder.Property(m => m.Value)
                .HasColumnName("Mobile")
                .HasMaxLength(11)
                .IsRequired();
            });
                
           

            builder.HasOne(x => x.Profile)
                .WithOne(x => x.User)
                .HasForeignKey<UserProfile>(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.Followers)
                .WithOne(f => f.FollowedUser)
                .HasForeignKey(x => x.FollowedId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Followings)
                .WithOne(x => x.FollowerUser)
                .HasForeignKey(x => x.FollowerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Comments)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.CommentLikes)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasMany(x => x.Posts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.PostLikes)
                .WithOne(x => x.LikeBy)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.TaggedPosts)
                .WithOne(x => x.TaggedUser)
                .HasForeignKey(x => x.TaggedUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.PostSaves)
                .WithOne(x => x.SavedBy)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            

        }
    }
}
