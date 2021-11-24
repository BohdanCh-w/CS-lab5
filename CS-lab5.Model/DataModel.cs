using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_lab5.Model {
    [Serializable]
    class DataMode {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<PatientData> PatientData { get; set; }
        public IEnumerable<AnalisisResult> AnalisisResults { get; set; }
    }
}
