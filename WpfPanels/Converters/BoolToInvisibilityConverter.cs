using System;
using System.Globalization;
using System.Windows;

namespace WpfPanels.Converters
{
    public class BoolToInvisibilityConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolValue = (bool?)value;
            if (boolValue == false)
                return Visibility.Visible;

            if (parameter != null && parameter.ToString() == "Hidden")
                return Visibility.Hidden;

            return Visibility.Collapsed;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
