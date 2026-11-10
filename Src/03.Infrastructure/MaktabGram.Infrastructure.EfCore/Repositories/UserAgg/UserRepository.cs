

using MaktabGram.Domain.Core._common.Entities;
using MaktabGram.Domain.Core.UserAgg.Contracts;
using MaktabGram.Domain.Core.UserAgg.Dtos;
using MaktabGram.Domain.Core.UserAgg.Entities;
using MaktabGram.Domain.Core.UserAgg.ValueObjects;
using MaktabGram.Infrastructure.EfCore.Persistence;

namespace MaktabGram.Infrastructure.EfCore.Repositories.UserAgg
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext dbContext;

        public UserRepository()
        {
            dbContext = new AppDbContext();
        }

        public bool IsActive(string mobile)
        {
            var normalizedMobile = Mobile.Create(mobile).Value;

            return dbContext.Users.Any(u => u.Mobile.Value == normalizedMobile && u.IsActive);
        }

        public bool MobileExists(string mobile)
        {
            var normalizedMobile = Mobile.Create(mobile).Value;
            return dbContext.Users.Any(u => u.Mobile.Value == normalizedMobile);
        }

        public UserLoginOutputDto? Login(string mobile, string password)
        {
            return dbContext.Users.Where(u => u.Mobile.Value == mobile && u.PasswordHash == password)
                                  .Select(x => new UserLoginOutputDto
                                  {
                                      Id = x.Id,
                                      FirstName = x.Profile.FirstName,
                                      LastName = x.Profile.LastName,
                                      Email = x.Profile.Email.Value,
                                      Mobile = x.Mobile.Value,
                                      Username = x.Username,
                                      IsActive = x.IsActive
                                  })
                                  .ToList()
                                  .FirstOrDefault();


        }

        public bool Register(RegisterUserInputDto model)
        {

            var entity = new User
            {
                Mobile = Mobile.Create(model.Mobile),
                Username = model.Username,
                PasswordHash = model.Password,
                Profile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName
                }
            };

            dbContext.Users.Add(entity);
            return dbContext.SaveChanges() > 0;


        }


    }
}
