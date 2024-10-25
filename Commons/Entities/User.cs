using System;
using Commons.Models;
using Commons.Shared;

namespace Commons.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

        public RefreshToken RefreshToken { get; set; }
    }
}