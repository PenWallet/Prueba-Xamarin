using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Weather.Models;
using Xamarin_Weather.Services;

namespace Xamarin_Weather.ViewModels
{
    public class TodayViewModel : VMBase
    {
        public TodayViewModel()
        {
            _weatherToday = WeatherAPICalls.GetTodayWeather();
        }

        private WeatherToday _weatherToday;
        public WeatherToday weatherToday
        {
            get
            {
                return _weatherToday;
            }
            set
            {
                _weatherToday = value;
                NotifyPropertyChanged(nameof(weatherToday));
            }
        }

        public string sunOrMoonImage
        {
            get
            {
                if (_weatherToday.dt < _weatherToday.sys.sunset)
                    return "sun.png";
                else
                    return "night.png";
            }
        }

        public string correctGMT
        {
            get
            {
                if (_weatherToday == null)
                    return "";

                return string.Format(("GMT" + (_weatherToday.timezone < 0 ? "" : "+") + "{0:0.#}"), _weatherToday.timezone/3600);
            }
        }
    }
}
