using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace WebResume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILoggerManager _loggerManager;

        public WeatherForecastController(ILoggerManager logger)
        {
          _loggerManager = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
          _loggerManager.LogInfo("¬от информационное сообщение от нашего контроллера значений.");
          _loggerManager.LogDebug("¬от отладочное сообщение от нашего контроллера значений.");
          _loggerManager.LogWarn("¬от сообщение о предупреждении от нашего контроллера значений.");
          _loggerManager.LogError("¬от сообщение об ошибке от нашего контроллера значений.");

          return ["value1", "value2" ];
        }
    }
}
