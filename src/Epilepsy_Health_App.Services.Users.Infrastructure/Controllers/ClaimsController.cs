using Epilepsy_Health_App.Services.Users.Application.Controllers;
using Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions;
using System;
using System.Security.Claims;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Controllers
{
    internal sealed class ClaimsController : IClaimsController
    {
        public Guid GetUserId(ClaimsIdentity claims) 
            => claims is null
            ? throw new EmptyClaimsException()
            : !Guid.TryParse(claims.FindFirst("sub")?.Value, out Guid result) 
            ? throw new EmptyClaimsException() 
            : result;
    }
}
