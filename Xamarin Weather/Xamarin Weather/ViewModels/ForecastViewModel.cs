using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Weather.Models;
using Xamarin_Weather.Services;

namespace Xamarin_Weather.ViewModels
{
    public class ForecastViewModel : VMBase
    {
        public ForecastViewModel()
        {
            _weatherForecast = WeatherAPICalls.GetForecastWeather();
        }

        private WeatherForecast _weatherForecast;
        public WeatherForecast weatherForecast
        {
            get
            {
                return _weatherForecast;
            }
            set
            {
                _weatherForecast = value;
                NotifyPropertyChanged(nameof(weatherForecast));
            }
        }
    }
}
