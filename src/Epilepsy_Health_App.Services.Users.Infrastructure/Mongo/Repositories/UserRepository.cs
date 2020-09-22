using Epilepsy_Health_App.Services.Users.Core.Repositories;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents;
using Joint.DB.Mongo;
using System;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly IMongoRepository<UserDocument, Guid> _repository;

        public UserRepository(IMongoRepository<UserDocument, Guid> repository)
        {
            _repository = repository;
        }
    }
}