using System;
using System.Collections.Generic;
using System.Text;
using WebApi;

namespace BusinessLogic.Interfaces
{
    public interface IWeatherService
    {
        WeatherForecast[] GetWeather(); 
    }
}
