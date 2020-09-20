﻿using Epilepsy_Health_App.Services.Users.Infrastructure.Mongo.Documents;
using Joint.DB.Mongo;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Mongo
{
    public static class Extensions
    {
        public static IApplicationBuilder UseMongo(this IApplicationBuilder builder)
        {
            using var scope = builder.ApplicationServices.CreateScope();

            var users = scope.ServiceProvider.GetService<IMongoRepository<UserDocument, Guid>>().Collection;
            var userBuilder = Builders<UserDocument>.IndexKeys;
            Task.Run(async () => await users.Indexes.CreateOneAsync(
                new CreateIndexModel<UserDocument>(userBuilder.Ascending(i => i.Email),
                    new CreateIndexOptions
                    {
                        Unique = true
                    })));

            return builder;
        }
    }
}
