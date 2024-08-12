using Microsoft.AspNetCore.Mvc;

namespace new_angular_app.Server.Controllers
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

        [HttpGet(Name = "GetLogin")]
        public LoginModel Get()
        {
            return new LoginModel
            {
                Id = new Guid(),
                Email = "TestEmail@email.com",
                Password = "1234",
            };
        }
    }
}
