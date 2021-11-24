using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_lab5.Model {
    [Serializable]
    class Client : User {
        public uint assignedDoctor { get; set; }
        public PatientData data { get; set; }

        public Client() : base() {
            assignedDoctor = 0;
            data = null;
        }

        public Client(uint id, string fname, string lname, 
                      uint _assignedDoctor, PatientData _data) : 
                      base(id, fname, lname) {
            assignedDoctor = _assignedDoctor;
            data = _data;
        }
    }
}
