using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab5.UI.ViewModel {
    public class PatientDataViewModel : BaseViewModel {        
        private PatientData __patientData;
        public PatientDataViewModel(PatientData patientData) {
            __patientData = patientData;
        }

        public BLOOD_TYPE BloodType { 
            get { return __patientData.bloodType; }
            set {
                __patientData.bloodType = value;
                OnPropertyChanged(nameof(BloodType));
            }
        }

        public string Location { 
            get { return __patientData.location; }
            set {
                __patientData.location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        public List<AnalisisResult> AnalisisHistory {
            get { return __patientData.analisisHistory; }
            set {
                __patientData.analisisHistory = value;
                OnPropertyChanged(nameof(AnalisisHistory));
            }
        }
    }
}
