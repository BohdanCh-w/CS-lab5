using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CS_lab5.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CS_lab5.Model.Test {
    [TestClass]
    public class SerializationTest {
        [TestMethod]
        public void SerialiseTest() {
            var model = new DataModel();
            uint userID = 0;
            uint analisisID = 0;
            model.Doctors = new List<Doctor>() {
                new Doctor(userID++, "First", "lastName", "Internist"),
                new Doctor(userID++, "Second", "lastName", "Psychiatrist"),
                new Doctor(userID++, "Third", "lastName", "Neurologist"),
                new Doctor(userID++, "Fourth", "lastName", "Anesthesiologist"),
            };
            model.Clients = new List<Client>() {
                new Client(userID++, "Fifth", "lastName", userID - 5, null),
                new Client(userID++, "Sixth", "lastName", userID - 5, null),
                new Client(userID++, "Seventh", "lastName", userID - 5, null),
            };
            model.PatientData = new List<PatientData>() {
                new PatientData(BLOOD_TYPE.Group_A, "Fifth location", null),
                new PatientData(BLOOD_TYPE.Group_AB, "Sixth location", null),
                new PatientData(BLOOD_TYPE.Group_O, "Seventh location", null),
            };
            model.AnalisisResults = new List<AnalisisResult> () {  
                new AnalisisResult(analisisID++, 37.9, "normal", null),
                new AnalisisResult(analisisID++, 36.6, "normal", null),
                new AnalisisResult(analisisID++, 38.2, "normal", new Dictionary<string, string>(){{"preasure", "128/80"},{"cardio", "id318"}}),
                new AnalisisResult(analisisID++, 36.9, "normal", new Dictionary<string, string>(){{"preasure", "123/76"},{"cardio", "id330"}}),
                new AnalisisResult(analisisID++, 39.9, "normal", null),
                new AnalisisResult(analisisID++, 38.4, "normal", null),
                new AnalisisResult(analisisID++, 37.2, "normal", null),
            };
            
            DataSerializer.Serialize(@"G:\Bohdan-G\.univer\5semestr\CS\.lab\CS-lab5\CS-lab5.Model\model.dat", model);
        }

        [TestMethod]
        public void DeserializeTest() {
            var model = DataSerializer.Deserialize(@"G:\Bohdan-G\.univer\5semestr\CS\.lab\CS-lab5\CS-lab5.Model\model.dat");
        }
    }
}
