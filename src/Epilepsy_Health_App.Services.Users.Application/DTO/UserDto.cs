using System;

namespace Epilepsy_Health_App.Services.Users.Application.DTO
{
    public class UserDto
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Anonymous { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public DateTime DayOfBirth { get; private set; }

        public UserDto()
        {
        }
    }
}
