using MaktabGram.Domain.Core.PostAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MaktabGram.Infrastructure.EfCore.Configurations
{
    public class PostSavesConfigurations : IEntityTypeConfiguration<PostSave>
    {
        void IEntityTypeConfiguration<PostSave>.Configure(EntityTypeBuilder<PostSave> builder)
        {
            builder.HasKey(x => new
            {
                x.UserId,
                x.PostId,
            });
        }
    }
}
