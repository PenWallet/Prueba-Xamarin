using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_Weather.Converters
{
    public class UnixToCleanerDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return value;

            string str = "";

            long unix = (long)(int)value;
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unix);

            //If the date is today, then we add Today instead of the date. Same for tomorrow. If not, then just add the date
            if (dateTimeOffset.Date == DateTimeOffset.Now.Date)
                str += "Today";
            else if (dateTimeOffset.Date == DateTimeOffset.Now.Date.AddDays(1))
                str += "Tomorrow";
            else
                str += dateTimeOffset.Date.ToString("dddd");

            str += "\n"+dateTimeOffset.TimeOfDay.ToString("hh\\:mm");

            return str;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
