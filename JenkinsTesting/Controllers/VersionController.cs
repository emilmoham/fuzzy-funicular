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
            string revision = _config.GetValue<string>("revision");
            return Ok($"{env} -- {revision}");
        }
    }
}
