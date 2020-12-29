using Epilepsy_Health_App.Services.Users.Application.Controllers;
using Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Controllers
{
    internal sealed class ClaimsController : IClaimsController
    {
        public Guid GetUserId(string jwt)
        {
            jwt = jwt.Remove(0, jwt.IndexOf(' ')).Trim();
            return new JwtSecurityTokenHandler().ReadToken(jwt) as JwtSecurityToken is null
                       ? throw new EmptyClaimsException()
                       : !Guid.TryParse((new JwtSecurityTokenHandler().ReadToken(jwt) as JwtSecurityToken).Claims.First(claim => claim.Type == "sub").Value, out Guid result)
                       ? throw new EmptyClaimsException()
                       : result;
        }
    }
}
