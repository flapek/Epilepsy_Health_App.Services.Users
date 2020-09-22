using Epilepsy_Health_App.Services.Users.Application.DTO;
using Joint.CQRS.Queries;
using System;
using System.Collections.Generic;

namespace Epilepsy_Health_App.Services.Users.Application.Queries
{
    public class GetUsers : IQuery<UsersDto>
    {
        public List<Guid> Ids { get; set; }
        public List<string> Emails { get; set; }
    }
}
