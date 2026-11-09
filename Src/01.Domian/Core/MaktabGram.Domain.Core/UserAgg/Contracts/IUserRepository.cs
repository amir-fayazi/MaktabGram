

using MaktabGram.Domain.Core._common.Entities;
using MaktabGram.Domain.Core.UserAgg.Dtos;

namespace MaktabGram.Domain.Core.UserAgg.Contracts
{
    public interface IUserRepository
    {
        public Result<bool> Login(string username, string password);
        public Result<bool> Register(RegisterUserInputDto model);

        public Result<bool> IsActive(string mobile);
        public Result<bool> MobileExists(string mobile);
    }
}
