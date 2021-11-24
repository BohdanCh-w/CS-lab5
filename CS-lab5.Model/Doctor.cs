using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_lab4 { 
    [Serializable]
    class Doctor : User {
        public string specialisation { get; set; }

        public Doctor() : base() {
            specialisation = "";
        }

        public Doctor(uint id, string fname, string lname, string spec) : 
                      base(id, fname, lname) {
            specialisation = spec;
        }
    }
}
