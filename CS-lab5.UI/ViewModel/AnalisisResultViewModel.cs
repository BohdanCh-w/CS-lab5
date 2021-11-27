using CS_lab5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab5.UI.ViewModel {
    class AnalisisResultViewModel : BaseViewModel {
        private AnalisisResult __analisisResult;
        public AnalisisResultViewModel(AnalisisResult analisisResult) {
            __analisisResult = analisisResult;
        }

        public uint AnalisisID { 
            get { return __analisisResult.analisisID; }
            set {
                __analisisResult.analisisID = value;
                OnPropertyChanged(nameof(AnalisisID));
            }
        }

        public double Temparature {
            get { return __analisisResult.temparature; }
            set {
                __analisisResult.temparature = value;
                OnPropertyChanged(nameof(Temparature));
            }
        }

        public string BloodTest {
            get { return __analisisResult.bloodTest; }
            set {
                __analisisResult.bloodTest = value;
                OnPropertyChanged(nameof(BloodTest));
            }
        }
        public Dictionary<string, string> Other {
            get { return __analisisResult.other; }
            set {
                __analisisResult.other = value;
                OnPropertyChanged(nameof(Other));
            }
        }
    }
}
