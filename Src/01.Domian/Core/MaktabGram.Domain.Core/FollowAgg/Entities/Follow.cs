using MaktabGram.Domain.Core._common;
using MaktabGram.Domain.Core.UserAgg.Entities;

namespace MaktabGram.Domain.Core.FollowAgg.Entities;

public class Follow
{
    #region Properties

    public DateTime FollowedAt { get; set; }
    public bool IsBlock { get; private set; }

    #endregion

    #region Navigation Properties

    public int FollowerId { get; set; }
    public User FollowerUser { get; set; } = null!; // someone who follows

    public int FollowedId { get; set; }
    public User FollowedUser { get; set; } = null!; // someone who is followed

    #endregion

    #region Behaviars

    public void Block() => IsBlock = true;
    public void UnBlock() => IsBlock = false;

    #endregion


}

/*public class UserBlock : BaseEntity
{
    #region Navigation Properties
    public int BlockerUserId { get; set; }
    public User BlockerUser { get; set; } = null!;

    public int BlockedUserId { get; set; }
    public User BlockedUser { get; set; } = null!;


    //Ef Core Configuration  Unique Index => (BlockerUserId, BlockedUserId)
    #endregion
}*/




