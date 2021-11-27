using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CS_lab5.Model;

namespace CS_lab5.UI {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private DataModel __model;

        public App() {
            LoadData();
            var window = new MainWindow(){ DataContext = __model };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e) {
            try {
                __model.Save();
            }
            catch (Exception) {
                base.OnExit(e);
                throw;
            }
        }

        private void LoadData() {
            try {
                __model = DataModel.Load();
            }
            catch(FileNotFoundException) {
                __model = new DataModel();
            };
        }
    }
}
