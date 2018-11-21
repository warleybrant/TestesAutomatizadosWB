using System;
using System.Globalization;
using Xamarin.Forms;

namespace OrdersSample.Models
{
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                return ((DateTime)value).ToString("yyyy.MM.dd");
            }

            System.Diagnostics.Debug.Assert(false);
            return "<yyyy-MM-dd>";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DateTime.Now;
        }
    }
}
