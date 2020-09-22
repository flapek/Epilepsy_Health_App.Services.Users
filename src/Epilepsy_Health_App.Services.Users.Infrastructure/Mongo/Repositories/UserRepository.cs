using Epilepsy_Health_App.Services.Users.Core.Entities;
using Epilepsy_Health_App.Services.Users.Core.Repositories;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents;
using Joint.DB.Mongo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly IMongoRepository<UserDocument, Guid> _repository;

        public UserRepository(IMongoRepository<UserDocument, Guid> repository)
        {
            _repository = repository;
        }

        public Task<List<User>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAsync(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAsync(List<string> emails)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Guid id, User user)
        {
            throw new NotImplementedException();
        }
    }
}