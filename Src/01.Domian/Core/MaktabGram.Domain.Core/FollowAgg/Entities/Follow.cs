

using MaktabGram.Domain.Core.Users.Entities;

namespace MaktabGram.Domain.Core.Follow.Entities
{
    public class Follow
    {
        public User Follower { get; set; }
        public int FollowerId { get; set; }
        public User Followed { get; set; }
        public int FollowedId { get; set; }

        public DateTime FollowedAt { get; set; }
    }
}
