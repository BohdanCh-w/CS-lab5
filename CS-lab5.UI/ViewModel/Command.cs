using System;
using System.Windows;
using System.Windows.Input;

namespace CS_lab5.UI.ViewModel {
    public class Command : ICommand {
        public Command(Action<object> action) {
            ExecuteDelegate = action;
        }

        public Command(Action<object> action, Predicate<object> isExecutable) {
            ExecuteDelegate = action;
            CanExecuteDelegate = isExecutable;
        }

        public Predicate<object> CanExecuteDelegate { get; set; }
        public Action<object> ExecuteDelegate { get; set; }

        public bool CanExecute(object parameter) {
            return CanExecuteDelegate?.Invoke(parameter) ?? true;
        }

        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter) {
            ExecuteDelegate?.Invoke(parameter);
        }
    }
}
