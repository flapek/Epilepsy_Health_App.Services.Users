using Epilepsy_Health_App.Services.Users.Core.Repositories;
using Joint.CQRS.Commands;
using System;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.Users.Application.Commands.Handlers
{
    public class UpdateUserHandler : ICommandHandler<UpdateUser>
    {
        readonly IUserRepository _userRepository;

        public UpdateUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

        public Task HandleAsync(UpdateUser command)
        {
            throw new NotImplementedException();
        }
    }
}
