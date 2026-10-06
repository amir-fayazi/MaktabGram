using MaktabGram.Domain.Core.UserAgg.Entities;

namespace MaktabGram.Domain.Core.CommentAgg.Entities;

public class CommentLike
{
    #region Properties

    public DateTime CreatedAt { get; set; }

    #endregion

    #region Navigation Properties

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int CommentId { get; set; }
    public Comment Comment { get; set; } = null!;

    #endregion
}
