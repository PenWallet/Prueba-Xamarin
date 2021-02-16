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
            ViewModelLocator.weatherToday = WeatherAPICalls.GetTodayAndForecastWeather();
        }

        public WeatherToday weatherToday
        {
            get
            {
                return ViewModelLocator.weatherToday;
            }
        }

        public string sunOrMoonImage
        {
            get
            {
                if (weatherToday.dt < ViewModelLocator.weatherToday.sys.sunset)
                    return "sun.png";
                else
                    return "night.png";
            }
        }

        public string correctGMT
        {
            get
            {
                if (weatherToday == null)
                    return "";

                return string.Format(("GMT" + (weatherToday.timezone < 0 ? "" : "+") + "{0:0.#}"), weatherToday.timezone/3600);
            }
        }
    }
}
