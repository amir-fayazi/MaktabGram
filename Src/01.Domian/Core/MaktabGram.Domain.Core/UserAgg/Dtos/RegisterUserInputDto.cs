using MaktabGram.Domain.Core.UserAgg.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaktabGram.Domain.Core.UserAgg.Dtos
{
    public class RegisterUserInputDto
    {
        public string Mobile { get; set; }
        public string? Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
