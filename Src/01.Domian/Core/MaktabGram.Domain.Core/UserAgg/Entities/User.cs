using MaktabGram.Domain.Core.CommentAgg.Entities;
using MaktabGram.Domain.Core.FollowAgg.Entities;
using MaktabGram.Domain.Core.PostAgg.Entities;
using MaktabGram.Domain.Core.UserAgg.ValueObjects;
using MaktabGram.Domain.Core._common;

namespace MaktabGram.Domain.Core.UserAgg.Entities;

public class User : BaseEntity
{
    #region Constructors

    private User()
    {
    }

    #endregion

    #region Properties

    public string Username { get; set; } = string.Empty;
    public Mobile Mobile { get; set; } = null!;
    public string PasswordHash { get; set; } = string.Empty;

    public bool IsActive { get; private set; }
    public bool VerifiedBadge { get; private set; }

    #endregion

    #region Navigation Properties

    public UserProfile? Profile { get; set; }

    public List<Post> Posts { get; set; } = new();
    public List<Comment> Comments { get; set; } = new();

    public List<PostLike> PostLikes { get; set; } = new();
    public List<PostSave> PostSaves { get; set; } = new();
    public List<CommentLike> CommentLikes { get; set; } = new();
    public List<PostTag> TaggedPosts { get; set; } = new();

    public List<Follow> Followers { get; set; } = new();
    public List<Follow> Followings { get; set; } = new();

    #endregion

    #region Behaviors

    public void Activate() => IsActive = true;
    public void Deactivate() => IsActive = false;

    #endregion
}
