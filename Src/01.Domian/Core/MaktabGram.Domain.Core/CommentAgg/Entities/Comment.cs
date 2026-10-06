using MaktabGram.Domain.Core.PostAgg.Entities;
using MaktabGram.Domain.Core.UserAgg.Entities;
using MaktabGram.Domain.Core._common;

namespace MaktabGram.Domain.Core.CommentAgg.Entities;

public class Comment : BaseEntity
{
    #region Properties

    public string Text { get; set; } = string.Empty;

    #endregion

    #region Navigation Properties

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int PostId { get; set; }
    public Post Post { get; set; } = null!;

    public List<CommentLike> CommentLikes { get; set; } = new();

    public int? ParentCommentId { get; set; }
    public Comment? ParentComment { get; set; }
    public List<Comment> Replies { get; set; } = new();

    #endregion
}
