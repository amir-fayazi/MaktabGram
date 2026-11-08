

using MaktabGram.Domain.Core.UserAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    public class UserProfileConfigurations : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {

            builder.ToTable("UserProfiles")
                   .HasKey(x => x.Id);

            builder.OwnsOne(x => x.Email, emailBuilder =>
            {
                emailBuilder.Property(x => x.Value)
                .HasColumnName("Email")
                .HasMaxLength(254)
                .IsRequired();
            });
        }
    }
}
