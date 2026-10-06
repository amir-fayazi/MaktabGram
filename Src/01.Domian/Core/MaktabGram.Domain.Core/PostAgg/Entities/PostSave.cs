using MaktabGram.Domain.Core.UserAgg.Entities;

namespace MaktabGram.Domain.Core.PostAgg.Entities;

public class PostSave
{
    #region Properties

    public DateTime CreatedAt { get; set; }

    #endregion

    #region Navigation Properties

    public int UserId { get; set; }
    public User SavedBy { get; set; } = null!;

    public int PostId { get; set; }
    public Post Post { get; set; } = null!;

    #endregion
}
