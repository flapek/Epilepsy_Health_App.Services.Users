using Joint.CQRS.Commands;
using System;
using System.Text.Json.Serialization;

namespace Epilepsy_Health_App.Services.Users.Application.Commands
{
    public class UpdateUserData : ICommand
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public bool Anonymous { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime DayOfBirth { get; set; }
    }
}
