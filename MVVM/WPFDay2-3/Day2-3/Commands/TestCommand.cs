using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Day2_3.Commands
{
    public class TestCommand:ICommand
    {
        Action<object> execute;
        Predicate<object> canExecute;

        public TestCommand(Action<object> _execute, Predicate<object> _canExecute)
        {
            execute = _execute;
            canExecute = _canExecute;

        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return canExecute == null ? true : canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            execute?.Invoke(parameter);
        }

    }
}
