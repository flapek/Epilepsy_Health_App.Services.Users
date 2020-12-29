using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Epilepsy_Health_App.Services.Users.Application.Commands;
using Epilepsy_Health_App.Services.Users.Application.Controllers;
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
        readonly IClaimsController _claimsController;

        public UsersController(IQueryDispatcher queryDispatcher, 
            ICommandDispatcher commandDispatcher, IClaimsController claimsController)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
            _claimsController = claimsController;
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <param name="email">Filter by email</param>
        /// <param name="id">Filter by id</param>
        /// <returns>Return all user or if you send request with filters return users by filter</returns>
        [HttpGet]
        [ProducesResponseType(typeof(UsersDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromQuery] List<string> email, [FromQuery] List<Guid> id)
            => Ok(await _queryDispatcher.QueryAsync(new GetUsers
            {
                Ids = id,
                Emails = email
            }));

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="command">what you want update</param>
        /// <returns>Status 202 if request pass succesfuly</returns>
        [HttpPost("update")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromBody] UpdateUserData command)
        {
            command.Id = _claimsController.GetId(HttpContext.User.Identity as ClaimsIdentity);
            return Accepted(_commandDispatcher.SendAsync(command));
        }
    }
}
