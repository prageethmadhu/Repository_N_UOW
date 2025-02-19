using System;

namespace new_api_layout.Services;

public class WeatherService : IWeatherService
{
    public string GetWeatherForecast()
    {
         return "Sunny with a chance of rain";
    }
}
