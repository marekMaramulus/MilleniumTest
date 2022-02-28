namespace MilleniumTest.Repository;

public interface IWeatherRepository
{
    IEnumerable<WeatherForecast> GetWeatherForecast();
}