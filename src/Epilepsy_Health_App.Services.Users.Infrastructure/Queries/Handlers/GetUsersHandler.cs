using AutoMapper;
using Epilepsy_Health_App.Services.Users.Application.DTO;
using Epilepsy_Health_App.Services.Users.Application.Queries;
using Epilepsy_Health_App.Services.Users.Core.Repositories;
using Joint.CQRS.Queries;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Queries.Handlers
{
    public sealed class GetUsersHandler : IQueryHandler<GetUsers, UsersDto>
    {
        readonly IUserRepository _userRepository;
        readonly IMapper _mapper;

        public GetUsersHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UsersDto> HandleAsync(GetUsers query)
        {
            if (query.Emails.Count == 0 && query.Ids.Count == 0)
                return _mapper.Map<UsersDto>(await _userRepository.GetAsync());

            return null;
        }
    }
}
