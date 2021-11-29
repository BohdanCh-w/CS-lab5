using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using CS_lab5.UI.Notifications;

namespace CS_lab5.UI.Converters {
    class NotificationResoursesConverter : IValueConverter {
        private Dictionary<NotificationType, BitmapImage> __cache = new Dictionary<NotificationType, BitmapImage>();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            Assembly myAssembly = Assembly.GetExecutingAssembly(); 
            Stream myStream = myAssembly.GetManifestResourceStream("CS_lab5.UI.assets.images.notifications.Status_INFO.png");
            IntPtr hBitmap = new Bitmap(myStream).GetHbitmap();
            return (BitmapImage)Imaging.CreateBitmapSourceFromHBitmap(
                            hBitmap,
                            IntPtr.Zero,
                            Int32Rect.Empty,
                            BitmapSizeOptions.FromEmptyOptions());
            return new Bitmap(myStream);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
