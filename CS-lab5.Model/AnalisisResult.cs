using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace CS_lab5.Model {
    [Serializable]
    public class AnalisisResult {
        public uint analisisID { get; set; }
        public double temparature { get; set; }
        public string bloodTest { get; set; }
        public Dictionary<string,string> other { get; set; }

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

