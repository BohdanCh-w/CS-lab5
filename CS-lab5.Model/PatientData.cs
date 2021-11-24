using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_lab4 {
    [Serializable]
    public enum BLOOD_TYPE {
        Group_O,
        Group_A,
        Group_B,
        Group_AB,
        UNKNOWN
    }

    [Serializable]
    public class PatientData {
        public BLOOD_TYPE bloodType { get; set; }
        public string location { get; set; }
        public List<AnalisisResult> analisisHistory { get; set; }

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