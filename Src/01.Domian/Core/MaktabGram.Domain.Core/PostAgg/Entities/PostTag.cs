using MaktabGram.Domain.Core.UserAgg.Entities;

namespace MaktabGram.Domain.Core.PostAgg.Entities;

public class PostTag
{
    #region Properties

    public DateTime CreatedAt { get; set; }

    #endregion

    #region Navigation Properties

    public int PostId { get; set; }
    public Post Post { get; set; } = null!;

    public int TaggedUserId { get; set; }
    public User TaggedUser { get; set; } = null!;

    #endregion
}
