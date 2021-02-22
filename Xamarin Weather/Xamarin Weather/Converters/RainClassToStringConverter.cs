using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin_Weather.Models;
using static Xamarin_Weather.Models.WeatherForecast;

namespace Xamarin_Weather.Converters
{
    class RainClassToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || ((Rain)value)._3h == 0)
                return "No";
            else
                return string.Format("{0:0.#} mL", ((Rain)value)._3h);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
