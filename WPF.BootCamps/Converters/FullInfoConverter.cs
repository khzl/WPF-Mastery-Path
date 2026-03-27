using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace WPF.BootCamps.Converters
{
    public class FullInfoConverter : IMultiValueConverter
    {
        public object? Convert(object[] values, Type targetType, object? parameter, CultureInfo culture)
        {
            string? first = values[0]?.ToString();
            string? last = values[1]?.ToString();
            string? age = values[2]?.ToString();

            return $"{first} {last} - Age: {age}";
        }

        public object[] ConvertBack(object? value, Type[] targetTypes, object? parameter,CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
