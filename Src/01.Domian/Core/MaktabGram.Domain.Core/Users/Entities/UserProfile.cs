
using MaktabGram.Domain.Core.Users.ValueObjects;

namespace MaktabGram.Domain.Core.Users.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public Email? Email { get; set; }
        public Mobile? Mobile { get; set; }


        
    }
}
