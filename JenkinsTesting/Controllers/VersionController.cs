using Microsoft.AspNetCore.Mvc;

namespace JenkinsTesting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : Controller
    {
        public IConfiguration _config;

        public VersionController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public IActionResult IsAlive()
        {
            string env = _config.GetValue<string>("where");
            string version = _config.GetValue<string>("version");
            return Ok($"{env} -- {version}");
        }
    }
}
