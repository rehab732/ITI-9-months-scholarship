using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCar.Commands
{
    public class TestCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Action<object> execute;
        Predicate<object> canExecute;
       public TestCommand(Action<object>_execute,Predicate<object> _canExecute)
        {
            execute= _execute;
            canExecute= _canExecute;
        }


        public bool CanExecute(object? parameter)
        {
            return canExecute== null?true:canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            execute.Invoke(parameter);
        }
    }
}
