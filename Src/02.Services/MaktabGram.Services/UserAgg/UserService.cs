using MaktabGram.Domain.Core._common.Entities;
using MaktabGram.Domain.Core.UserAgg.Contracts;
using MaktabGram.Domain.Core.UserAgg.Dtos;
using MaktabGram.Domain.Core.UserAgg.Entities;
using MaktabGram.Framework;
using MaktabGram.Infrastructure.EfCore.Repositories.UserAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabGram.Services.UserAgg
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }
        public Result<bool> Login(string mobile, string password)
        {
            var login = userRepository.Login(mobile, password.ToMd5Hex());

            if (login is null)
                return Result<bool>.Failure("نام کاربری یا رمزعبور اشتباه است.", false);

            if(!login.IsActive)
                return Result<bool>.Failure("کاربر با این شماره موبایل فعال نمی باشد.", false);

            return Result<bool>.Success("لاگین با موفقیت انجام شد.");/////////
        }

        public Result<bool> Register(RegisterUserInputDto model)
        {
            var mobileExist = userRepository.MobileExists(model.Mobile);

            if(mobileExist)
                return Result<bool>.Failure("کاربر با این شماره موبایل موجود می باشد.", false);

            model.Password = model.Password.ToMd5Hex();

            //if (userRepository.Register(model))
                return Result<bool>.Success("ثبت نام با موفقیت انجام شد.", true);
        }
    }
}
