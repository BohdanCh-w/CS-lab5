using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CS_lab5.UI.Converters
{
    class AssignedDoctorConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var doctors = (ObservableCollection<Doctor>)parameter;
            var doctor = doctors.Where(obj => obj.UserID == (uint)value).First();
            return $"{doctor.FirstName} {doctor.LastName}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
