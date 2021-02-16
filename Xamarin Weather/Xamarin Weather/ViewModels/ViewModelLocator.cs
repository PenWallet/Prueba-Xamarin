using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Weather.Models;
using Xamarin_Weather.Services;

namespace Xamarin_Weather.ViewModels
{
    public static class ViewModelLocator
    {
        private static TodayViewModel _todayViewModel;
        public static TodayViewModel todayViewModel => _todayViewModel ?? (_todayViewModel = new TodayViewModel());

        private static ForecastViewModel _forecastViewModel;
        public static ForecastViewModel forecastViewModel => _forecastViewModel ?? (_forecastViewModel = new ForecastViewModel());

        private static WeatherToday _weatherToday;
        public static WeatherToday weatherToday
        {
            get { return _weatherToday; }
            set
            {
                _weatherToday = value;
            }
        }
    }
}
