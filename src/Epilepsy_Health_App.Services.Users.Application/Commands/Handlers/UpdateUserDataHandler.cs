using Epilepsy_Health_App.Services.Users.Core.Entities;
using Epilepsy_Health_App.Services.Users.Core.Repositories;
using Joint.CQRS.Commands;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.Users.Application.Commands.Handlers
{
    public class UpdateUserDataHandler : ICommandHandler<UpdateUserData>
    {
        readonly IUserRepository _userRepository;

        public UpdateUserDataHandler(IUserRepository userRepository) 
            => _userRepository = userRepository;

        public async Task HandleAsync(UpdateUserData command) 
            => await _userRepository.UpdateAsync(command.Id, new User(command.Id, command.Anonymous, command.Firstname,
                command.Lastname, command.Height, command.Weight, command.DayOfBirth));
    }
}
