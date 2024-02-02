using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// MyController.cs
using NetTrainingJan.Services;

namespace NetTrainingJan.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MyController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public MyController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IActionResult GetWeatherReport()
        {
            var weatherReport = _weatherService.GetWeatherReport();
            return Ok(weatherReport);
        }
    }

}
