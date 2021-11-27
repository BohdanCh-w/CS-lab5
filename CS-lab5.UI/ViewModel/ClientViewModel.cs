using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab5.UI.ViewModel {
    class ClientViewModel : BaseViewModel
    {
        private Client __client;
        public ClientViewModel(Client client) {
            __client = client;
        }

        public uint AssignedDoctor { 
            get { return __client.assignedDoctor; }
            set {
                __client.assignedDoctor = value;
                OnPropertyChanged(nameof(AssignedDoctor));
            }
        }

        public PatientData Data {
            get { return __client.data; }
            set {
                __client.data = value;
                OnPropertyChanged(nameof(Data));
            }
        }
    }
}
