using System;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;


namespace ProductApp.Helper
{
    [ValueConversion(typeof(int), typeof(System.Windows.Media.DashStyles))]
    class IntegerToUnderlineConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int.Parse(value.ToString()) > 1000) ?  DashStyles.Dot : DashStyles.DashDot;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
