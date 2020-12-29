using Joint.Exception.Exceptions;
using System.Net;

namespace Epilepsy_Health_App.Services.Users.Infrastructure.Exceptions
{
    public class EmptyClaimsException : InfrastructureException
    {
        public override string Code => "empty_claims_exception";
        public override HttpStatusCode StatusCodes => HttpStatusCode.BadRequest;

        public EmptyClaimsException() : base("User claims not found.")
        {
        }
    }
}
