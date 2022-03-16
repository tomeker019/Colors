using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ColorConvertor.Converter
{
    internal class RGBSplit : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //string rgbString = value.ToString().Substring(3);
            //string B = rgbString.Substring(rgbString.Length - 2);
            //string G = rgbString.Substring(2, 2);
            //string R = rgbString.Substring(0, 2);

            //return "(" + R + ", " + G +", " +B +")" ;

            if (value is SolidColorBrush color)
            {
                var R = color.Color.R;
                var G = color.Color.G;
                var B = color.Color.B;
                return $"({R}, {G}, {B})";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}