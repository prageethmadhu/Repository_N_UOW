using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_api_layout.Services;

namespace new_api_layout.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {        
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IActionResult GetWeather()
        {
            var weather = _weatherService.GetWeatherForecast();
            return Ok(weather);
        }

        
    }
}
