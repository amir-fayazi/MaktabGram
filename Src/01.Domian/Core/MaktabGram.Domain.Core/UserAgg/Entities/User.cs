
using MaktabGram.Domain.Core._common;
using MaktabGram.Domain.Core.Comments.Entities;
using MaktabGram.Domain.Core.Posts.Entities;
using MaktabGram.Domain.Core.Users.ValueObjects;

namespace MaktabGram.Domain.Core.Users.Entities
{
    public class User : BaseEntity
    {
        private User()
        {
            
        }

        public string Username { get; set; }
        public Mobile Mobile { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; private set; }
        public bool VerifiedBadge { get; private set; }

        #region NavigationProperties

        public List<Post> Posts { get; set; }
        public List<PostSave> PostSaves { get; set; } = new();
        public List<PostLike> PostLikes { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
        public List<User> Followers { get; set; } = new();
        public List<User> Followings { get; set; } = new();
        public List<CommentLike> CommentLikes { get; set; } = new();
        public List<PostTag> PostTags { get; set; } = new();
        #endregion



    }


}
