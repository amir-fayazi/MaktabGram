using MaktabGram.Domain.Core.UserAgg.Entities;

namespace MaktabGram.Domain.Core.FollowAgg.Entities;

public class Follow
{
    #region Properties

    public DateTime FollowedAt { get; set; }

    #endregion

    #region Navigation Properties

    public int FollowerId { get; set; }
    public User FollowerUser { get; set; } = null!;

    public int FollowedId { get; set; }
    public User FollowedUser { get; set; } = null!;

    #endregion
}
