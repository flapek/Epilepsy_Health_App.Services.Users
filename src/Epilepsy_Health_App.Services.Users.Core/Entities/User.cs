using Epilepsy_Health_App.Services.Users.Core.Exceptions;
using System;

namespace Epilepsy_Health_App.Services.Users.Core.Entities
{
    public class User : AggregateRoot
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Anonymous { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public DateTime DayOfBirth { get; private set; }

        public User(Guid id, string email, string password, DateTime createdAt)
        {
            Id = id;
            Email = email.ToLowerInvariant();
            Password = password;
            CreatedAt = createdAt;
        }

        public User(string email, string password, DateTime createdAt, bool anonymous,
            string firstname, string lastname, double weight, double height, DateTime dayOfBirth)
        {
            if (anonymous)
            {
                firstname = "";
                lastname = "";
            }

            CheckName(firstname, lastname);

            Email = email;
            Password = password;
            CreatedAt = createdAt;
            Anonymous = anonymous;
            Firstname = firstname;
            Lastname = lastname;
            Weight = weight;
            Height = height;
            DayOfBirth = dayOfBirth;
        }

        private bool CheckName(string firstName, string lastName)
        {
            return string.IsNullOrEmpty(firstName)
                ? throw new UserFirstnameException()
                : string.IsNullOrEmpty(lastName) 
                ? throw new UserLastnameException() 
                : true; 
        }
    }
}
