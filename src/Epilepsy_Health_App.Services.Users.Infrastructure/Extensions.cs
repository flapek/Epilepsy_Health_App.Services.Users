using Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo;
using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents;
using Joint.Builders;
using Joint.CQRS.Queries;
using Joint.DB.Mongo;
using Joint.Exception;
using Microsoft.AspNetCore.Builder;
using System;

namespace Epilepsy_Health_App.Services.Users.Infrastructure
{
    public static class Extensions
    {
        public static IJointBuilder AddInfrastructure(this IJointBuilder builder)
        {

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
