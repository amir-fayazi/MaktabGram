

using MaktabGram.Domain.Core._common.Entities;
using MaktabGram.Domain.Core.UserAgg.Dtos;
using MaktabGram.Domain.Core.UserAgg.Entities;

namespace MaktabGram.Domain.Core.UserAgg.Contracts
{
    public interface IUserRepository
    {
        public UserLoginOutputDto? Login(string username, string password);
        public bool Register(RegisterUserInputDto model);

        public bool IsActive(string mobile);
        public bool MobileExists(string mobile);
    }
}
