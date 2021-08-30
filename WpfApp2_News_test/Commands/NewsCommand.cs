using System;
using System.Windows.Input;

namespace WpfApp2_News_test.Commands
{
    public class NewsCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
 
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
 
        public NewsCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
        
    }
}