using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab5.UI.ViewModel {
    class DoctorViewModel : BaseViewModel {
        private Doctor __doctor;
        public DoctorViewModel(Doctor doctor) {
            __doctor = doctor;
        }

        public uint userID { 
            get { return __doctor.userID; }
            set {
                __doctor.userID = value;
                OnPropertyChanged(nameof(userID));
            }
        }

        public string firstName {
            get { return __doctor.firstName; }
            set {
                __doctor.firstName = value;
                OnPropertyChanged(nameof(firstName));
            }
        }

        public string lastName {
            get { return __doctor.lastName; }
            set {
                __doctor.lastName = value;
                OnPropertyChanged(nameof(lastName));
            }
        }

        public string specialisation {
            get { return __doctor.specialisation; }
            set {
                __doctor.specialisation = value;
                OnPropertyChanged(nameof(specialisation));
            }
        }
    }
}
