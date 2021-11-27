using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CS_lab5.Model;
using CS_lab5.UI.ViewModel;

namespace CS_lab5.UI {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private DataModel __model;
        private DataViewModel __viewModel;

        public App() {
            LoadData();
            __viewModel = new DataViewModel(__model);
            var window = new MainWindow(){ DataContext = __viewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e) {
            try { 
                __model = __viewModel.ToDataModel();
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
