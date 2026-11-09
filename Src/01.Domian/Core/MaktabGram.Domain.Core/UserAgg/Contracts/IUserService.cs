using MaktabGram.Domain.Core._common.Entities;
using MaktabGram.Domain.Core.UserAgg.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabGram.Domain.Core.UserAgg.Contracts
{
    public interface IUserService
    {
        public Result<bool> Login(string username, string password);
        public Result<bool> Register(RegisterUserInputDto model);
    }
}
