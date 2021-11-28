using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace CS_lab5.Model {
    [Serializable]
    public class User {
        public uint userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

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
