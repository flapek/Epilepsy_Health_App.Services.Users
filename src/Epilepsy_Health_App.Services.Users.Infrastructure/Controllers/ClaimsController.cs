using Epilepsy_Health_App.Services.Users.Application.Controllers;
using Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions;
using System;
using System.Security.Claims;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Controllers
{
    internal sealed class ClaimsController : IClaimsController
    {
        public Guid GetUserId(ClaimsIdentity claims)
        {
            Guid? result = null;
            if (claims != null)
            {
                var id = claims.FindFirst("sub")?.Value;
                if (string.IsNullOrEmpty(id) || !Guid.TryParse(id, out Guid userId))
                    throw new EmptyClaimsException();
                result = userId;
            }

            return result.Value;
        }
    }
}
