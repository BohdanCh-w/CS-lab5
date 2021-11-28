using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab5.UI.ViewModel {
    class DataViewModel : BaseViewModel {
        private ObservableCollection<Client> __clients;
        public ObservableCollection<Client> Clients {
            get { return __clients; } 
            set {
                __clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }
        private ObservableCollection<Doctor> __doctors;
        public ObservableCollection<Doctor> Doctors {
            get { return __doctors; } 
            set {
                __doctors = value;
                OnPropertyChanged(nameof(Doctors));
            }
        }
        private ObservableCollection<PatientData> __patientData;
        public ObservableCollection<PatientData> PatientData {
            get { return __patientData; } 
            set {
                __patientData = value; 
                OnPropertyChanged(nameof(PatientData));
            }
        }
        private ObservableCollection<AnalisisResult> __analisisResults;
        public ObservableCollection<AnalisisResult> AnalisisResults {
            get { return __analisisResults; } 
            set {
                __analisisResults = value;
                OnPropertyChanged(nameof(AnalisisResults));
            }
        }

        public DataViewModel(DataModel model) {
            __clients = new ObservableCollection<Client>(model.Clients);
            __doctors = new ObservableCollection<Doctor>(model.Doctors);
            __patientData = new ObservableCollection<PatientData>(model.PatientData);
            __analisisResults = new ObservableCollection<AnalisisResult>(model.AnalisisResults);
        }

        public DataModel ToDataModel() {
            return new DataModel() {
                Clients = (IEnumerable<Client>)__clients,
                Doctors = (IEnumerable<Doctor>)__doctors,
                PatientData = (IEnumerable<PatientData>)__patientData,
                AnalisisResults = (IEnumerable<AnalisisResult>)__analisisResults
            };
        }
    }
}
