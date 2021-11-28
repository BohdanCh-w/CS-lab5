using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CS_lab5.UI.Notifications {
    class NotificationResoursesConverter : IValueConverter {
        private Dictionary<NotificationType, BitmapImage> __cache = new Dictionary<NotificationType, BitmapImage>();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            NotificationType status = (NotificationType)value;

            if(!__cache.ContainsKey(status)) {
                // Uri ImgUri = new Uri(@"..\assets\images\notifications\Status_INFO.png", UriKind.Relative);
                Uri ImgUri = new Uri($"G:\\Bohdan-G\\.univer\\5semestr\\CS\\.lab\\CS-lab5\\CS-lab5.UI\\assets\\images\\notifications\\Status_{status}.png", UriKind.Absolute);
                __cache.Add(status, new BitmapImage(ImgUri));                
            }

            return __cache[status];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
