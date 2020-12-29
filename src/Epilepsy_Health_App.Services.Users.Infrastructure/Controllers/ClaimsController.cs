using Epilepsy_Health_App.Services.Users.Application.Controllers;
using Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions;
using System;
using System.Security.Claims;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Controllers
{
    internal sealed class ClaimsController : IClaimsController
    {
        public Guid GetId(ClaimsIdentity identity)
        {
            if (identity is null)
                throw new EmptyClaimsException();

            if (Guid.TryParse(identity.FindFirst("sub").Value, out var result))
                return result;

            throw new EmptyClaimsException();
        }
    }
}
