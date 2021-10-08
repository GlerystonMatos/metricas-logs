using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
            => _logger = logger;

        [HttpGet]
        public IActionResult Information()
        {
            _logger.LogInformation("call to LogController controller Information method");
            return Ok();
        }

        [HttpGet]
        public IActionResult Debug()
        {
            _logger.LogDebug("call to LogController controller Debug method");
            return Ok();
        }

        [HttpGet]
        public IActionResult Error()
        {
            _logger.LogError("call to LogController controller Error method");
            return Ok();
        }

        [HttpGet]
        public IActionResult Trace()
        {
            _logger.LogTrace("call to LogController controller Trace method");
            return Ok();
        }

        [HttpGet]
        public IActionResult Warning()
        {
            _logger.LogWarning("call to LogController controller Warning method");
            return Ok();
        }

        [HttpGet]
        public IActionResult Critical()
        {
            _logger.LogCritical("call to LogController controller Critical method");
            return Ok();
        }
    }
}