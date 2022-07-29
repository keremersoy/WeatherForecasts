using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecasts.Domain.Models;

namespace WeatherForecasts.Domain.Abstractions
{
    public interface IWeatherForecastRepository
    {
        List<WeatherForecast> GetForecasts();
    }
}
