using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab5.UI.ViewModel {
    class DataViewModel : BaseViewModel {      
        private ObservableCollection<ClientViewModel> __clients;
        public ObservableCollection<ClientViewModel> Clients {
            get { return __clients; } 
            set {
                __clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }
        private ObservableCollection<DoctorViewModel> __doctors;
        public ObservableCollection<DoctorViewModel> Doctors {
            get { return __doctors; } 
            set {
                __doctors = value;
                OnPropertyChanged(nameof(Doctors));
            }
        }
        private ObservableCollection<PatientDataViewModel> __patientData;
        public ObservableCollection<PatientDataViewModel> PatientData {
            get { return __patientData; } 
            set {
                __patientData = value; 
                OnPropertyChanged(nameof(PatientData));
            }
        }
        private ObservableCollection<AnalisisResultViewModel> __analisisResults;
        public ObservableCollection<AnalisisResultViewModel> AnalisisResults {
            get { return __analisisResults; } 
            set {
                __analisisResults = value;
                OnPropertyChanged(nameof(AnalisisResults));
            }
        }
    }
}
