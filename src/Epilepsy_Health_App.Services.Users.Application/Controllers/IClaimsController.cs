using System;
using System.Security.Claims;

namespace Epilepsy_Health_App.Services.Users.Application.Controllers
{
    public interface IClaimsController
    {
        Guid GetUserId(string jwt);
    }
}
