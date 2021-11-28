using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_lab5.Model {
    [Serializable]
    public enum BLOOD_TYPE {
        Group_O,
        Group_A,
        Group_B,
        Group_AB,
        UNKNOWN
    }

    [Serializable]
    public class PatientData : BaseViewModel {
        private BLOOD_TYPE bloodType;
        private string location;
        private List<AnalisisResult> analisisHistory;

        public BLOOD_TYPE BloodType { 
            get { return bloodType; }
            set {
                bloodType = value;
                OnPropertyChanged(nameof(BloodType));
            }
        }

        public string Location { 
            get { return location; }
            set {
                location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        public List<AnalisisResult> AnalisisHistory {
            get { return analisisHistory; }
            set {
                analisisHistory = value;
                OnPropertyChanged(nameof(AnalisisHistory));
            }
        }

        public PatientData() {
            bloodType = BLOOD_TYPE.UNKNOWN;
            location = "";
            analisisHistory = null;
        }

        public PatientData(BLOOD_TYPE _bloodType, string _location, List<AnalisisResult> _analisisHistory) {
            bloodType = _bloodType;
            location = _location;
            analisisHistory = _analisisHistory;
        }
    }
}