using Microsoft.AspNetCore.Mvc;

namespace CustomCs.Controllers
{
    [ApiController]
    [Route("/")]
    public class TestController : ControllerBase
    {
        private readonly IConfiguration _confguration;

        public TestController(IConfiguration configuration)
        {
            _confguration = configuration;
        }

        [HttpGet]
        public IActionResult Info()
        {
            var appName = _confguration["appName"];

            return Ok(new
            {
                appName
            });
        }

    }
}