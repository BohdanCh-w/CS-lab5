using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CS_lab5.UI.Notifications;

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

        private ObservableCollection<User> __users;
        public ObservableCollection<User> Users {
            get { return __users; }
        }

        private User __selectedUser;
        public User SelectedUser {
            get { return __selectedUser; }
            set { 
                __selectedUser = value; 
                OnPropertyChanged(nameof(SelectedUser));
            }
        }

        private Client __selectedClient;
        public Client SelectedClient {
            get { return __selectedClient; }
            set {
                __selectedClient = value;
                OnPropertyChanged(nameof(SelectedClient));
            }
        }

        private string __appMode = "Users";
        public string AppMode {
            get { return __appMode; }
            set {
                __appMode = value;
                OnPropertyChanged(nameof(AppMode));
            }
        }

        public ICommand SetAppMode { get; set; }
        public void SetAppModeCmd(object args) {
            AppMode = args.ToString();
        }
        public bool CanSwitchAppMode(object args) {
            return AppMode != args.ToString();
        }

        public ICommand DeleteSelectedUser { get; set; }
        public void DeleteSelectedUserCmd(object args) {
            try {
                throw new Exception();
                if(SelectedUser.GetType() == typeof(Client)) {
                    Clients.Remove((Client)SelectedUser);
                } else if(SelectedUser.GetType() == typeof(Doctor)) {
                    Doctors.Remove((Doctor)SelectedUser);
                } else {
                    throw new ArgumentException("Wrong type of selected user");
                }
                SelectedUser = null;
                __users = getAllUsers();
                OnPropertyChanged(nameof(Users));
            } catch (Exception ex) {
                NotificationWindow.Notify(new Notification("Error", ex.Message, NotificationType.ERROR));
                return;
            }
            NotificationWindow.Notify(new Notification("Info", "User deleted successfuly", NotificationType.INFO));
        }
        public bool CanDeleteSelectedUser(object args) {
            return SelectedUser != null;
        }

        public DataViewModel(DataModel model) {
            __clients = new ObservableCollection<Client>(model.Clients);
            __doctors = new ObservableCollection<Doctor>(model.Doctors);
            __patientData = new ObservableCollection<PatientData>(model.PatientData);
            __analisisResults = new ObservableCollection<AnalisisResult>(model.AnalisisResults);

            __users = new ObservableCollection<User>(((IEnumerable<User>)model.Doctors).Concat((IEnumerable<User>)model.Clients));

            SetAppMode = new Command(SetAppModeCmd, CanSwitchAppMode);
            DeleteSelectedUser = new Command(DeleteSelectedUserCmd, CanDeleteSelectedUser);
        }

        private ObservableCollection<User> getAllUsers() {
            var users = ((IEnumerable<User>)Doctors).Concat((IEnumerable<User>)Clients);
            return new ObservableCollection<User>(users);
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
