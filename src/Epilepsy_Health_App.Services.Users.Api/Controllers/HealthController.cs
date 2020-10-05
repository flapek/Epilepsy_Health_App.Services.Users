using Microsoft.AspNetCore.Mvc;

namespace Epilepsy_Health_App.Services.Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping() => Ok();
    }
}
