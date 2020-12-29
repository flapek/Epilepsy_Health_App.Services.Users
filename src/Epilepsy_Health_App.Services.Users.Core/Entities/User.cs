using Epilepsy_Health_App.Services.Users.Core.Exceptions;
using System;

namespace Epilepsy_Health_App.Services.Users.Core.Entities
{
    public class User : AggregateRoot
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Anonymous { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public DateTime DayOfBirth { get; private set; }

        public User(Guid id, bool anonymous, string firstname,
            string lastname, double height, double weight, DateTime dayOfBirth)
        {
            if (anonymous)
            {
                firstname = "";
                lastname = "";
            }

            Id = id;
            Anonymous = anonymous;
            Firstname = firstname;
            Lastname = lastname;
            Height = height;
            Weight = weight;
            DayOfBirth = dayOfBirth;
        }

        public User(Guid id, string email, string password, bool anonymous,
            string firstname, string lastname, double weight, double height, DateTime dayOfBirth)
            : this(id, anonymous, firstname, lastname, height, weight, dayOfBirth)
        {
            Email = email;
            Password = password;
        }
    }
}
