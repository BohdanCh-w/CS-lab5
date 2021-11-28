using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CS_lab5.UI.Converters
{
    class AppModeConverterContent : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return (string)value == (string)parameter ? "Visible" : "Collapsed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

    class AppModeConverterButton : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return (string)value == (string)parameter ? "False" : "True";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }


}
