using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.AutoMapper
{
    internal static class Extension
    {
        public static IServiceCollection AddAutoMapperProfile(this IServiceCollection services) 
            => services
            .AddAutoMapper(typeof(UsersProfile));
    }
}
