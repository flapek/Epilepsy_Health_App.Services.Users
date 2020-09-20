using Epilepsy_Health_App.Services.Users.Application.DTO;
using Joint.CQRS.Queries;
using System;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.Users.Application.Queries.Handlers
{
    public class GetUsersHandler : IQueryHandler<GetUsers, UsersDto>
    {
        public GetUsersHandler()
        {
        }

        public Task<UsersDto> HandleAsync(GetUsers query)
        {
            throw new NotImplementedException();
        }
    }
}
