using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace CS_lab5.Model {
    [Serializable]
    public class DataModel {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<PatientData> PatientData { get; set; }
        public IEnumerable<AnalisisResult> AnalisisResults { get; set; }

        public DataModel() {
            Clients = new List<Client>();
            Doctors = new List<Doctor>();
            PatientData = new List<PatientData>();
            AnalisisResults = new List<AnalisisResult>();
        }

        public static string DataPath = "model.dat";

        public static DataModel Load() {
            if(File.Exists(DataPath)) {
                return DataSerializer.Deserialize(DataPath);
            }
            throw new FileNotFoundException(DataPath);
        }

        public void Save() {
            DataSerializer.Serialize(DataPath, this);
        }
    }
}
