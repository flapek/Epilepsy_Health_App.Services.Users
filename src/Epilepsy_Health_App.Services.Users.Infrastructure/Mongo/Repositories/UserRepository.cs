using Epilepsy_Health_App.Services.Users.Core.Entities;
using Epilepsy_Health_App.Services.Users.Core.Repositories;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents;
using Joint.DB.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly IMongoRepository<UserDocument, Guid> _repository;

        public UserRepository(IMongoRepository<UserDocument, Guid> repository)
            => _repository = repository;

        public async Task<List<User>> GetAsync()
            => (await _repository.FindAsync(x => true))?.AsEntityList();

        public async Task<User> GetAsync(Guid id)
            => (await _repository.GetAsync(id)).AsEntity();

        public async Task<User> GetAsync(string email)
            => (await _repository.GetAsync(x => x.Email == email)).AsEntity();

        public Task<List<User>> GetAsync(List<Guid> ids)
            => Task.FromResult(ids.Select(id => _repository.GetAsync(id).Result.AsEntity()).ToList());

        public Task<List<User>> GetAsync(List<string> emails)
            => Task.FromResult(emails.Select(email => _repository.GetAsync(x => x.Email == email).Result.AsEntity()).ToList());

        public async Task UpdateAsync(Guid id, User user)
        {
            var userFromDb = await GetAsync(id);
            user = new User(user.Id, userFromDb.Email, userFromDb.Password, 
                user.Anonymous, user.Firstname, user.Lastname, user.Weight,
                user.Height, user.DayOfBirth);
            await _repository.UpdateAsync(user.AsDocument(), x => x.Id == id);
        }
    }
}