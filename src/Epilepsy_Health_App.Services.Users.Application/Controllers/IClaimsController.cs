using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Epilepsy_Health_App.Services.Users.Application.Controllers
{
    public interface IClaimsController
    {
        Guid GetId(IEnumerable<Claim> claims);
    }
}
