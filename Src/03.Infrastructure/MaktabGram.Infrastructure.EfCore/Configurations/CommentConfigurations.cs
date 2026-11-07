using MaktabGram.Domain.Core.CommentAgg.Entities;
using MaktabGram.Domain.Core.FollowAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments")
                   .HasKey(x => x.Id);


            builder.Property(x => x.Text)
                   .HasMaxLength(1000)
                   .IsRequired();


            builder.HasMany(x => x.CommentLikes)
                .WithOne(x => x.Comment)
                .HasForeignKey(x  => x.CommentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Replies)
                .WithOne(x => x.ParentComment)
                .HasForeignKey(x => x.ParentCommentId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
