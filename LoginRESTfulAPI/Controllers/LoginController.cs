using LoginRESTfulAPI.BLL;
using LoginRESTfulAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoginRESTfulAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(string user, string password)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
                return BadRequest();

            var loginDao = new LoginDao();
            if (loginDao.IsRegistered(user, password))
            {
                var loginOutput = new LoginOutput() { title = "Everything is fine!", status = 200 };
                return Ok(loginOutput);
            }
            else
                return NotFound();
        }
    }
}
