using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF_Behpouyan_
{
    internal class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString() != "" && int.Parse(value.ToString()) > 200)
            {
                return Brushes.DarkRed;
            }
            else if(value.ToString() != "" && int.Parse(value.ToString()) > 100)
            {
                return Brushes.Yellow;
            }
            else
            {
                return Brushes.Beige;
            }
                 
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
