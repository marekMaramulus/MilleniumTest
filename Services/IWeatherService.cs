﻿namespace MilleniumTest.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetWeather();
}