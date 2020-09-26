using AutoMapper;
using Epilepsy_Health_App.Services.Users.Application.DTO;
using Epilepsy_Health_App.Services.Users.Core.Entities;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.AutoMapper
{
    internal sealed class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
