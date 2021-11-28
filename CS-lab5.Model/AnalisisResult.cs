using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS_lab5.Model {
    [Serializable]
    public class AnalisisResult : BaseViewModel {
        private uint analisisID;
        private double temparature;
        private string bloodTest;
        private Dictionary<string,string> other;

        public uint AnalisisID { 
            get { return analisisID; }
            set {
                analisisID = value;
                OnPropertyChanged(nameof(AnalisisID));
            }
        }

        public double Temparature {
            get { return temparature; }
            set {
                temparature = value;
                OnPropertyChanged(nameof(Temparature));
            }
        }

        public string BloodTest {
            get { return bloodTest; }
            set {
                bloodTest = value;
                OnPropertyChanged(nameof(BloodTest));
            }
        }
        public Dictionary<string, string> Other {
            get { return other; }
            set {
                other = value;
                OnPropertyChanged(nameof(Other));
            }
        }

        public AnalisisResult() {
            analisisID = 0;
            temparature = 0;
            bloodTest = "";
            other = new Dictionary<string,string>();
        }

        public AnalisisResult(uint _analisisID, double _temparature, string _bloodTest, Dictionary<string,string> _other) {
            analisisID = _analisisID;
            temparature = _temparature;
            bloodTest = _bloodTest;
            other = _other;
        }
    }
}

