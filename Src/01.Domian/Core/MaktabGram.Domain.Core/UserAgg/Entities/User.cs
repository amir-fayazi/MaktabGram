using MaktabGram.Domain.Core.CommentAgg.Entities;
using MaktabGram.Domain.Core.FollowAgg.Entities;
using MaktabGram.Domain.Core.PostAgg.Entities;
using MaktabGram.Domain.Core.UserAgg.ValueObjects;
using MaktabGram.Domain.Core._common.Entities;

namespace MaktabGram.Domain.Core.UserAgg.Entities;

public class User : BaseEntity
{
    #region Constructors

    public User()
    {
    }

    #endregion

    #region Properties

    public string? Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public Mobile Mobile { get; set; } = null!;

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
    public void SetVerifiedBadge()
    {
        if(CreatedAt <= DateTime.Now.AddYears(-2)
            && IsActive
            && Followers.Count > 100000
            )
        {
            VerifiedBadge = true;
        }
        else
        {
            throw new Exception("شما شرایط کافی برای گرفتن تیک آبی رو ندارید");
        }
    }
    #endregion
}
