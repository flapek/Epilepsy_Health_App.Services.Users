using Joint.Exception.Exceptions;
using System.Net;

namespace Epilepsy_Health_App.Services.Users.Core.Exceptions
{
    public class UserFirstnameException : DomainException
    {
        public override string Code => "user_firstname_exception";
        public override HttpStatusCode StatusCodes => HttpStatusCode.BadRequest;
        
        public UserFirstnameException() : base("User firstname cannot be null if you don't want be anonymous!")
        {
        }

    }
}
