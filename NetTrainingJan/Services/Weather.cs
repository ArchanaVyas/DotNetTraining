

namespace NetTrainingJan.Services
{
    // WeatherService.cs

    public interface IWeatherService
    {
        string GetWeatherReport();
    }

    public class WeatherService : IWeatherService
    {
        public string GetWeatherReport()
        {
            return "Today's weather: Sunny with a chance of clouds!";
        }
    }

}
