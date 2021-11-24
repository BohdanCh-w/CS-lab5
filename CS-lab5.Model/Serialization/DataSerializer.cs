using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CS_lab5.Model {
    public class DataSerializer {
        public static void Serialize(string fileName, DataModel data) {
            var stream = new FileStream(fileName, FileMode.Create);
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
            stream.Close();
        }

        public static DataModel Deserialize(string fileName) {
            var stream = new FileStream(fileName, FileMode.Open);
            var formatter = new BinaryFormatter();
            return (DataModel)formatter.Deserialize(stream);
        }
    }
}
