using Joint.Exception.Exceptions;
using System.Net;

namespace Epilepsy_Health_App.Services.Users.Core.Exceptions
{
    public class UserLastnameException : DomainException
    {
        public override string Code => "user_lastname_exception";
        public override HttpStatusCode StatusCodes => HttpStatusCode.BadRequest;

        public UserLastnameException() : base("User lastname cannot be null if you don't want be anonymous!")
        {
        }
    }
}
