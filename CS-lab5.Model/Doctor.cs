using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_lab5.Model { 
    [Serializable]
    public class Doctor : User {
        private string specialisation;

        public string Specialisation {
            get { return specialisation; }
            set {
                specialisation = value;
                OnPropertyChanged(nameof(Specialisation));
            }
        }

        public Doctor() : base() {
            specialisation = "";
        }

        public Doctor(uint id, string fname, string lname, string spec) : 
                      base(id, fname, lname) {
            specialisation = spec;
        }
    }
}
