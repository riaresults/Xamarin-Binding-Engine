using System;
using System.Collections;
using System.Globalization;

namespace BindingEngine.Converters
{
    [Android.Runtime.Preserve]
    public class SpinnerToObjectConverter : IBindingValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (IList)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(string))
            {
                var propertyInfo = value.GetType().GetProperty("Instance");
                return propertyInfo == null ? null : propertyInfo.GetValue(value, null);
            }
            return value.ToString();
        }
    }
}