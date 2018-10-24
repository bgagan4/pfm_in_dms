using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace FileManager
{
    public sealed class BoolToGridLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool) || !(parameter is string))
            {
                return new GridLength(0);
            }

            if (!((bool)value))
            {
                return new GridLength(0);
            }

            var str = parameter as string;
            if (str.Equals("Auto"))
            {
                return new GridLength(0, GridUnitType.Auto);
            }

            if (str.Equals("*"))
            {
                return new GridLength(1, GridUnitType.Star);
            }

            if (str.EndsWith("*"))
            {
                var length = Double.Parse(str.Substring(0, str.Length - 1));
                return new GridLength(length, GridUnitType.Star);
            }

            var len = Double.Parse(str);
            return new GridLength(len);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
