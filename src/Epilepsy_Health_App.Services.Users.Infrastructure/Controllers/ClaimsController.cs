using Epilepsy_Health_App.Services.Users.Application.Controllers;
using Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Controllers
{
    internal sealed class ClaimsController : IClaimsController
    {
        public Guid GetId(IEnumerable<Claim> claims)
        {
            return claims is null
                ? throw new EmptyClaimsException()
                : Guid.TryParse(claims.FirstOrDefault(x => x.Type == "sub").Value, out var result) ? result : throw new EmptyClaimsException();
        }
    }
}
