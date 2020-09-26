using Epilepsy_Health_App.Services.Users.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents
{
    internal static class Extensions
    {
        public static User AsEntity(this UserDocument document)
            => new User(document.Id, document.Email, document.Password, document.CreatedAt);

        public static UserDocument AsDocument(this User entity)
            => new UserDocument
            {
                Id = entity.Id,
                Email = entity.Email,
                Password = entity.Password,
                CreatedAt = entity.CreatedAt
            };

        public static List<User> AsEntityList(this IReadOnlyList<UserDocument> userDocuments) 
            => userDocuments.Select(document => document.AsEntity()).ToList();

        public static List<UserDocument> AsDocumentList(this List<User> userDocuments)
            => userDocuments.Select(document => document.AsDocument()).ToList();
    }
}
