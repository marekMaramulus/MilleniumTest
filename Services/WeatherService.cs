using MilleniumTest.Repository;

namespace MilleniumTest.Services
{
    public class WeatherService : IWeatherService
    {
        public IWeatherRepository WeatherRepository { get; set; }

        public WeatherService(IWeatherRepository weatherRepository)
        {
            this.WeatherRepository = weatherRepository;
        }

        public IEnumerable<WeatherForecast> GetWeather()
        {
            return WeatherRepository.GetWeatherForecast();
        }
    }
}
