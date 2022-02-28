using MilleniumTest;
using MilleniumTest.Models;

namespace MilleniumTest.Repository;

public class WeatherRepository : IWeatherRepository
{
    public IEnumerable<WeatherForecast> GetWeatherForecast()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = SummaryTypes.Summaries[Random.Shared.Next(SummaryTypes.Summaries.Length)]
            })
            .ToArray();
    }
};
