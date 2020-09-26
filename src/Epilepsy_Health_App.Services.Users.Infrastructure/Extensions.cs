using Epilepsy_Health_App.Services.Users.Core.Repositories;
using Epilepsy_Health_App.Services.Users.Infrastructure.AutoMapper;
using Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Repositories;
using Joint.Builders;
using Joint.CQRS.Queries;
using Joint.DB.Mongo;
using Joint.Exception;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Epilepsy_Health_App.Services.Users.Infrastructure
{
    public static class Extensions
    {
        public static IJointBuilder AddInfrastructure(this IJointBuilder builder)
        {
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddAutoMapperProfile();

            return builder
                .AddMongo()
                .AddMongoRepository<UserDocument, Guid>("users")
                .AddErrorHandler<ExceptionToResponseMapper>()
                .AddQueryHandlers()
                .AddInMemoryQueryDispatcher();
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseErrorHandler()
                .UseMongo();

            return app;
        }
    }
}
