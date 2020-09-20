using System.Collections.Generic;
using System.Threading.Tasks;
using Epilepsy_Health_App.Services.Users.Application.DTO;
using Epilepsy_Health_App.Services.Users.Application.Queries;
using Joint.CQRS.Commands;
using Joint.CQRS.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Epilepsy_Health_App.Services.Users.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IQueryDispatcher _queryDispatcher;
        readonly ICommandDispatcher _commandDispatcher;
        public UsersController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <param name="usernames">Filter</param>
        /// <returns>Return all user or if you send request with filters return users by filter</returns>
        [HttpGet]
        [ProducesResponseType(typeof(UsersDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromQuery] List<string> usernames)
            => Ok(await _queryDispatcher.QueryAsync(new GetUsers()));
    }
}
