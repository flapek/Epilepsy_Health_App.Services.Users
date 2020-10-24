using Joint.Types;
using System;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents
{
    internal sealed class UserDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Anonymous { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime DayOfBirth { get; set; }
    }
}
