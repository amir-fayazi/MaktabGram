using MaktabGram.Domain.Core.CommentAgg.Entities;
using MaktabGram.Domain.Core.UserAgg.Entities;
using MaktabGram.Domain.Core._common;

namespace MaktabGram.Domain.Core.PostAgg.Entities;

public class Post : BaseEntity
{
    #region Properties

    public string Caption { get; set; } = string.Empty;
    public string MediaUrl { get; set; } = string.Empty;

    #endregion

    #region Navigation Properties

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public List<Comment> Comments { get; set; } = new();
    public List<PostLike> PostLikes { get; set; } = new();
    public List<PostSave> PostSaves { get; set; } = new();
    public List<PostTag> TaggedUsers { get; set; } = new();

    #endregion
}
