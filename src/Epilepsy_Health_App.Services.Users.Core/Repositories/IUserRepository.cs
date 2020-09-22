using Epilepsy_Health_App.Services.Users.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epilepsy_Health_App.Services.Users.Core.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>All users</returns>
        List<User> Get();
        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id">filter</param>
        /// <returns>One user</returns>
        User Get(Guid id);
        /// <summary>
        /// Get user by email
        /// </summary>
        /// <param name="email">filter</param>
        /// <returns>One user</returns>
        User Get(string email);
        /// <summary>
        /// Get users by list of id
        /// </summary>
        /// <param name="ids">filter</param>
        /// <returns>All users match to ids</returns>
        List<User> Get(List<Guid> ids);
        /// <summary>
        /// Get users by list od emails
        /// </summary>
        /// <param name="emails">filter</param>
        /// <returns>All users match to email</returns>
        List<User> Get(List<string> emails);
    }
}
