using Joint.Types;
using System;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents
{
    internal sealed class UserDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
    }
}
