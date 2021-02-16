using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin_Weather.Models;

namespace Xamarin_Weather.Converters
{
    class StringToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "zerooned.png";
            else
            {
                switch((string)value)
                {
                    case "01d": return "zerooned.png";
                    case "01n": return "zeroonen.png";
                    case "02d": return "zerotwod.png";
                    case "02n": return "zerotwon.png";
                    case "03d": return "zerothreed.png";
                    case "03n": return "zerothreen.png";
                    case "04d": return "zerofourd.png";
                    case "04n": return "zerofourn.png";
                    case "09d": return "zeronined.png";
                    case "09n": return "zeroninen.png";
                    case "10d": return "tend.png";
                    case "10n": return "tenn.png";
                    case "11d": return "elevend.png";
                    case "11n": return "elevenn.png";
                    case "13d": return "thirteend.png";
                    case "13n": return "thirteenn.png";
                    case "50d": return "fiftyd.png";
                    case "50n": return "fiftyn.png";
                    default: return "zerooned.png";
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
