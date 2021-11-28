using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace CS_lab5.Model {
    [Serializable]
    public class User : BaseViewModel {
        protected uint userID;
        protected string firstName;
        protected string lastName;

        public uint UserID { 
            get { return userID; }
            set {
                userID = value;
                OnPropertyChanged(nameof(UserID));
            }
        }

        public string FirstName {
            get { return firstName; }
            set {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName {
            get { return lastName; }
            set {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public User() {
            userID = 0;
            firstName = "";
            lastName = "";
        }
 
        public User(uint _userID, string _fistName, string _lastName) {
            userID = _userID;
            firstName = _fistName;
            lastName = _lastName;
        }

        public User(User other) : this(other.userID, other.firstName, other.lastName) { }
    }
}
