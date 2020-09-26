using System;

namespace Epilepsy_Health_App.Services.Users.Core.Entities
{
    public class User : AggregateRoot
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public User(Guid id, string email, string password, DateTime createdAt)
        {
            Id = id;
            Email = email.ToLowerInvariant();
            Password = password;
            CreatedAt = createdAt;
        }
    }
}
